# AspNetCore-WebAPI-CRUD

A professional RESTful Web API project developed using **ASP.NET Core**, **C#**, and direct database connectivity to perform complete **CRUD (Create, Read, Update, Delete)** operations.

This project demonstrates how to build scalable backend APIs for managing data through HTTP endpoints with database integration.

---

## Overview

The application is designed to handle CRUD operations through REST API endpoints. It connects directly to the database, processes client requests, and returns structured responses in JSON format.

This project is ideal for learning backend development, API architecture, routing, controllers, HTTP methods, and database integration using ASP.NET Core.

---

## Features

- Create new records using POST API
- Fetch all records using GET API
- Fetch single record by ID
- Update records using PUT API
- Delete records using DELETE API
- Direct database connectivity
- JSON request and response handling
- RESTful API architecture
- Clean project structure

---

## Tech Stack

- ASP.NET Core Web API
- C#
- .NET Framework / .NET Core
- SQL Server / MySQL
- ADO.NET / SQL Connectivity
- Visual Studio
- Postman

---

## API Architecture

Client Request  
→ Controller  
→ Business Logic  
→ Database Connection  
→ SQL Query Execution  
→ JSON Response

---

## HTTP Methods Used

- GET
- POST
- PUT
- DELETE

---

## API Endpoints Example

```http
GET /api/products
GET /api/products/{id}
POST /api/products
PUT /api/products/{id}
DELETE /api/products/{id}


git clone https://github.com/hamzatech/AspNetCore-WebAPI-CRUD.git
cd AspNetCore-WebAPI-CRUD
