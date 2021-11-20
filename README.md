# _Animal Shelter API_ 

#### By Dylan Allison-Damitz

## Technologies Used :floppy_disk:
* NuGet Package Manager
* C#
* .Net 5
* REPL
* MySQL
* MySQL Workbench
* Microsoft Enity Framework
* Swagger

## Project Description :page_with_curl:
A RESTful C# web API for an animal shelter providing full CRUD functionality to anyone with admin access.
This application allows administrators to create new animals, update existing animals, and delete animals no longer at the shelter. An admin can also access the built-in Swagger functionality to test and navigate custom end points.

## Setup/Installation Requirements :triangular_ruler:

* Clone github repo: https://github.com/Dylan-Allison-Damitz/AnimalShelterApi.Solution.git
* Navigate into the directory from your desktop: `cd AnimalShelterApi.Solution`
* Open in Vs code: `code .`
* Navigate to the Factory directory using the terminal: `cd AnimalShelterApi`
* To install dependencies, run: `dotnet restore`


## Updating appsettings.json

* In order for the Entity Framework to automatically create the database, you'll need to have your `appsettings.json` set up properly 
* Create an `appsettings.json` file within the `AnimalShelterApi` folder
* Copy and paste the following code into the file:

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal;uid=root;pwd={YOUR-PASSWORD-HERE};"
  }
}

```
* Make sure you remove the curly brackets after entering in your username and password
* Once your database connection is complete, return to the terminal and run `dotnet build` to compile the project

## Implementing Migrations

* Once `appsettings.json` has been created and filled out, assure you are still within the `AnimalShelterApi` folder and enter the command `dotnet tool install --global dotnet-ef --version 3.0.0` to ensure Enitity Framework is installed on your system
* Type `dotnet ef database update` to assure any changes have been accounted for
* `dotnet build` will compile the project

## Navigating the API

* Now that `appsettings.json` is updated with your personal password and `migrations` have been implemented, launch the project by using the command `dotnet run`
* After launching the project you will have two methods for navigating the API: _Swagger_ and _browser endpoints_
### Swagger
* Open up your browser and copy this url into your search bar `http://localhost:5000/swagger/index.html`
* This will allow you to navigate through Swagger's custom interface built using the Animal Shelter API
* You can explore


## License :clipboard:
MIT &copy; 2021 _Dylan Allison-Damitz_
## Contact Information :mailbox:

_Dylan Allison-Damitz:
dylandamitz@gmail.com_
