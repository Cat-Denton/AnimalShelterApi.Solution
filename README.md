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
* MySql Workbench

## Description

__


## Setup/Installation Requirements

* Install microsoft .NET V5
* Clone repository to local drive
* Open code with a text editor
* Open terminal
* Change directory to HairSalon.Solution/HairSalon
* Type "dotnet touch appsettings.json"
* Enter the following code into appsettings.json, change the password to your MySql server password and save
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=cat_denton;uid=root;pwd=[yourPwHere];"
  }
}
```
* Type "dotnet build" in terminal and hit enter
* Type "dotnet ef database update"
* Type "dotnet run" in the terminal and hit enter

## Known Bugs

* None

## License

Copyright 2021 Cat Denton

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.



## Contact Information

_Cat Denton <cat.denton.dev@gmail.com>_
