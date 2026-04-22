# GitHub Copilot Instructions

## Tech Stack
- .NET 6
- ASP.NET Core Minimal API
- C#
- Built-in Dependency Injection
- XUnit for testing
- Entity Framework Core

---

## Architecture Overview

This project follows a clean, service-oriented architecture:

Endpoints (Minimal API)
    ↓
Services (Business Logic)
    ↓
Data Layer (DbContext / Repositories)

### Principles
- Keep endpoints thin
- Encapsulate business logic in services
- Separate concerns clearly

---

## Recommended Folder Structure

/src/Endpoints
/src/Services
    /Interfaces
    /Implementations
/src/Data
/src/Models
/src/Common (optional: helpers, extensions, constants)
/tests/ (for unit tests)

---

## Minimal API Guidelines

- Define endpoints in Program.cs or modular endpoint files
- Do NOT place business logic inside endpoints
- Always delegate to services

### Example

    app.MapGet("/users/{id}", async (int id, IUserService userService) =>
    {
        var user = await userService.GetByIdAsync(id);
        return user is not null ? Results.Ok(user) : Results.NotFound();
    });

---

## Services Layer

### Rules
- Contains all business logic
- Must be testable
- Should not depend on HTTP-specific objects

### Interface Example

    public interface IUserService
    {
        Task<User?> GetByIdAsync(int id);
    }

### Implementation Example

    public class UserService : IUserService
    {
        public async Task<User?> GetByIdAsync(int id)
        {
            // Business logic here
            return new User { Id = id, Name = "Test" };
        }
    }

---

## Dependency Injection

Register all services in Program.cs:

    builder.Services.AddScoped<IUserService, UserService>();

### Guidelines
- Use Scoped for services
- Avoid Singleton unless truly stateless and thread-safe
- Avoid Transient for heavy services

---

## Data Access

- Use EF Core DbContext or repository pattern
- Keep data logic separate from services where possible

### Example

    public class AppDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
    }

---

## Models

- Use simple POCO classes
- Avoid embedding business logic
- Use DTOs when needed for API responses

---

## .NET 6 Best Practices

### General
- Use async/await for all I/O operations
- Keep methods small and focused
- Use meaningful naming conventions
- Prefer immutability where possible

### Minimal API
- Group related endpoints logically
- Use extension methods to organize endpoints
- Return Results instead of raw objects

### Dependency Injection
- Depend on abstractions (interfaces), not implementations
- Avoid service locator pattern
- Keep constructor injection clean

### Error Handling
- Use global exception handling middleware
- Avoid try/catch in every endpoint unless necessary

### Validation
- Validate input at the endpoint level
- Use FluentValidation or manual validation

### Logging
- Use built-in logging (ILogger<T>)
- Log important events, not everything

### Configuration
- Use appsettings.json
- Avoid hardcoding values

---

## Anti-Patterns

- Business logic inside endpoints
- Direct DbContext usage in endpoints
- Static service classes
- Large, bloated services
- Tight coupling between layers

---

## Documentation Requirements

- **Interface and domain classes** must include **XML summary comments**.
- **Implementation classes** must use the **`<inheritdoc />`** tag where applicable.

---

## Unit Test requirements

- Services must be unit testable
- Mock dependencies via interfaces
- Avoid testing Minimal API endpoints directly unless necessary
- Use XUnit for unit testing.
- Follow arrange-act-assert pattern in tests.
- Mock dependencies using a mocking framework (e.g., Moq).
- Create/update unit tests when adding or modifying functionality.

---

## Copilot Guidance

When generating code, always:
- Use Minimal API patterns
- Follow service-based architecture
- Inject dependencies via constructor or parameters
- Prefer async methods
- Keep code clean, readable, and maintainable
- Avoid unnecessary complexity
- Always add unit tests
