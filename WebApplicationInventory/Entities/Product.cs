using System.Threading.Tasks.Dataflow;

namespace WebApplicationInventory.Entity
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Batch? Batch { get; set; }

        public void Update( int quantity)
        {
            Quantity = quantity;    
        }
    }
}
