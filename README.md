# Api rest full ASP.NET Core y .Net 8.0

This is a **simple web API** built with **ASP.NET Core 8**. You can use it to make **fetch requests** in your frontend.

> **Note:** This API does not use a database, only **cache memory**.

## 🔹 Set up HTTPS certificates to run the API

Run the following command to trust HTTPS certificates in your development environment:

```sh
dotnet dev-certs https --trust
```

## 🚀 Run the server

Execute the following command in the terminal:

```sh
dotnet run
```

### 📌 Expected output:
```sh
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
```

---

## 🔹 Test the API with **HTTP REPL**
If you want to use **HTTP REPL** to test the API, install the tool by running:

```sh
dotnet tool install -g Microsoft.dotnet-httprepl
```

## 🔹 Test the API with **APIWeb.http**
To test the API with **APIWeb.http**, install the **REST Client** extension in VS Code. You can also use **Thunder Client** or **Postman**.

##  Using **swagger**
On your browser, go to:
```sh
https://localhost:7048/swagger/index.html
```
---

# 🍕 Pizza CRUD - API Methods

## 📌 Get all pizzas (GET)
Make a **GET** request to:
```sh
https://localhost:7048/api/pizza
```

## 📌 Get a pizza by ID (GET)
Make a **GET** request with a specific ID:
```sh
https://localhost:7048/api/pizza/{id}
```
If the **ID does not exist**, you will receive a **404 error**.

## 📌 Create a pizza (POST)
Make a **POST** request to:
```sh
https://localhost:7048/api/pizza/
```

📌 **Request body (JSON)**:
```json
{
      "name": "Pizza name",
      "content": "Ingredients in the pizza",
      "price": 12.3,
      "isGlutenFree": false
}
```

- **`name`**: string → Pizza name.
- **`content`**: string → Ingredients.
- **`price`**: decimal → Price of the pizza.
- **`isGlutenFree`**: boolean → `true` if gluten-free, `false` otherwise.

📌 **Pizza Model:**
You can check the data model in the file `Models/Pizza.cs`.

