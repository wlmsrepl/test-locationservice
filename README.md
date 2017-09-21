```sh
$ dotnet nuget locals -c all
$ dotnet nuget locals -c global-packages
$ dotnet nuget locals -c http-cache
$ dotnet nuget locals -c temp
```
```sh
$ dotnet restore
$ dotnet build
$ dotnet pack -c Release
```
```sh
$ nuget config -Set DefaultPushSource=<repository> -ConfigFile NuGet.config
$ nuget setapikey <apikey> -ConfigFile NuGet.config -Source <repository>
$ nuget sources Add -ConfigFile NuGet.config -Name <name> -Source <repository> -UserName <username> -Password <password>
```
```sh
$ dotnet add package <package> --version <version> -s <repository>
```
```sh
$ dotnet add package StatlerWaldorfCorp.LocationService --version <version>
$ dotnet nuget push bin\Release\StatlerWaldorfCorp.LocationService.<version>.nupkg
```
### Windows
**_Prepare database_** - Postgresql
```sh
$ psql -U postgres
postgres=# CREATE EXTENSION IF NOT EXISTS "uuid-ossp";
postgres=#
$ createuser -U postgres --pwprompt --encrypted --no-createrole --no-createdb integrator
$ createdb -U postgres --owner integrator --encoding UTF8 --lc-ctype C --lc-collate C --template template0 locationservice
```
```sh
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
```