# _Cat's Not Only Cats Animal Shelter API_

#### _An API that provides data on animals up for adoption at an animal shelter_

#### By _**Cat Denton**_

## Technologies Used

* C#
* .NET V5
* ASPNET CORE MVC
* Razor
* Entity Framework Core
* Identity
* Sql
* Swagger

## Description

#### _This API provides data about pets that are held at an animal shelter. The pets have the following properties: name, species, gender, date of birth, and a URL where a picture is stored in a cloud service such as imgur. The endpoint functionality written for the API may be seen on the Swagger page that launches when you run the API program. The following endpoints are available:_

* Get http://localhost:5000/api/animals -this returns a json object with the entire list of animals. The user may also search the animals by appending this endpoint with ?species= or ?gender=
* GetAnimal http://localhost:5000/api/animals/{id} -this returns a json object representing a single animal
* Post http://localhost:5000/api/animals -this uses the provided json object to add a new animal entity to the server
* Put http://localhost:5000/api/animals/{id} -this uses a provided json object to replace the data of a currently existing animal entity on the server
* Delete http://localhost:5000/api/animals/{id} -this removes the animal entity with the provided id from the server

The Swagger documentation can be used to test these endpoints and receive example Json bodies as well as the endpoing URLs to access the API data. Use the "Get" or "GetAnimal" endpoints on swagger to generate Json bodies, which can then be modified to test out the Put and Post endpoints.

__


## Setup/Installation Requirements

* Install microsoft .NET V5
* Install MySQL
* Clone repository to local drive
* Open code with a text editor
* Open terminal
* Change directory to AnimalShelterApi.Solution/AnimalShelterApi
* Type "touch appsettings.json"
* Enter the following code into appsettings.json, change the password to your MySql server password and save
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
    "DefaultConnection": "Server=localhost;Port=3306;database=cat_denton;uid=root;pwd=[YOUR-PASSWORD-HERE-WITHOUT-BRACKETS];"
  }
}
```
* Type "dotnet build" in terminal and hit enter
* Type "dotnet ef database update"
* Type "dotnet watch run" in the terminal and hit enter
* The swagger page that provides endpoint documentation should launch in your browser at http://localhost:5000/swagger/index.html

## Known Bugs

* None

## License

Copyright 2021 Cat Denton

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.



## Contact Information

_Cat Denton <cat.denton.dev@gmail.com>_
