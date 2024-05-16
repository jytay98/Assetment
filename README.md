# CDN - Complete Developer Network

A simple ASP.NET Core Web API for managing users with CRUD operations.

## Features

- Register, update, delete, and get users
- Structured logging with Serilog
- Request validation with FluentValidation
- API documentation with Swagger
- Containerization with Docker
- Continuous Integration/Continuous Deployment (CI/CD) with GitHub Actions

## Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Serilog
- FluentValidation
- AutoMapper
- xUnit
- Docker

## Getting Started

### Prerequisites

- .NET 5 SDK or later
- SQL Server
- Docker (optional)

### Setup

1. **Clone the Repository**

    ```bash
    git clone https://github.com/jytay98/Assetment.git
    cd Assetment
    ```

2. **Configure the Database**

    Update the connection string in `appsettings.json`.

3. **Run Database Migrations**

    ```bash
    dotnet ef database update
    ```

4. **Run the Application**

    ```bash
    dotnet run
    ```

5. **Access the API**

    Navigate to `https://localhost:5001/swagger` to use Swagger.

## API Endpoints

### Get All Users

- **URL:** `/api/users`
- **Method:** `GET`

### Get User by ID

- **URL:** `/api/users/{id}`
- **Method:** `GET`

### Create a New User

- **URL:** `/api/users`
- **Method:** `POST`
- **Request Body:**
    ```json
    {
      "username": "string",
      "mail": "string",
      "phoneNumber": "string",
      "skillsets": "string",
      "hobby": "string"
    }
    ```

### Update a User

- **URL:** `/api/users/{id}`
- **Method:** `PUT`

### Delete a User

- **URL:** `/api/users/{id}`
- **Method:** `DELETE`

## Additional Features

### Containerization

- Build and run the Docker image:
    ```bash
    docker build -t cdn-assessment .
    docker run -p 8080:80 cdn-assessment
    ```

### Testing

- Run unit tests:
    ```bash
    dotnet test
    ```

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

