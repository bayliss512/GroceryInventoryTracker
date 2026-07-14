using GroceryInventoryTracker.Data;
using GroceryInventoryTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryInventoryTracker.Services
{
    public class SupplierService
    {
        private readonly InventoryDbContext _db;
        private readonly ILogger<SupplierService> _logger;

        public SupplierService(InventoryDbContext db, ILogger<SupplierService> logger)
        {
            _db = db;
            _logger = logger;
        }

        public async Task<List<Supplier>> GetAllAsync()
        {
            return await _db.Suppliers
                .AsNoTracking()
                .OrderBy(s => s.Name)
                .ToListAsync();
        }

        public async Task<Supplier?> GetByIdAsync(int id)
        {
            return await _db.Suppliers
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Supplier> CreateAsync(Supplier supplier)
        {
            _db.Suppliers.Add(supplier);
            await _db.SaveChangesAsync();

            _logger.LogInformation("Created supplier '{Name}'.", supplier.Name);
            return supplier;
        }

        /// <summary>
        /// Updates a supplier's editable fields. Returns false if the supplier does not exist.
        /// </summary>
        public async Task<bool> UpdateAsync(int id, Supplier updated)
        {
            var supplier = await _db.Suppliers.FirstOrDefaultAsync(s => s.Id == id);
            if (supplier == null)
            {
                return false;
            }

            supplier.Name = updated.Name;
            supplier.ContactName = updated.ContactName;
            supplier.Phone = updated.Phone;
            supplier.Email = updated.Email;
            supplier.Address = updated.Address;

            await _db.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Deletes a supplier. Returns false if the supplier does not exist, or a friendly
        /// error message if it can't be deleted because shipments still reference it.
        /// </summary>
        public async Task<(bool Success, string? Error)> DeleteAsync(int id)
        {
            var supplier = await _db.Suppliers.FirstOrDefaultAsync(s => s.Id == id);
            if (supplier == null)
            {
                return (false, "Supplier not found.");
            }

            var shipmentCount = await _db.Shipments.CountAsync(s => s.SupplierId == id);
            if (shipmentCount > 0)
            {
                return (false, $"Cannot delete '{supplier.Name}' — it is referenced by {shipmentCount} shipment(s). Reassign or remove those shipments first.");
            }

            _db.Suppliers.Remove(supplier);
            await _db.SaveChangesAsync();

            _logger.LogInformation("Deleted supplier '{Name}'.", supplier.Name);
            return (true, null);
        }
    }
}
