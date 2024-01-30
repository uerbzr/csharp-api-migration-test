## Configure Json

Create a new appsettings.json / appsettings.Development.json (see appsettings.Example.json) add the following json and update credentials
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnectionString": "Host=HOST Database=DATABASE; Username=USERNAME; Password=PASSWORD; "
  }
}
```

## Install Nugets

Install the following packages:
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package NpgSql.EntityFrameworkCore.PostgreSql

## Migrations
Add-Migration FirstMigration
Update-Database


## Testing
Done with a standard NUnit Test project (dotnet new nunit --name workshop.tests) with the additional package:

Install-Package Microsoft.Aspnecore.Mvc.Testing
