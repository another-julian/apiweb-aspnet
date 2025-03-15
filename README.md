# apiweb-aspnet

this is a simple apiweb made on aps net core, you can use to do a fetch in your frontend
this not use a data base, only cache memory.

## first need use https dev-certs to running the api

## ``dotnet dev-certs https --trust``

## Now you can run the server on https://localhost:7048

## `dotnet run`

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

#### if you want use httprepl to test

``dotnet tool install -g Microsoft.dotnet-httprepl``

#### if you want use APIWeb.http to test, you need install REST Client on VS code, you can also use Thunder Client or Post man

# CRUD methods on pizza - Create, Read, Update and Delete:

## For read all pizzas, you need use HTTP GET method on:

`https://localhost:7048/api/pizza`

## If you want to read a pizza by id, you can use HTTP GET method on:

`https://localhost:7048/api/pizza/{id}`

if you get a status 404 that means the id not exist.

## For create a pizza you need need use HTTP POST method on:

`https://localhost:7048/api/pizza/`

the body should contain a json whit the follow properties: 
``
{
      "name": "name of pizza",
      "content": "Ingredients that contain the pizza",
      "price": 12.3,
      "isGlutenFree": false,
}
``
name is a string
content is a string
price is a decimal value
isGlutenFree is a boolean

you can also check the model of pizza in the file Models/Pizza.cs