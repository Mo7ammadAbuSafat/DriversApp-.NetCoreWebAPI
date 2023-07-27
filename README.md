# Drivers App API with MongoDB - .NET Core

![image](https://github.com/Mo7ammadAbuSafat/DriversApp-.NetCoreWebAPI/assets/103439731/0dee5919-e8fd-4e67-aebc-6774e3af9423)



## Table of Contents

- [Description](#description)
- [Usage](#usage)
- [Technologies Used](#technologies-used)
- [Endpoints](#endpoints)
- [MongoDB Integration](#mongodb-integration)
- [Contributing](#contributing)
- [Contact](#contact)

## Description

Is a .NET Core project that provides CRUD operations for the Driver. The Driver represents driver information with properties like `name`, `number`, and `team`. This project serves as a practical example of how to work with MongoDB in a .NET Core environment.

The API allows users to create, read, update, and delete driver records through HTTP requests.


## Usage

1. Ensure you have MongoDB installed and running.
2. Make sure you have the necessary dependencies installed.
3. Start the API server: `dotnet run`

## Technologies Used

- MongoDB
- ASP.NET Core Web API

## Endpoints

The API provides the following endpoints to perform CRUD operations on the Driver objects:

- **GET /api/drivers**: Get a list of all drivers.
- **GET /api/drivers/{id}**: Get a specific driver by ID.
- **POST /api/drivers**: Create a new driver.
- **PUT /api/drivers/{id}**: Update an existing driver by ID.
- **DELETE /api/drivers/{id}**: Delete a driver by ID.


## MongoDB Integration

The project demonstrates how to integrate MongoDB in a .NET Core application. MongoDB is a NoSQL database that provides flexibility and scalability. In this project, the MongoDB database is used to store driver information.

Key points about MongoDB integration in this project:

- MongoDB connection configuration in `appsettings.json`.
- Usage of the MongoDB C#/.NET driver to interact with the database.
- Mapping of Driver objects to MongoDB documents using attributes or configurations.

## Contributing

Contributions to this project are welcome! If you find any bugs or have suggestions for improvement, please feel free to open an issue or submit a pull request.

1. Fork the project.
2. Create your feature branch: `git checkout -b feature/my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin feature/my-new-feature`
5. Submit a pull request.

## Contact

If you have any questions or feedback regarding this project, you can reach me at:
- Email: mo7ammad.abusafat@gmail.com
- LinkedIn: https://www.linkedin.com/in/mohammad-abusafat/

<!-- You can include other contact information if you prefer -->
