# RESTful Web API with Authentication in .NET 7

Welcome to the **RESTful Web API with Authentication in .NET 7** repository! This project demonstrates the implementation of a secure RESTful Web API using the latest .NET 7 framework. The API includes authentication mechanisms to ensure data privacy and access control.

## Features

- **RESTful API:** Build and interact with a comprehensive set of endpoints following REST architectural principles.
- **Authentication:** Implement secure authentication to control access to the API's resources.
- **.NET 7:** Utilize the latest features and improvements from the .NET 7 framework.
- **Sample Data:** Explore the API with pre-seeded sample data.

## User Interface

- Website view

![image](https://github.com/abrantesandreza/CoastalVilla-API/assets/87620471/f33f0426-93f0-4b5c-9726-ee4981aac1f6)

- Register and Login

![image](https://github.com/abrantesandreza/CoastalVilla-API/assets/87620471/fe731feb-2e3c-4609-8172-caef281b1cbb)

![image](https://github.com/abrantesandreza/CoastalVilla-API/assets/87620471/5634f0c7-ce22-4bee-b7bf-ffd5a5e0a137)

- Villas

![image](https://github.com/abrantesandreza/CoastalVilla-API/assets/87620471/0ada1212-1711-4025-b750-2c3f3ec5a0a4)

![image](https://github.com/abrantesandreza/CoastalVilla-API/assets/87620471/f6af12ab-7d0d-40df-923c-b116ad929773)

![image](https://github.com/abrantesandreza/CoastalVilla-API/assets/87620471/81ae3f5a-68e2-49c7-ad5b-4159e644db8b)

![image](https://github.com/abrantesandreza/CoastalVilla-API/assets/87620471/52b29083-513f-4696-8224-81e5389cac09)

- Rooms

![image](https://github.com/abrantesandreza/CoastalVilla-API/assets/87620471/954146d5-eee6-4eec-8d8b-4d3ff63a7e86)

![image](https://github.com/abrantesandreza/CoastalVilla-API/assets/87620471/13d686dd-39fb-42f1-a79a-edc3a5b210ac)

![image](https://github.com/abrantesandreza/CoastalVilla-API/assets/87620471/05683806-5ce8-4f47-84d0-24abc3697c1f)

![image](https://github.com/abrantesandreza/CoastalVilla-API/assets/87620471/31a19c82-0663-4c8b-8482-0b6330be2e72)

## Video Demo

- Not allowed users

https://drive.google.com/file/d/1bC2fLiDAbUIFSiUL7LFwnOIJIAeN_xI7/view?usp=sharing

- Admin level
  
https://drive.google.com/file/d/1qGXeNlS_09_jaHPx1G0SvXmD32uQhj1k/view?usp=sharing

## API

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
