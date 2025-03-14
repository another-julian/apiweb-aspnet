# apiweb-aspnet

this is a simple apiweb made on aps net core, you can use to do a fetch in your frontend
this not use a data base, only cache memory.

## first need use https dev-certs to running the api

``dotnet dev-certs https --trust``

## Now you can run the server on https://localhost:7048

`dotnet run`

output: 

info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:7048
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5161
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: A:\Desarrollo github\ASP net\APIWeb

if you want use httprepl to test

``dotnet tool install -g Microsoft.dotnet-httprepl``