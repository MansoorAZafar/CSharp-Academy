# Adding a .NET Library + Project
_______________________________

```bash
dotnet new sln

dotnet new console -o  [proj_name]
dotnet new classlib -o [library_name]

dotnet sln add [proj_name]/proj_name.csproj
dotnet sln add [library_name]/library_name.csproj

dotnet add [proj_name]/proj_name.csproj reference [library_name]/library_name.csproj
```



# Adding a .NET Web API + Project
________________________________
```bash
dotnet new sln
```

### Adding the Web-API
_____________________

```bash
dotnet new webapi --use-controllers -o [api_name]
cd [api_name]
dotnet add package Microsoft.EntityFrameworkCore.InMemory
```

If VsCode doesn't give a dialog box asking
	-> "Do you trust the authors ..."

Do this

1. -> CTRL + SHIFT + P 
2. -> Select .NET Generate Assests for Build and Debug 
3. -> The .launch.json and tasks.json has been added

-> By Default, 
  - the localhost:xxxx won't exist
    - but the /swagger will
		- To check if it works do
	  - https://localhost:[xxxx]/swagger


### Adding the UI
________________

```bash
cd ../
dotnet new console -o  [proj_name]
dotnet sln add [proj_name]/proj_name.csproj

//
cd ../
code -r ../[api_name]
```


# Dotnet Web API Info
________________________________
### Running the web API

```bash
dotnet run --launch-profile https
```

### Scaffold a Controller (VsCode)

```bash
	dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
	dotnet add package Microsoft.EntityFrameworkCore.Design
	dotnet add package Microsoft.EntityFrameworkCore.SqlServer
	dotnet add package Microsoft.EntityFrameworkCore.Tools
	dotnet tool uninstall -g dotnet-aspnet-codegenerator
	dotnet tool install -g dotnet-aspnet-codegenerator
	dotnet tool update -g dotnet-aspnet-codegenerator
```

### Scaffoled a Controller (Visual Studio)
	
Right click the <Controllers> folder

1. Select <ADD> <NEW Scaffold Item \>
2. Select <API Controller with actions, using Entity Framework> -> Add
3. Select the Item from the Models dir
4. Select the Context from the data-context-class
5. Select ADD

# Add Migrations
- Generation of code that describe changes to database schemas (CRUD)
  - Allow us to incrementally evolve our databases (without rebuilding from scratch)

```bash
dotnet ef migrations add <MigrationName>
dotnet ef database update
```

	// ex.
```bash
dotnet ef migrations add InitialMigration
dotnet ef databse update
```
