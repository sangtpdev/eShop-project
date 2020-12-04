# ASP.NET Core 3.1 project
## Technologies
- ASP.NET Core 3.1
- Entity Framework Core 3.1
## Install packages
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.Design
## How to migration database
- b1: create entities
- b2: create folder configurations and configuration for all in entity
- b3: create DbContextFactory 
  - install packages Microsoft.Extensions.Configuration.FileExtensions
  - install packages Microsoft.Extensions.Configuration.Json
- b4: open Mackage Manager Console
  - Add-Migration Initial
  - if success + "update-database" 
## How to configure and run
## How to contribute