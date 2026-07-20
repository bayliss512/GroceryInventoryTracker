using GroceryInventoryTracker.Data;
using GroceryInventoryTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryInventoryTracker.Services
{
    public class ShipmentService
    {
        private readonly InventoryDbContext _db;
        private readonly ILogger<ShipmentService> _logger;

        public ShipmentService(InventoryDbContext db, ILogger<ShipmentService> logger)
        {
            _db = db;
            _logger = logger;
        }

        public async Task<List<Shipment>> GetAllAsync(int? productId = null)
        {
            var query = _db.Shipments
                .Include(s => s.Product)
                .Include(s => s.Supplier)
                .AsNoTracking()
                .AsQueryable();

            if (productId.HasValue)
            {
                query = query.Where(s => s.ProductId == productId.Value);
            }

            return await query
                .OrderBy(s => s.ExpirationDate)
                .ToListAsync();
        }

        public async Task<Shipment?> GetByIdAsync(int id)
        {
            return await _db.Shipments
                .Include(s => s.Product)
                .Include(s => s.Supplier)
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Shipment?> GetByShipmentNumberAsync(string shipmentNumber)
        {
            return await _db.Shipments
                .Include(s => s.Product)
                .Include(s => s.Supplier)
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.ShipmentNumber == shipmentNumber);
        }

        public async Task<Shipment> CreateAsync(Shipment shipment)
        {
            shipment.CreatedAt = DateTime.UtcNow;
            _db.Shipments.Add(shipment);
            await _db.SaveChangesAsync();

            _logger.LogInformation("Created shipment '{ShipmentNumber}' for product {ProductId}.", shipment.ShipmentNumber, shipment.ProductId);
            return shipment;
        }

        /// <summary>
        /// Updates a shipment's editable fields. Returns false if the shipment does not exist.
        /// </summary>
        public async Task<bool> UpdateAsync(int id, Shipment updated)
        {
            var shipment = await _db.Shipments.FirstOrDefaultAsync(s => s.Id == id);
            if (shipment == null)
            {
                return false;
            }

            shipment.ProductId = updated.ProductId;
            shipment.SupplierId = updated.SupplierId;
            shipment.ShipmentNumber = updated.ShipmentNumber;
            shipment.ExpirationDate = updated.ExpirationDate;
            shipment.Quantity = updated.Quantity;
            shipment.Location = updated.Location;

            await _db.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Quick-action update of just a shipment's location (In Storage / On Floor).
        /// Returns false if the shipment does not exist.
        /// </summary>
        public async Task<bool> SetLocationAsync(int id, string location)
        {
            var shipment = await _db.Shipments.FirstOrDefaultAsync(s => s.Id == id);
            if (shipment == null)
            {
                return false;
            }

            shipment.Location = location;
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var shipment = await _db.Shipments.FirstOrDefaultAsync(s => s.Id == id);
            if (shipment == null)
            {
                return false;
            }

            _db.Shipments.Remove(shipment);
            await _db.SaveChangesAsync();

            _logger.LogInformation("Deleted shipment '{ShipmentNumber}'.", shipment.ShipmentNumber);
            return true;
        }
    }
}
