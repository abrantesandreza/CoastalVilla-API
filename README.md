# RESTful Web API with Authentication in .NET 7

Welcome to the **RESTful Web API with Authentication in .NET 7** repository! This project demonstrates the implementation of a secure RESTful Web API using the latest .NET 7 framework. The API includes authentication mechanisms to ensure data privacy and access control.

## Features

- **RESTful API:** Build and interact with a comprehensive set of endpoints following REST architectural principles.
- **Authentication:** Implement secure authentication to control access to the API's resources.
- **.NET 7:** Utilize the latest features and improvements from the .NET 7 framework.
- **Sample Data:** Explore the API with pre-seeded sample data.

**Endpoints - Users**

| Request  | Endpoint                | Parameter |
|----------|-------------------------|-----------|
| POST     | /UsersAuth/login        | N/A       |
| POST     | /UsersAuth/register     | N/A       |

**Swagger - Users**

![usersEndpoints](https://github.com/abrantesandreza/CoastalVilla-API/assets/87620471/25e7ad56-811d-4ce2-b326-8a0c36240933)

**Endpoints - VillaAPI**

| Request  | Endpoint                | Parameter |
|----------|-------------------------|-----------|
| GET      | /VillaAPI               | N/A       |
| POST     | /VillaAPI               | N/A       |
| GET      | /VillaAPI/{id}          | id        |
| DELETE   | /VillaAPI/{id}          | id        |
| PUT      | /VillaAPI/{id}          | id        |
| PATCH    | /VillaAPI/{id}          | id        |

**Swagger - VillaAPI**

![villaEndpoints](https://github.com/abrantesandreza/CoastalVilla-API/assets/87620471/9fa8d298-d486-4d37-b319-9e52033841f2)

**Endpoints - VillaNumberAPI**

| Request  | Endpoint                | Parameter |
|----------|-------------------------|-----------|
| GET      | /VillaNumberAPI         | N/A       |
| POST     | /VillaNumberAPI         | N/A       |
| GET      | /VillaNumberAPI/{id}    | id        |
| DELETE   | /VillaNumberAPI/{id}    | id        |
| PUT      | /VillaNumberAPI/{id}    | id        |
| PATCH    | /VillaNumberAPI/{id}    | id        |

**Swagger - VillaNumberAPI**

![villaNumberEndpoints](https://github.com/abrantesandreza/CoastalVilla-API/assets/87620471/bc82e142-197f-446e-907b-c7b3793df3f2)

## Authentication
The API implements token-based authentication to ensure secure access. To access protected endpoints, include your authentication token in the request headers.





## Contributing
Contributions are welcome! If you find a bug or have a suggestion, please create an issue or submit a pull request.
