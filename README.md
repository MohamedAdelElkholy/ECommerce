# 🛒 ECommerce Clean Architecture API

Production-ready E-Commerce Web API built with ASP.NET Core using Clean Architecture principles.

---

## 🏗 Architecture

This project follows Clean Architecture to ensure scalability, maintainability, and separation of concerns.

### Layers
- ECommerce.API → Controllers & Presentation layer  
- ECommerce.Application → Business logic & Services  
- ECommerce.Domain → Entities & Core models  
- ECommerce.Infrastructure → EF Core, Repositories, Database access  

---

## 🛠 Technologies

- .NET 8  
- ASP.NET Core Web API  
- Entity Framework Core  
- SQL Server  
- Repository Pattern  
- Service Layer Pattern  
- Dependency Injection  
- Swagger (OpenAPI)  
- Code First Migrations  

---

## 🚀 Implemented Features

### 🛍 Product Module
- Create Product  
- Get All Products  
- Get Product By Id  
- Update Product  
- Delete Product  

---

### 👤 User Module
- Custom User Entity  
- Create User  
- Get All Users  
- Get User By Id  
- Update User  
- Delete User  
- Activate / Deactivate User  

---

### 🔐 Authentication (JWT)

This project uses JSON Web Token (JWT) for secure authentication.

#### ✔️ Features:
- User login with email & password  
- Password hashing (secure storage)  
- JWT token generation  
- Token contains user claims (Id, Email, Role)  

---

#### 🔸 Login Endpoint

**POST** `/api/User/login`

##### Request:
```json
{
  "email": "user@example.com",
  "password": "123"
}
