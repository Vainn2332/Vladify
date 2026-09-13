# Vladify

![CI](https://github.com/Vainn2332/Vladify/actions/workflows/ci.yml/badge.svg)
[![Quality gate status](https://sonarcloud.io/api/project_badges/measure?project=Vainn2332_Vladify&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=Vainn2332_Vladify)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=Vainn2332_Vladify&metric=coverage)](https://sonarcloud.io/summary/new_code?id=Vainn2332_Vladify)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=Vainn2332_Vladify&metric=ncloc)](https://sonarcloud.io/summary/new_code?id=Vainn2332_Vladify)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=Vainn2332_Vladify&metric=security_rating)](https://sonarcloud.io/summary/new_code?id=Vainn2332_Vladify)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=Vainn2332_Vladify&metric=sqale_rating)](https://sonarcloud.io/summary/new_code?id=Vainn2332_Vladify)

Backend API for the **Vladify** online music platform — an ASP.NET Core
(.NET 9) Web API backed by SQL Server, RabbitMQ (via MassTransit), Auth0 for
authentication, and a gRPC moderation service.

### !!! This is the platform's main service — start it first

This service's `compose.yml` **creates the shared Docker network
`vladify-network`**. The other components (`vladify.frontend`,
`vladify.notification`, `vladify.admin`, moderation) join that same network as
an **external** network, so they can only start once it exists. **Always bring
this service up first**, otherwise the others fail with
`network vladify-network not found`. See [Shared Docker network](#shared-docker-network).

---

## Tech stack

| Area | Technology |
|------|-----------|
| Language / runtime | C# 13, .NET 9 |
| Web framework | ASP.NET Core Web API (controllers, global exception middleware) |
| API docs | OpenAPI (`Microsoft.AspNetCore.OpenApi`) + [Scalar](https://scalar.com/) UI |
| Authentication | Auth0 — JWT Bearer, OAuth2 Authorization Code + PKCE |
| Database | SQL Server 2022 |
| ORM / migrations | Entity Framework Core 9 (SQL Server provider), auto-migrated on startup |
| Messaging | RabbitMQ via MassTransit 8 (with EF Core transactional outbox) |
| Inter-service calls | gRPC (`Grpc.Net.Client` / `ClientFactory`, Protobuf) — moderation service |
| Mapping / validation | AutoMapper, FluentValidation |
| Utilities | BCrypt.Net (hashing), Bogus (data seeding) |
| Testing | xUnit, Moq, AutoFixture, FluentAssertions, coverlet; integration via `WebApplicationFactory`, Testcontainers (MSSQL), Respawn |
| Containerization | Docker, Docker Compose |
| CI / quality | GitHub Actions, SonarCloud |

**Solution layout**

| Project | Responsibility |
|---------|----------------|
| `Vladify` | Web API host — controllers, DI wiring, middleware |
| `Vladify.BusinessLogic` | Services, validators, mapping, MassTransit setup |
| `Vladify.DataAccess` | EF Core `DbContext`, repositories, migrations, gRPC clients |
| `Vladify.Tests` (`Vladify.UnitTests`) | Unit tests |
| `Vladify.IntegrationTests` | Integration tests (Testcontainers + Respawn) |

---

## Prerequisites

| Tool | Version | Notes |
|------|---------|-------|
| [Docker](https://www.docker.com/) + Docker Compose | latest | Runs SQL Server, RabbitMQ, and the API. Enough to run the whole stack. |
| [.NET SDK](https://dotnet.microsoft.com/download) | 9.0 | Only needed to build/run/test the API outside Docker. |
| [Auth0](https://auth0.com/) tenant | — | Provides authentication and the API / M2M clients. |

---

## Quick start (Docker Compose)

Run everything from the `Vladify` folder (where `compose.yml` lives):

```bash
cd Vladify
```

### 1. Configure environment

Copy the template and fill in the values:

```bash
cp .env.example .env
```

Set at least these in `.env`:

- `DbPassword`, `DbName` — provision the SQL Server container and build the API's
  in-container connection string. `DbPassword` must satisfy SQL Server's policy
  (≥ 8 chars, mixing upper/lower/digits/symbols).
- `RabbitMqOptions__Username` / `RabbitMqOptions__Password` — RabbitMQ credentials.
- `ASPNETCORE_ENVIRONMENT` — set to `Development` to enable the Scalar / OpenAPI docs.
- `Auth0__*`, `ApiKeys__Auth0SyncInDb`, `GrpcClients__ModerationServiceUrl` — see
  [`Vladify/.env.example`](Vladify/.env.example) for every variable.

`.env` is git-ignored, so your secrets are never committed.

> **Config precedence.** ASP.NET Core reads `appsettings.json` first, then
> overrides it from environment variables, where `__` (double underscore) maps to
> nested sections (e.g. `Auth0__Domain` → `Auth0:Domain`). Inside Compose the `api`
> service overrides the `localhost`-based values from `.env`: the DB host becomes
> `sqlserver` and `RabbitMqOptions__ServerHost` becomes `rabbitmq`.

### 2. Start the stack

```bash
docker compose up -d --build
```

This creates the `vladify-network` and starts three services:

| Service | Container | Host port | Notes |
|---------|-----------|-----------|-------|
| API | `vladify-api` | `8080` | Built from `Vladify/Dockerfile` |
| SQL Server | `sqlserver` | `14330` → `1433` | Data persisted in the `mssql-data` volume |
| RabbitMQ | `rabbitmq` | `5672`, `15672` | Management UI on <http://localhost:15672> |

The API waits for SQL Server and RabbitMQ to become **healthy**, applies EF Core
migrations on startup (no manual migration step), and then listens on port `8080`.

> The SQL Server host port is **`14330`** (not `1433`) to avoid clashing with a
> local SQL Server instance. Connect a DB client to `localhost,14330`
> (user `sa`, password = your `DbPassword`, "trust server certificate" enabled).

### 3. Open the API docs

Use **`http://`** (the container serves plain HTTP on 8080 — `https://` gives
`ERR_SSL_PROTOCOL_ERROR`), and make sure `ASPNETCORE_ENVIRONMENT=Development`:

- Scalar UI: <http://localhost:8080/scalar>
- OpenAPI document: <http://localhost:8080/openapi/v1.json>

### Common commands

```bash
docker compose up -d --build api     # rebuild & restart just the API after code changes
docker compose up -d sqlserver rabbitmq   # infra only (e.g. to run the API from your IDE)
docker compose logs -f api           # follow API logs
docker compose down                  # stop (keeps data + network)
docker compose down -v               # stop and DELETE the database volume
```

---

## Shared Docker network

`compose.yml` declares a bridge network with a fixed name:

```yaml
networks:
  vladify-network:
    driver: bridge
    name: vladify-network
```

Because this service **owns and creates** `vladify-network`, it must be the
**first** thing you start. Sibling services attach to the same network by
declaring it as external, for example:

```yaml
networks:
  vladify-network:
    external: true
    name: vladify-network
```

Once they share the network, services reach each other by container name
(`sqlserver`, `rabbitmq`, `vladify-api`, …) instead of `localhost`.

---

## Run from your IDE (optional)

Start only the infrastructure, then run the API from your IDE / CLI:

```bash
docker compose up -d sqlserver rabbitmq
dotnet run --project Vladify/Vladify.csproj
```

Default local URLs (from `launchSettings.json`):

- HTTP: <http://localhost:5296>
- HTTPS: <https://localhost:7161> (Scalar: <https://localhost:7161/scalar/v1>)

When running on the host, point `ConnectionStrings__ApplicationDbContext` at
`Server=localhost,14330` so it reaches the **container** DB (otherwise it hits a
local SQL Server on 1433, if you have one).

---

## Run tests

```bash
dotnet test
```

Runs `Vladify.UnitTests` and `Vladify.IntegrationTests`. Integration tests spin
up SQL Server via Testcontainers, so Docker must be running.

---

## Troubleshooting

- **`network vladify-network not found`** (when starting another service) — this
  main service hasn't been started yet; run `docker compose up -d` here first.
- **Scalar / OpenAPI return 404** — the API is not in Development. Set
  `ASPNETCORE_ENVIRONMENT=Development` in `.env` and recreate: `docker compose up -d api`.
- **`ERR_SSL_PROTOCOL_ERROR` on `:8080`** — you used `https://`; the container
  serves plain HTTP. Use `http://localhost:8080`.
- **DB client: `Login failed for user 'sa'`** — you're likely hitting a *local*
  SQL Server on `1433`. Connect to `localhost,14330` and enable "trust server
  certificate". Also check `DbPassword` matches the value the volume was created
  with (the SA password is set only on first init — reset with `docker compose down -v`).
- **SQL Server container exits right after "Server process ID …"** — `DbPassword`
  is empty or fails the password policy (≥ 8 chars, 3 of 4 character classes).
- **Validation errors on startup** (`Configuration section Auth0 not found`, etc.)
  — options are validated on start; ensure every required `Auth0`,
  `RabbitMqOptions`, and connection-string value is set.
- **Cannot connect to RabbitMQ** — confirm the `rabbitmq` container is healthy and
  the credentials in `.env` match.
