dotnet restore
dotnet build

----------------------------------------------------------------------------------------------------------------------
windows
----------------------------------------------------------------------------------------------------------------------
psql -U postgres
postgres=# CREATE EXTENSION IF NOT EXISTS "uuid-ossp";
postgres=# \q
createuser -U postgres --pwprompt --encrypted --no-createrole --no-createdb integrator
createdb -U postgres --owner integrator --encoding UTF8 --lc-ctype C --lc-collate C --template template0 locationservice
----------------------------------------------------------------------------------------------------------------------

dotnet ef migrations add InitialCreate
dotnet ef database update

----------------------------------------------------------------------------------------------------------------------

dotnet nuget push [<ROOT>] [-s|--source] [-ss|--symbol-source] [-t|--timeout] [-k|--api-key] [-sk|--symbol-api-key] [-d|--disable-buffering] [-n|--no-symbols] [--force-english-output] [-h|--help]

dotnet nuget locals -c all
dotnet nuget locals -c global-packages
dotnet nuget locals -c http-cache
dotnet nuget locals -c temp

dotnet restore
dotnet build
dotnet pack -c [Debug|Release] [--include-source] [--include-symbols]

nuget config -Set DefaultPushSource=<repository> -ConfigFile NuGet.config
nuget setapikey <apikey> -ConfigFile NuGet.config -Source <repository>
nuget sources Add -ConfigFile NuGet.config -Name <name> -Source <repository> -UserName <username> -Password <password>

dotnet add package <package> --version <version> -s <repository>

dotnet add package StatlerWaldorfCorp.LocationService --version <version>
dotnet nuget push [--symbols-source <SOURCE>] bin\Release\StatlerWaldorfCorp.LocationService.<version>.nupkg

