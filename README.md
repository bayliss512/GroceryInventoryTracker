# Grocery Inventory Tracker

A simple yet effective inventory management system designed for grocery store employees to track product quantities, manage shipments, and organize inventory by category.

## Overview

Grocery Inventory Tracker is an ASP.NET Core Razor Pages application built with Entity Framework Core and SQL Server LocalDB. It provides employees with an intuitive interface to:
- View and search products across multiple categories
- Track quantity stored and quantity on shelves
- Monitor shipment information and expiration dates
- Browse product inventory with images and responsive design

## Implementation Status – Objectives 1 & 2

### Phase 0 – Project Setup

| Requirement | Status |
|---|---|
| Verify existing project builds and runs | ✅ |
| Application starts without errors | ✅ |
| Developer can access website locally | ✅ |
| Establish clean folder structure (Models, Data, Services, Views, etc.) | ✅ |

### Phase 1 – Front-End Layout

| Requirement | Status |
|---|---|
| Design responsive inventory page with header and title | ✅ |
| Display "Grocery Inventory Tracker" title and "Employee Inventory Dashboard" subtitle | ✅ |
| Implement search area with search box and button | ✅ |
| Create product table with Product, Quantity Stored, Quantity On Shelves columns | ✅ |
| Implement product details modal for shipment information | ✅ |
| Display shipment number, expiration date, and quantity in modal | ✅ |
| Use plain CSS for styling | ✅ |
| Implement clean, modern, employee-focused design | ✅ |
| Add hover states and alternating table row colors | ✅ |
| Style buttons and implement modal animations | ✅ |
| Create mobile-friendly, responsive layout | ✅ |
| Implement modal open/close behavior with keyboard support (Escape key) | ✅ |
| Support clicking outside modal to close | ✅ |
| Implement client-side modal interaction without backend calls | ✅ |

### Phase 2 – Database Foundation

| Requirement | Status |
|---|---|
| Install Entity Framework Core SQL Server | ✅ |
| Install Entity Framework Core Tools | ✅ |
| Create Product model with Id, Name, QuantityStored, QuantityOnShelves properties | ✅ |
| Create Shipment model with Id, ProductId, ShipmentNumber, ExpirationDate, Quantity | ✅ |
| Implement Product-to-Shipment relationship (1 Product : Many Shipments) | ✅ |
| Create InventoryDbContext with DbSet<Product> and DbSet<Shipment> | ✅ |
| Configure SQL Server LocalDB connection | ✅ |
| Generate initial migration | ✅ |
| Update database with migration | ✅ |

### Phase 3 – Seed Initial Inventory

| Requirement | Status |
|---|---|
| Seed eight products: Apples, Bananas, Milk, Bread, Eggs, Rice, Chicken Breast, Pasta | ✅ |
| Assign reasonable QuantityStored and QuantityOnShelves values to products | ✅ |
| Seed 2-4 shipments per product with shipment numbers and expiration dates | ✅ |
| Ensure shipment quantities align with product quantities | ✅ |

### Phase 4 – Connect Website to Database

| Requirement | Status |
|---|---|
| Create ProductService with GetAllProducts() method | ✅ |
| Create ProductService with GetProductById() method | ✅ |
| Create ProductService with GetShipmentsForProduct() method | ✅ |
| Use asynchronous EF Core operations | ✅ |
| Display live product data from SQL database | ✅ |
| Display Product Name, Quantity Stored, Quantity On Shelves from database | ✅ |
| Retrieve and display shipment records in modal dynamically | ✅ |
| Support database value modifications with page refresh | ✅ |

### Phase 5 – Single User Testing

| Requirement | Status |
|---|---|
| Test inventory list displays all eight products | ✅ |
| Verify product values match database | ✅ |
| Test clicking products opens correct shipment details | ✅ |
| Verify modal close button works | ✅ |
| Verify Escape key closes modal | ✅ |
| Verify clicking outside modal closes it | ✅ |
| Test responsive design on desktop browser | ✅ |
| Test responsive design at narrow browser width | ✅ |
| Fix broken layouts and styling inconsistencies | ✅ |
| Verify no JavaScript errors | ✅ |

### Phase 6 – Categorization

| Requirement | Status |
|---|---|
| Create Category model with Id and Name properties | ✅ |
| Create category examples: Produce, Dairy, Bakery, Meat, Dry Goods | ✅ |
| Update Product model with CategoryId and Category navigation property | ✅ |
| Generate and apply migration for Category model | ✅ |
| Seed category data | ✅ |
| Assign all eight products to categories | ✅ |
| Display products organized by category on inventory page | ✅ |

### Phase 7 – Search Functionality

| Requirement | Status |
|---|---|
| Implement search by product name (case insensitive) | ✅ |
| Implement search by category name (case insensitive) | ✅ |
| Filter results immediately using JavaScript or server-side logic | ✅ |
| No page reload required during search | ✅ |
| Preserve shipment functionality for filtered products | ✅ |
| Support clearing search results | ✅ |

### Phase 8 – Visual Enhancement (Objective 2)

| Requirement | Status |
|---|---|
| Add ImagePath property to Product model | ✅ |
| Store product images in wwwroot/Images/ProductImages | ✅ |
| Seed image paths for all products | ✅ |
| Redesign inventory layout with card-based presentation | ✅ |
| Display product image on each card | ✅ |
| Display product name, category, quantity stored, quantity on shelves on cards | ✅ |
| Keep cards clickable to open shipment details | ✅ |
| Display 4 cards per row on large screens | ✅ |
| Display 2 cards per row on medium screens | ✅ |
| Display 1 card per row on small screens | ✅ |
| Improve shipment modal with product image | ✅ |
| Display product name in modal | ✅ |
| Highlight expired shipments | ✅ |
| Highlight shipments expiring within 7 days | ✅ |
| Improve typography hierarchy | ✅ |
| Add shadows for visual depth | ✅ |
| Implement hover effects | ✅ |
| Add focus states for accessibility | ✅ |
| Implement loading indicators | ✅ |
| Add empty search results messaging | ✅ |

---

## Deferred Features – Objective 3+

The following features are intentionally deferred to Objective 3 and beyond:

- ❌ User authentication/login
- ❌ Employee roles and permissions
- ❌ Concurrent editing protections
- ❌ Audit logs
- ❌ Inventory transactions
- ❌ Real-time updates via SignalR
- ❌ Optimistic concurrency control
- ❌ Load testing and performance optimization
- ❌ Deployment configuration
- ❌ Distributed caching
- ❌ Multi-user conflict resolution

---

## Tech Stack

- **Framework:** ASP.NET Core 10.0 with Razor Pages
- **Database:** Entity Framework Core with SQL Server LocalDB
- **Frontend:** HTML, CSS, Bootstrap, JavaScript
- **Language:** C#

## Getting Started

### Prerequisites
- .NET 10 SDK
- SQL Server LocalDB
- Visual Studio Community 2026 or later (recommended)

### Setup Instructions

1. **Clone the repository**
   ```bash
   git clone https://github.com/bayliss512/GroceryInventoryTracker.git
   cd GroceryInventoryTracker
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Apply database migrations**
   ```bash
   dotnet ef database update
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Access the application**
   - Navigate to `https://localhost:7001` (or the port shown in your console)
   - Explore the inventory dashboard

### Configuration

The application uses SQL Server LocalDB by default. Connection string is configured in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=GroceryInventoryTrackerDb;Trusted_Connection=true;"
}
```

## Project Structure

```
GroceryInventoryTracker/
├── Models/              # Data models (Product, Shipment, Category)
├── Data/                # DbContext and database configuration
├── Services/            # Business logic and data services
├── Pages/               # Razor Pages and page models
├── wwwroot/            # Static files (CSS, JavaScript, images)
│   ├── css/            # Stylesheets
│   ├── js/             # Client-side scripts
│   └── Images/         # Product images
├── Migrations/         # Entity Framework migrations
└── Properties/         # Application configuration
```

## Features

### Inventory Dashboard
- View all products organized by category
- Search products by name or category
- Responsive grid layout (1-4 cards per row based on screen size)
- Product images and quantity information

### Shipment Tracking
- Click any product to view detailed shipment information
- See shipment numbers, expiration dates, and quantities
- Visual indicators for expired and soon-to-expire shipments
- Modal dialog for shipment details

### Search & Filtering
- Real-time search by product name
- Search by category
- Instant results without page reload
- Empty state messaging

### Responsive Design
- Mobile-friendly layout
- Tablet-optimized interface
- Desktop presentation with full feature set
- Touch-friendly click targets

## Future Enhancements (Objective 3)

The roadmap for future versions includes:
- Employee authentication and login system
- Role-based access control
- Inventory transaction history
- Real-time synchronization
- Multi-user conflict resolution
- Performance optimizations and caching

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## Contact

For questions or feedback, please open an issue on the GitHub repository.

---

**Last Updated:** 2026
**Status:** ✅ Objectives 1–2 Complete | Objective 3+ Pending
