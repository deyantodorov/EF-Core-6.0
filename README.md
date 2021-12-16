# EF-Core-6.0
EF Core 6.0 samples

Useful extensions: 
EF Core Power Tools - https://marketplace.visualstudio.com/items?itemName=ErikEJ.EFCorePowerTools

Scaffold SqlServer (should be set as start up project)
```
Scaffold-DbContext -Provider Microsoft.EntityFrameworkCore.SqlServer -Connection "Server=127.0.0.1,1433; Database=FootballLeague; User Id=sa; Password=P@ssword123;"
```

Scaffold PostgreSQL (should be set as start up project)

```
Scaffold-DbContext -Provider Npgsql.EntityFrameworkCore.PostgreSQL -Connection "Username=postgres;Password=secretpassword;Host=127.0.0.1;Port=5432;Database=FootballLeague;Pooling=true;"
```