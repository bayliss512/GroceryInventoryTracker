-- SQL Script to verify the GroceryInventoryTracker database initialization
-- Run this in SQL Server Management Studio to confirm all tables and seed data exist

-- Check if database exists
SELECT DB_NAME() AS [Current Database];

-- Check if tables exist
SELECT TABLE_NAME 
FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_SCHEMA = 'dbo' 
ORDER BY TABLE_NAME;

-- Show Categories
SELECT 'Categories' AS TableName, COUNT(*) AS RecordCount FROM Categories
UNION ALL
SELECT 'Products', COUNT(*) FROM Products
UNION ALL
SELECT 'Shipments', COUNT(*) FROM Shipments;

-- Show sample product data with inventory levels
SELECT 
	p.Id,
	p.Name,
	c.Name AS Category,
	p.QuantityStored AS [Warehouse/Storage],
	p.QuantityOnShelves AS [Store Shelves],
	(p.QuantityStored + p.QuantityOnShelves) AS [Total Available]
FROM Products p
LEFT JOIN Categories c ON p.CategoryId = c.Id
ORDER BY p.Id;

-- Show sample shipment data
SELECT 
	s.Id,
	s.ShipmentNumber,
	p.Name AS Product,
	s.Quantity,
	s.ExpirationDate,
	DATEDIFF(DAY, GETDATE(), s.ExpirationDate) AS [Days Until Expiration]
FROM Shipments s
JOIN Products p ON s.ProductId = p.Id
ORDER BY s.ExpirationDate;

-- Show migration history
SELECT * FROM __EFMigrationsHistory;
