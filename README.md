# Grocery Inventory Tracker

An ASP.NET Core Razor Pages application for grocery store employees to track product inventory, manage shipments, and organize stock by category. Built with Entity Framework Core against a SQL Server database.

## Overview

Employees can browse the product catalog by category, search for items, and drill into any product to see its shipments — quantities, expiration dates, and whether stock is in storage or out on the sales floor. Accounts are required to make changes, with a simple admin role for managing users and a configuration page for seeding/resetting the database during development.

## Features

- **Inventory dashboard** — Product catalog across 21 categories with images, organized in a responsive card grid.
- **Search** — Instant client-side filtering by product name or category, no page reload.
- **Shipment tracking** — Per-product shipment details (shipment number, expiration date, quantity, storage vs. sales-floor location), with visual highlighting for expired and soon-to-expire shipments.
- **Accounts** — Sign-up/login with hashed passwords, per-user identicon or uploaded profile picture, and a settings page for changing passwords and pictures.
- **Admin panel** — The first account created becomes an admin, who can view all users, grant/revoke admin access, and delete accounts (with safeguards against removing the last admin).
- **Configuration tools** — A dev-oriented page for initializing/resetting the database and generating sample shipments.

## Tech Stack

- **Framework:** ASP.NET Core (Razor Pages), .NET 10
- **Database:** Entity Framework Core with SQL Server
- **Frontend:** Razor views, Bootstrap, vanilla JavaScript
- **Language:** C#

## Getting Started

### Prerequisites
- .NET 10 SDK
- SQL Server (Express, LocalDB, or full instance)

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/bayliss512/GroceryInventoryTracker.git
   cd GroceryInventoryTracker
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Configure the connection string** in `GroceryInventoryTracker/appsettings.json` if your SQL Server instance differs from the default:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=GroceryInventoryTracker;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
   }
   ```

4. **Run the application**
   ```bash
   dotnet run --project GroceryInventoryTracker
   ```
   The app creates and seeds the database automatically on first run. You can also trigger this manually from the in-app Configuration page.

5. **Access the application** at the URL shown in the console (e.g. `https://localhost:7001`), sign up for an account, and explore the dashboard.

## Project Structure

```
GroceryInventoryTracker/
├── Models/              # Data models (Product, Shipment, Category, User)
├── Data/                # DbContext and database configuration
├── Services/            # Business logic and data services
├── Pages/               # Razor Pages and page models
├── wwwroot/             # Static files (CSS, JavaScript, images)
├── Migrations/          # Entity Framework migrations
└── Properties/          # Application configuration
```

## License

This project is licensed under the MIT License - see the LICENSE file for details.
