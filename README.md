# Ass03Solution

### 1. Clone or download source code and opem with Microsoft Visual Studio.

### 2. Install and download packages name below from NuGet:
  - Microsoft.EntityFrameworkCore.Design
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.Extensions.Configuration.
  - Microsoft.Extensions.Configuration.Json.
  
### 3. Edit connectionStrings store in "appsettings.json" file
      "MyStoreDb": "Server=(local);uid=#{username};pwd=#{password};database=MemberDB;TrustServerCertificate=True".
      
### 4. Run migration data
```sh
  dotnet ef migrations add "Initial"
```
```sh
  dotnet ef database update
```
