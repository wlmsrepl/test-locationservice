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