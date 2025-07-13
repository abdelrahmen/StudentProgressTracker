# Student Progress Tracker

This document provides a technical overview of the Student Progress Tracker application, including architecture decisions, security considerations, performance strategies, integration capabilities, deployment notes, and the use of AI tools during development.

## Architecture

This solution uses **Clean Architecture** to separate concerns. The project consists of the following layers:

-   **Domain:** Contains the core business logic, entities, and value objects. It has no dependencies on other layers.
-   **Application:** Contains application-specific logic, services, and interfaces. It orchestrates domain objects to perform business operations.
-   **Infrastructure:** Implements external concerns like database access and third-party integrations, based on interfaces defined in the Application layer.
-   **API:** The presentation layer, exposing functionality via a RESTful API. It depends on the Application layer.

This separation helps in testing, maintenance, and future development by isolating the business logic from external frameworks and technologies.

Key architectural choices:

**Dependency** Inversion: The outer layers depend on abstractions defined in inner layers.

**Entity Framework Core** is used for data access via the Infrastructure layer.

**Mapster** is used for mapping between domain models and DTOs to reduce boilerplate.


## Security

The following security features are implemented:

-   **Authentication:** JWT-based authentication is used. A token is issued upon login and required for subsequent authenticated requests.
-   **Authorization:** Role-based access control (RBAC) restricts endpoint access based on user roles (e.g., Teacher, Student).
-   **Global Exception Handling:** A middleware component catches unhandled exceptions to prevent exposing sensitive information in error responses.

## Performance

Performance is addressed through the following approaches:

-   **Asynchronous Operations:** I/O-bound database operations are implemented asynchronously with `async/await` to improve request handling throughput.
-   **Optimized Data Fetching:** Data is projected to DTOs in database queries to avoid over-fetching unnecessary data.
-   **Caching (Implemented for Some Endpoints)**  MemoryCache is used to store frequently requested query results (e.g., class summaries, student lists).
-   **Indexing Considerations**   Queries are designed to leverage database indexes (e.g., StudentId, SubjectId, LastActivity).

## Enterprise Integration

Integration with other systems is supported by the following:

-   **RESTful API:** A Swagger/OpenAPI-documented RESTful API is provided for consumption by other services.
-   **Configuration:** The application uses the standard .NET configuration system, allowing for environment-specific settings (e.g., `appsettings.Development.json`).
-   **Modular Services**  Application services follow SOLID principles, allowing easy extension or replacement.
-   **Audit-Readiness(Optional Extension)** Audit logging is suggested and partially scaffolded, ready for integration.

## Scalability and Deployment

The following points cover scalability and deployment:

-   **Containerization:** The application is suitable for containerization with Docker for consistent deployments and can be managed by an orchestrator like Kubernetes for scaling.
-   **Cross-Platform:** As a .NET application, it can be deployed on Windows or Linux, supporting various cloud providers (Azure, AWS, etc.).
-   **CI/CD:** The solution structure is compatible with standard CI/CD pipelines for automated build, test, and deployment processes.

## AI Tool Usage

As part of the task, AI tools (ChatGPT-4, Claude, Gemini, copilot, and more) were used to accelerate development:

-   **Prompt Engineering:** Tasks were broken into detailed prompts to get context-aware and realistic results (e.g., "map this EF query to a DTO using Mapster").
-   **Boilerplate Code:** Created DTOs, AutoMapper configurations, and basic service/controller methods.
-   **Documentation:** Portions of this README were collaboratively drafted using guided prompts and developer review.
-   **Unit Test:** Assisted in generating this unit tests.

## Getting Started (Setup Instructions)
To get the project up and running locally:
-   **Clone the Repository** 
git clone https://github.com/abdelrahmen/StudentProgressTracker.git
cd StudentProgressTracker.
-   **Apply Database Migrations** 
cd StudentProgressTracker.Infrastructure
dotnet ef database update
and this will get the seed inserted and ready
-   **Run the API:** 
cd StudentProgressTracker.API
dotnet run

-   **Swagger UI will be available at:** https://localhost:5001/swagger.

## Final Note
During the completion of this task, I was affected by a country-wide internet outage in Egypt, which caused limited access to resources, tools, and testing environments.

Despite the challenges, I managed to deliver a working version of the system using a limited and unstable connection.

I acknowledge this submission is not fully reflective of my usual quality or productivity, and I would be happy to iterate or improve upon it further in a more stable working environment.