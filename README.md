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
## How to create data seeding
- Create folder Extensions
- Created class ModelBuilderExtensions
- https://www.learnentityframeworkcore.com/migrations/seeding
- Open PM console -> add-migration SeedData -> update-database
## Add identity table
- add entity AppUser, AppRole and config
- in eShopDbContext.cs inheritance IdentityDbContext
- add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
- create foreignkey user
- open PC console: add-migration AspNetCoreIdentityDatabase
- add data seeding for user
- open PC console: add-migration SeedIdentityUser
## How to configure and run
## How to contribute