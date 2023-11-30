# RESTful Web API with Authentication in .NET 7

Welcome to the **RESTful Web API with Authentication in .NET 7** repository! This project demonstrates the implementation of a secure RESTful Web API using the latest .NET 7 framework. The API includes authentication mechanisms to ensure data privacy and access control.

## Features

- **RESTful API:** Build and interact with a comprehensive set of endpoints following REST architectural principles.
- **Authentication:** Implement secure authentication to control access to the API's resources.
- **.NET 7:** Utilize the latest features and improvements from the .NET 7 framework.
- **Sample Data:** Explore the API with pre-seeded sample data.

**Endpoints - Users**

| Verbo  | Endpoint                | Parâmetro |
|--------|-------------------------|-----------|
| POST   | /UsersAuth/login        | N/A       |
| POST   | /UsersAuth/register     | N/A       |

**Endpoints - VillaAPI**

| Verbo  | Endpoint                | Parâmetro |
|--------|-------------------------|-----------|
| GET    | /VillaAPI               | N/A       |
| POST   | /VillaAPI               | N/A       |
| GET    | /VillaAPI/{id}          | id        |
| DELETE | /VillaAPI/{id}          | id        |
| PUT    | /VillaAPI/{id}          | id        |
| PATCH  | /VillaAPI/{id}          | id        |

**Endpoints - VillaNumberAPI**

| Verbo  | Endpoint                | Parâmetro |
|--------|-------------------------|-----------|
| GET    | /VillaNumberAPI         | N/A       |
| POST   | /VillaNumberAPI         | N/A       |
| GET    | /VillaNumberAPI/{id}    | id        |
| DELETE | /VillaNumberAPI/{id}    | id        |
| PUT    | /VillaNumberAPI/{id}    | id        |
| PATCH  | /VillaNumberAPI/{id}    | id        |


## Authentication
The API implements token-based authentication to ensure secure access. To access protected endpoints, include your authentication token in the request headers.





## Contributing
Contributions are welcome! If you find a bug or have a suggestion, please create an issue or submit a pull request.
