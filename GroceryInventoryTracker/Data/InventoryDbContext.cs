using System;
using GroceryInventoryTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryInventoryTracker.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Shipment> Shipments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(b =>
            {
                b.HasKey(p => p.Id);
                b.Property(p => p.Name).IsRequired();
            });

            modelBuilder.Entity<Shipment>(b =>
            {
                b.HasKey(s => s.Id);
                b.Property(s => s.ShipmentNumber).IsRequired();
                b.HasOne(s => s.Product)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(s => s.ProductId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // Seed products
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Apples", QuantityStored = 150, QuantityOnShelves = 45 },
                new Product { Id = 2, Name = "Bananas", QuantityStored = 120, QuantityOnShelves = 60 },
                new Product { Id = 3, Name = "Milk", QuantityStored = 80, QuantityOnShelves = 20 },
                new Product { Id = 4, Name = "Bread", QuantityStored = 50, QuantityOnShelves = 25 },
                new Product { Id = 5, Name = "Eggs", QuantityStored = 200, QuantityOnShelves = 40 },
                new Product { Id = 6, Name = "Rice", QuantityStored = 100, QuantityOnShelves = 30 },
                new Product { Id = 7, Name = "Chicken Breast", QuantityStored = 75, QuantityOnShelves = 15 },
                new Product { Id = 8, Name = "Pasta", QuantityStored = 90, QuantityOnShelves = 35 }
            );

            // Seed shipments (2-4 per product)
            modelBuilder.Entity<Shipment>().HasData(
                new Shipment { Id = 1, ProductId = 1, ShipmentNumber = "1001", ExpirationDate = new DateTime(2026, 8, 12), Quantity = 25 },
                new Shipment { Id = 2, ProductId = 1, ShipmentNumber = "1002", ExpirationDate = new DateTime(2026, 8, 20), Quantity = 60 },
                new Shipment { Id = 3, ProductId = 2, ShipmentNumber = "2001", ExpirationDate = new DateTime(2026, 8, 18), Quantity = 50 },
                new Shipment { Id = 4, ProductId = 2, ShipmentNumber = "2002", ExpirationDate = new DateTime(2026, 8, 25), Quantity = 70 },
                new Shipment { Id = 5, ProductId = 3, ShipmentNumber = "3001", ExpirationDate = new DateTime(2026, 7, 30), Quantity = 40 },
                new Shipment { Id = 6, ProductId = 3, ShipmentNumber = "3002", ExpirationDate = new DateTime(2026, 8, 15), Quantity = 40 },
                new Shipment { Id = 7, ProductId = 4, ShipmentNumber = "4001", ExpirationDate = new DateTime(2026, 8, 5), Quantity = 20 },
                new Shipment { Id = 8, ProductId = 4, ShipmentNumber = "4002", ExpirationDate = new DateTime(2026, 8, 18), Quantity = 30 },
                new Shipment { Id = 9, ProductId = 5, ShipmentNumber = "5001", ExpirationDate = new DateTime(2026, 9, 1), Quantity = 100 },
                new Shipment { Id = 10, ProductId = 5, ShipmentNumber = "5002", ExpirationDate = new DateTime(2026, 9, 10), Quantity = 100 },
                new Shipment { Id = 11, ProductId = 6, ShipmentNumber = "6001", ExpirationDate = new DateTime(2027, 1, 1), Quantity = 50 },
                new Shipment { Id = 12, ProductId = 6, ShipmentNumber = "6002", ExpirationDate = new DateTime(2027, 3, 1), Quantity = 50 },
                new Shipment { Id = 13, ProductId = 7, ShipmentNumber = "7001", ExpirationDate = new DateTime(2026, 8, 22), Quantity = 40 },
                new Shipment { Id = 14, ProductId = 7, ShipmentNumber = "7002", ExpirationDate = new DateTime(2026, 9, 2), Quantity = 35 },
                new Shipment { Id = 15, ProductId = 8, ShipmentNumber = "8001", ExpirationDate = new DateTime(2027, 2, 1), Quantity = 50 },
                new Shipment { Id = 16, ProductId = 8, ShipmentNumber = "8002", ExpirationDate = new DateTime(2027, 4, 1), Quantity = 40 }
            );
        }
    }
}
