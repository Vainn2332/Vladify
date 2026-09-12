# Vladify

Backend API for the **Vladify** online music platform — an ASP.NET Core
(.NET 9) Web API backed by SQL Server, RabbitMQ (via MassTransit), Auth0 for
authentication, and a gRPC moderation service.

This README explains how to run the API locally for development.

---

## Prerequisites

| Tool | Version | Notes |
|------|---------|-------|
| [.NET SDK](https://dotnet.microsoft.com/download) | 9.0 | Build and run the API. |
| [Docker](https://www.docker.com/) + Docker Compose | latest | Runs SQL Server, RabbitMQ, and the API. |
| SQL Server | 2019+ / LocalDB | Any reachable instance (LocalDB, container, or remote). |
| [Auth0](https://auth0.com/) tenant | — | Provides authentication and the API / M2M clients. |

The companion components (`vladify.frontend`, `vladify.notification`,
`vladify.admin`, and the moderation gRPC service) are needed for full
end-to-end functionality, but the API will start without them.

---

## 1. Configure environment

Configuration lives in `Vladify/appsettings.json` with **empty placeholder
values** — don't put real secrets there. Instead copy the template and fill it in:

```bash
cd Vladify
cp .env.example .env
```

Edit `.env` and set the database connection string, Auth0 credentials, API keys,
RabbitMQ credentials, and the gRPC URL. For Docker Compose also set `DbPassword`
and `DbName`, which provision the SQL Server container and build the API's
in-container connection string. Each variable is documented in
[`Vladify/.env.example`](Vladify/.env.example). `.env` is git-ignored, so your
secrets are never committed.

**How configuration is resolved.** ASP.NET Core reads `appsettings.json` first,
then overrides it from environment variables, where `__` (double underscore)
maps to nested sections (e.g. `Auth0__Domain` → `Auth0:Domain`).

- `.env` is read **automatically by Docker Compose** for its services (including
  the `api` container via `env_file`).
- For the **API** choose one of: export the `.env` values as environment
  variables before `dotnet run`, use `dotnet user-secrets` (the project has a
  `UserSecretsId`), or fill `appsettings.Development.json`.

---

## 2. Start the infrastructure

`compose.yml` defines three services — **SQL Server** (port `1433`), **RabbitMQ**
(AMQP `5672`, management UI <http://localhost:15672>), and the **API** itself
(built from its Dockerfile, exposed on port `8080`). Run all commands from the
`Vladify` folder (where `compose.yml` lives).

**Run the full stack** (DB + broker + API):

```bash
docker compose up -d
```

The API waits for SQL Server and RabbitMQ to become healthy, applies EF Core
migrations on startup (no manual migration step), and listens on
<http://localhost:8080>.

**Or start only the infrastructure** — when you want to run/debug the API from
your IDE (see step 3):

```bash
docker compose up -d sqlserver rabbitmq
```

> The compose SQL Server is provisioned with `DbPassword`, and the `api` service
> builds its in-container connection string from `DbName` + `DbPassword` (as
> `sa`). Keep them in sync with the `Password=` / `Database=` values inside the
> `localhost` `ConnectionStrings__ApplicationDbContext` used when you run the API
> outside compose.
>
> Prefer your own SQL Server (LocalDB, remote, …)? Start only `rabbitmq` and
> point `ConnectionStrings__ApplicationDbContext` at your instance instead.

## Run with Docker (API container)

The `api` service in `compose.yml` builds the image from
`Vladify/Vladify/Dockerfile` (context: the `Vladify` folder) and exposes port
`8080`. `docker compose up -d --build` (see step 2) builds and runs it together
with SQL Server and RabbitMQ.

Inside the compose network the API reaches the other services by name, so the
`api` service overrides the `localhost`-based `.env` values: the DB host becomes
`sqlserver` and `RabbitMqOptions__ServerHost` becomes `rabbitmq`. The in-container
connection string connects as `sa`, with the database name and password taken
from `DbName` / `DbPassword`.

> The moderation gRPC service is not part of `compose.yml`. If you containerize
> the API, `GrpcClients__ModerationServiceUrl=https://localhost:7000` will not
> reach a service on your host — point it at a reachable address instead.


---

## Run tests

From the `Vladify` folder:

```bash
dotnet test
```

Runs both `Vladify.UnitTests` and `Vladify.IntegrationTests`.

---

## Troubleshooting

- **Validation errors on startup** (`Configuration section Auth0 not found`,
  etc.) — options are validated on start; make sure every required `Auth0`,
  `RabbitMqOptions`, and connection-string value is set.
- **`Connection string 'ApplicationDbContext' is not found`** — set
  `ConnectionStrings__ApplicationDbContext`.
- **Cannot connect to RabbitMQ** — confirm `docker compose up -d` is running and
  that `RabbitMqOptions__ServerHost` / `Username` / `Password` match your `.env`.
- **gRPC errors** — the moderation service (`GrpcClients__ModerationServiceUrl`)
  must be reachable.
