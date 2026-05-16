# Blog Post Application - Development Guidelines

This is a C# ASP.NET Core blog post application with Entity Framework Core.

## Project Overview
- **Framework**: ASP.NET Core 8.0
- **Database**: Entity Framework Core with SQL Server/SQLite
- **Architecture**: Repository Pattern with Dependency Injection
- **Features**: CRUD operations for blog posts and comments, user management, tagging system

## Getting Started
1. Restore NuGet packages: `dotnet restore`
2. Update database: `dotnet ef database update`
3. Run application: `dotnet run`
4. Build project: `dotnet build`

## Project Structure
- `Models/` - Domain models (BlogPost, Comment, User, Tag)
- `Data/` - DbContext and migrations
- `Repositories/` - Data access layer
- `Services/` - Business logic layer
- `Controllers/` - API endpoints
- `DTOs/` - Data transfer objects
- `Migrations/` - Database schema migrations

## Development Workflow
- Follow SOLID principles
- Use dependency injection for services and repositories
- Write migrations for database changes
- Keep controllers thin, logic in services
