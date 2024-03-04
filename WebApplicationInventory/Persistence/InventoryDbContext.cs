using WebApplicationInventory.Entity;

namespace WebApplicationInventory.Persistence
{
    public class InventoryDbContext
    {
        public List<Product> Products { get; set; }
    }
}
