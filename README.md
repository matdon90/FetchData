[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<!-- PROJECT LOGO -->
<br />
<p align="center">
  <h3 align="center">FETCH DATA</h3>

  <p align="center">
    Fetch Data is a web service for fetching data from Oracle and PostgreSQL database with use of EFCore.
    <br />
    <br />
    <a href="https://github.com/matdon90/FetchData/issues">Report Bug</a>
    ·
    <a href="https://github.com/matdon90/FetchData/issues">Request Feature</a>
  </p>
</p>

<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
* [Used Technologies](#used-technologies)
* [Getting Started](#getting-started)
* [Contributing](#contributing)
* [Contact](#contact)


<!-- ABOUT THE PROJECT -->
## About The Project

FetchData is a small ASP.NET Core service for fetching data from Oracle 11g and PostgreSQL databases.
In project there is implemented connection to database with use of EF Core. Clean Architecture with CQRS + MediatR is used as architecture of the project.


<!-- USED TECHNOLOGIES -->
### Used Technologies

* [ASP.NET Core 3.1](https://docs.microsoft.com/pl-pl/aspnet/core/?view=aspnetcore-3.1)
* [PostgreSQL](https://www.postgresql.org/)
* [Oracle](https://www.oracle.com/pl/index.html)
* [Entity Framework Core](https://docs.microsoft.com/en-US/ef/core/)
* [MediatR](https://github.com/jbogard/MediatR)
* [FluentValidation](https://fluentvalidation.net/)
* [Swashbuckle](https://docs.microsoft.com/en-US/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-5.0&tabs=visual-studio)

<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple steps:

* Download the latest stable version from the download tab and unzip it to your folder
* Open the solution in Visual Studio 2019. 
* Build the solution to install Nuget packages.
* Change in web project in `appsettings.json` the data needed for database connection:

```json
  "ConnectionStrings": {
    "PostgresConnectionString": "yourPostgresConnectionString",
    "OracleConnectionString": "yourOracleConnectionString"
  }
```

* To have it working with your model you need to create appropriate model, view model, controller and service basing on my models.
* Run application
* To access SwaggerUI fire up your browser and open url `https://localhost:5001`
* To use other programs i.e. POSTMAN use url `https://localhost:5001/api/[PrefixOfYourController]`. In my case for list of all items use `https://localhost:44351/api/cushions` and for details for example `https://localhost:44351/api/cushions/1/O`
* Enjoy ;-)


<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. 🍴 Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. 🔃 Open a Pull Request


<!-- CONTACT -->
## Contact

Mateusz Donhefner

Project Link: [https://github.com/matdon90/FetchData](https://github.com/matdon90/FetchData)

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/matdon90/OracleDataFetch.svg?style=flat-square
[contributors-url]: https://github.com/matdon90/FetchData/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/matdon90/OracleDataFetch.svg?style=flat-square
[forks-url]: https://github.com/matdon90/FetchData/network/members
[stars-shield]: https://img.shields.io/github/stars/matdon90/OracleDataFetch.svg?style=flat-square
[stars-url]: https://github.com/matdon90/FetchData/stargazers
[issues-shield]: https://img.shields.io/github/issues/matdon90/OracleDataFetch.svg?style=flat-square
[issues-url]: https://github.com/matdon90/FetchData/issues
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/mateusz-donhefner/
