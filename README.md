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
| [Docker](https://www.docker.com/) + Docker Compose | latest | Runs RabbitMQ (and, optionally, SQL Server). |
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
RabbitMQ credentials, and the gRPC URL. Each variable is documented in
[`Vladify/.env.example`](Vladify/.env.example). `.env` is git-ignored, so your
secrets are never committed.

**How configuration is resolved.** ASP.NET Core reads `appsettings.json` first,
then overrides it from environment variables, where `__` (double underscore)
maps to nested sections (e.g. `Auth0__Domain` → `Auth0:Domain`).

- `.env` is read **automatically by Docker Compose** for the RabbitMQ service.
- For the **API** choose one of: export the `.env` values as environment
  variables before `dotnet run`, use `dotnet user-secrets` (the project has a
  `UserSecretsId`), or fill `appsettings.Development.json`.

---

## 2. Start the infrastructure

From the `Vladify` folder (where `compose.yml` lives):

```bash
docker compose up -d
```

### SQL Server (required)

Migrations are applied **automatically on startup**, so you only need a reachable
instance and a valid `ConnectionStrings__ApplicationDbContext`. Use LocalDB
(Windows) or a container:

```bash
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Your_password123" \
  -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
```

---

## 3. Run the API

```bash
dotnet run --project Vladify/Vladify.csproj
```

Default local URLs (from `launchSettings.json`):

- HTTP:  <http://localhost:5296>
- HTTPS: <https://localhost:7161>

In the `Development` environment, interactive API docs (Scalar / OpenAPI) are at:

- Scalar UI: <https://localhost:7161/scalar/v1> (pre-wired for the Auth0 login flow)
- OpenAPI document: <https://localhost:7161/openapi/v1.json>

---

## Run with Docker (API container)

The API has a `Dockerfile` (`Vladify/Vladify/Dockerfile`) exposing port `8080`.
From the `Vladify` folder:

```bash
docker build -t vladify-api -f Vladify/Dockerfile .
docker run --rm -p 8080:8080 --env-file .env vladify-api
```

`compose.yml` defines only RabbitMQ, so the container must reach SQL Server and
RabbitMQ over the network — use host-reachable addresses, not `localhost`, from
inside the container.

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
