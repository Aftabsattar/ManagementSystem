# ManagementSystem

## Description
ManagementSystem is a Department and Employee Management System designed to streamline the management of organizational departments and employees. The project provides a robust solution for tracking and managing employee records, departmental structures, and internal operations through a RESTful API.

## Features
- **Department Management**: Create, update, delete, and list departments with details such as name and location.
- **Employee Management**: Add, update, delete, and retrieve employee records, including attributes like name, email, phone, department, and joining date.
- **Department-wise Employee Listing**: View employees belonging to a specific department.
- **Hierarchical Structure**: Organize and display departments and employees in a structured format.
- **Robust API Endpoints**: RESTful endpoints for all CRUD operations on departments and employees.
- **Exception Handling**: Centralized error handling middleware for consistent API responses.
- **Automated Data Mapping**: Uses AutoMapper for DTO to entity mapping.
- **Database Migrations**: Managed with Entity Framework Core Migrations.
- **Interactive API Documentation**: Swagger integration for testing and exploring the API endpoints.
- **Secure Access**: Supports HTTPS redirection and authorization middleware.

## Technologies & Tools Used
- **Language**: C#
- **Framework**: ASP.NET Core (Web API)
- **ORM & Database**: Entity Framework Core, SQL Server
- **Dependency Injection**: Built-in ASP.NET Core DI
- **API Documentation**: Swagger / Swashbuckle
- **Object Mapping**: AutoMapper
- **IDE**: Visual Studio / VS Code
- **Others**: 
  - Middleware for exception handling
  - RESTful design patterns

## Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Aftabsattar/ManagementSystem.git
   ```

2. **Open the project in Visual Studio or VS Code.**

3. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

4. **Set up the database:**
   - Update the SQL Server connection string in `appsettings.json` (`DefaultConnection`).
   - Run migrations to create the schema:
     ```bash
     dotnet ef database update
     ```

5. **Build and run the project:**
   ```bash
   dotnet build
   dotnet run
   ```

6. **Access API documentation:**
   - Navigate to `https://localhost:<port>/swagger` in your browser.

## Usage

- Use the Swagger UI to interact with all available API endpoints for departments and employees.
- Integrate the API endpoints in your client application for automated or manual management.

## Contributing

Contributions are welcome! Follow these steps to contribute:
1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature-name
   ```
3. Make changes and commit:
   ```bash
   git commit -m "Description of changes"
   ```
4. Push to your fork:
   ```bash
   git push origin feature-name
   ```
5. Submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).

## Contact

For any inquiries or support, please contact:
- **Author**: Aftab Sattar
- **Email**: [Your Email]
- **GitHub**: [Aftabsattar](https://github.com/Aftabsattar)

---

**Notes:**
- Replace `[Your Email]` with your actual email address.
- Add any special configuration instructions if your project requires them.
