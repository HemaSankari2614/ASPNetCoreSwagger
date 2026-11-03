# ASP.NET Core Swagger

## 📌 About the Project

This repository contains my practice project for learning **Swagger integration with ASP.NET Core Web API**.

Swagger provides an interactive interface to document, explore, and test RESTful APIs without requiring a separate API testing tool.

## 🎯 Project Objectives

- Understand Swagger and OpenAPI
- Integrate Swagger into ASP.NET Core Web API
- Create and test RESTful API endpoints
- Perform CRUD operations
- Explore API requests and responses using Swagger UI

## 🛠️ Technologies Used

- C#
- ASP.NET Core Web API
- .NET
- Swagger / OpenAPI
- Visual Studio

## 📂 Project Structure

```text
ASPNetCoreSwagger
│
├── Controllers
│   └── StudentsController.cs
│
├── Models
│   └── Student.cs
│
├── Program.cs
└── README.md
```

## 📚 Concepts Covered

- Swagger Configuration
- Swagger UI
- OpenAPI Specification
- API Controllers
- Routing
- HTTP Methods
- CRUD Operations
- API Request and Response Handling
- Status Codes

## 🔄 API Endpoints

| HTTP Method | Endpoint | Description |
|---|---|---|
| GET | `/api/Students` | Get all students |
| GET | `/api/Students/{id}` | Get student by ID |
| POST | `/api/Students` | Add a new student |
| PUT | `/api/Students/{id}` | Update student details |
| DELETE | `/api/Students/{id}` | Delete a student |

## 🚀 How to Run

1. Clone or download the repository.
2. Open the project in Visual Studio.
3. Restore the required NuGet packages.
4. Build and run the application.
5. Open the Swagger UI in your browser.

```text
https://localhost:<port>/swagger
```

Replace `<port>` with your application's actual port number.

## 💡 What I Learned

- How to configure Swagger in ASP.NET Core Web API
- How to explore API endpoints using Swagger UI
- How to test GET, POST, PUT, and DELETE requests
- How to understand API responses and status codes

---

✨ **Learning ASP.NET Core Web API through practical Swagger implementation!**
