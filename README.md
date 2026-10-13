# Personal Expense Tracker API

A RESTful API for managing personal finances, built with **ASP.NET Core Web API, Entity Framework Core, SQL Server, and JWT authentication**. The application is designed to help users record income and expenses, organize transactions, and analyze their spending through financial summaries.

> **Project Status:** In Development

## Features

### Authentication and Authorization
- User registration and login.
- Secure password hashing.
- JWT-based authentication.
- Protected endpoints for authenticated users.
- User-specific transaction access and ownership validation.

### Transaction Management
- Create, retrieve, update, and delete transactions.
- Record income and expenses.
- Categorize transactions.
- Filter transactions by type, category, and date range.
- Validate transaction data.

### Financial Summaries
- Calculate total income and expenses.
- Calculate the remaining balance.
- Summarize expenses by category.
- Generate monthly financial summaries.

## Tech Stack

| Technology | Purpose |
|---|---|
| C# | Programming language |
| ASP.NET Core Web API | REST API development |
| Entity Framework Core | ORM and database access |
| SQL Server | Relational database |
| JWT Bearer Authentication | Authentication and access control |
| Scalar | API documentation and testing |
| LINQ | Data querying and aggregation |

## Architecture

The application follows a **single-project structure** with separated responsibilities to keep the code organized and maintainable.

The planned components include:

- **Controllers:** Handle HTTP requests and responses.
- **Services:** Contain application and business logic.
- **Entities:** Represent database entities.
- **DTOs:** Define API request and response contracts.
- **Data Access:** Manage the database context and EF Core configuration.
- **Authentication:** Handle JWT configuration and authenticated user identity.

## Database Design

The initial database design includes two main entities.

### User
Stores user account information, including a unique identifier, username, and securely hashed password.

### Transaction
Stores transaction information, including:

- Transaction ID
- User ID
- Title
- Amount
- Transaction type
- Category
- Transaction date
- Optional notes

Each transaction belongs to a user through a foreign key relationship.

## API Endpoints

The following endpoints are planned for the initial version.

### Authentication

| Method | Endpoint | Description |
|---|---|---|
| POST | `/api/auth/register` | Register a new user |
| POST | `/api/auth/login` | Authenticate a user and obtain a JWT |

### Transactions

| Method | Endpoint | Description |
|---|---|---|
| POST | `/api/transactions` | Create a transaction |
| GET | `/api/transactions` | Retrieve the authenticated user's transactions |
| GET | `/api/transactions/{id}` | Retrieve a transaction by ID |
| PUT | `/api/transactions/{id}` | Update a transaction |
| DELETE | `/api/transactions/{id}` | Delete a transaction |
| GET | `/api/transactions/summary` | Retrieve financial summaries |
| GET | `/api/transactions/by-category` | Retrieve spending totals by category |

These routes describe the intended API contract and may evolve during development.

## Security Considerations

- Passwords must never be stored as plain text.
- JWTs must be validated before their claims are trusted.
- The authenticated user's identity must be derived from validated token claims.
- Users must not be able to access or modify transactions belonging to other users.
- Sensitive configuration values must not be committed to source control.
- Request data must be validated before processing.

## Getting Started

### Prerequisites

Install the following tools:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/sql-server)
- [SQL Server Management Studio](https://learn.microsoft.com/sql/ssms/download-sql-server-management-studio-ssms)
- [Git](https://git-scm.com/downloads)

A compatible SQL Server installation or instance is required.

### Setup

1. Clone the repository:

   ```bash
   git clone <your-repository-url>
   cd <your-project-directory>
   ```

2. Configure the SQL Server connection string using local development configuration or user secrets.

3. Configure the JWT settings, including the signing key, issuer, audience, and token expiration.

4. Restore dependencies:

   ```bash
   dotnet restore
   ```

5. Apply the Entity Framework Core migrations:

   ```bash
   dotnet ef database update
   ```

   If the EF Core CLI tool is not installed, install it first. Ensure the project has the required EF Core provider and design-time packages.

6. Run the application:

   ```bash
   dotnet run
   ```

7. Open the Scalar API documentation URL configured by the application and test the available endpoints.

> The setup instructions assume that migrations, configuration, and Scalar integration have been configured in the project. Adjust the commands and documentation URL to match the actual implementation.

## Learning Objectives

This project is also a hands-on learning exercise focused on:

- Designing RESTful APIs.
- Understanding dependency injection and service-based organization.
- Working with EF Core, LINQ, relationships, and database migrations.
- Implementing JWT authentication and authorization.
- Designing DTOs and handling HTTP status codes.
- Enforcing data ownership and validation rules.
- Writing maintainable, secure, and testable backend code.

## Future Improvements

Potential improvements after the core API is complete include:

- Automated unit and integration tests.
- Pagination and sorting.
- Centralized exception handling and structured logging.
- Budget management and recurring transactions.
- API versioning and deployment.

## License

Choose a license before distributing or publishing the project for reuse. If no license is added, the repository is not automatically open source.