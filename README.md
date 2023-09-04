# Cattastic Microservices Documentation

## Migrations

Install the Entity Framework Core CLI tool: `dotnet tool install --global dotnet-ef`

Create a new migration with dotnet ef migrations tool: `dotnet ef migrations add <migration_name>`.

Remove newly created migration: `dotnet ef migrations remove`.

Apply added migration to database: `dotnet ef database update`.

## Duende Identity Server

Install Duende Identity Server templates: `dotnet new install Duende.IdentityServer.Templates`
