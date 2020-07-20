# „XmlToModel”
> A simple .Net Core Web Api that reads xml files and projects them to the structural model

## Content
* [Main information](#main-information)
* [Technologies](#technologies)
* [Setup](#setup)
* [How Does It Work](#how-does-it-work)
* [Capabilities](#capabilities)
* [Status](#status)
* [Author](#author)

## Main information
This is a simple .Net Core Web Api that reads xml files and projects them to the structural model
The application reads a xml file, cleans it and finally creates a model that is based on the C# classes.
The application includes JWT authentication and Swagger UI.

## Technologies
* C# Asp .Net Core 3.1.
* Entity framework core
* JWT token authentication
* NewtonSoft Json
* Swashbuckle (Swagger)
* MSSQL Server 2017 Express Edition
* IDE – Visual Studio 2019

## Setup
1. Download the solution
2. Open the solution in Visual Studio
3. Configure connection string inside the appsettings.json
4. Create a database using Entity Framework (type database-update in the Package Manage Console)
5. Run the solution using Visual Studio IIS Express
6. Register a new user using Swagger UI -> AuthController -> RegisterNewUser
7. Log in to the application using Swagger UI ->AuthController -> Login
8. Click "Try it out"
9. Type your login and password into specified fields
10. Click "execute to generate a JWT token"
11. Copy generated token
12. Click "Auhorize" button using Swagger UI
13. Paste the token and click "Authorize"
14. Enjoy the app!

## How Does It Work
![Scheme] (/images/logo.png)
Format: ![Alt Text](url)

## Capabilities
Application	capabilities:
* Creating a new user
* Storing user's password in the database as hashcode
* Authorization using JWT token
* Iporting xml file (use provided example)
* Creating a c# class model that is based on the xml fie content

To-do list:
* Mapping a generated model to output dto using automapper

## Status
Stable, working, new function are developed

## Author
Seweryn Krupiński
.Net Dev
skrupinski86@gmail.com
github.com/sewerynkrupinski


