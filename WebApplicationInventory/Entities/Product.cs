﻿using System.Threading.Tasks.Dataflow;

namespace WebApplicationInventory.Entity
{
    public class Product
    {
        public Product()
        {
               
        }
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int? BatchNumber { get; set; }

       
    }
}
