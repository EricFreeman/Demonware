using System.Collections.Generic;

namespace Demonware.Models
{
    public class Product
    {
        public string Brand { get; set; }
        public string Id { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string Name { get; set; }
        public List<ProductImages> Images { get; set; }
        public string Price { get; set; }
        public List<QuantityOption> Quantities { get; set; } 
    }
}