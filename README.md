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
**_POST REQUEST_** - Add location
```sh
#The timestamp parameter must be different in each POST request.
$ curl -H "Content-Type: application/json" -X POST -d '{"id": "55bf35ba-deb7-4708-abc2-a21054dbfa13", "latitude": 12.56, "longitude": 45.567, "altitude": 1200, "timestamp" : 1476029596, "memberId": "0edaf3d2-5f5f-4e13-ae27-a7fbea9fccfb" }' http://localhost:5000/locations/0edaf3d2-5f5f-4e13-ae27-a7fbea9fccfb

{
   "id":"55bf35ba-deb7-4708-abc2-a21054dbfa13",
   "latitude":12.56,
   "longitude":45.567,
   "altitude":1200.0,
   "timestamp":1476029596,
   "memberID":"0edaf3d2-5f5f-4e13-ae27-a7fbea9fccfb"
}
```
**_GET REQUEST_** - Get locations
```sh
$ curl http://localhost:5000/locations/0edaf3d2-5f5f-4e13-ae27-a7fbea9fccfb

[
   {
      "id":"55bf35ba-deb7-4708-abc2-a21054dbfa13",
      "latitude":12.56,
      "longitude":45.567,
      "altitude":1200.0,
      "timestamp":1476029596,
      "memberID":"0edaf3d2-5f5f-4e13-ae27-a7fbea9fccfb"
   },
   {
      "id":"55bf35ba-deb7-4708-abc2-a21054dbfa13",
      "latitude":12.56,
      "longitude":45.567,
      "altitude":1200.0,
      "timestamp":1476030596,
      "memberID":"0edaf3d2-5f5f-4e13-ae27-a7fbea9fccfb"
   },
   {
      "id":"55bf35ba-deb7-4708-abc2-a21054dbfa13",
      "latitude":12.56,
      "longitude":45.567,
      "altitude":1200.0,
      "timestamp":1476031596,
      "memberID":"0edaf3d2-5f5f-4e13-ae27-a7fbea9fccfb"
   }
]
```
**_GET REQUEST_** - Get latest location
```sh
$ curl http://localhost:5000/locations/0edaf3d2-5f5f-4e13-ae27-a7fbea9fccfb/latest

{
   "id":"55bf35ba-deb7-4708-abc2-a21054dbfa13",
   "latitude":12.56,
   "longitude":45.567,
   "altitude":1200.0,
   "timestamp":1476031596,
   "memberID":"0edaf3d2-5f5f-4e13-ae27-a7fbea9fccfb"
}
```