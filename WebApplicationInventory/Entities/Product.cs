using System.Threading.Tasks.Dataflow;

namespace WebApplicationInventory.Entity
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Batch? Batch { get; set; }
    }
}
