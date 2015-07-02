using System.Collections.Generic;

namespace Demonware.Models
{
    public class Product
    {
        public string brand { get; set; }
        public string id { get; set; }
        public Manufacturer manufacturer { get; set; }
        public string name { get; set; }
        public List<ProductImages> images { get; set; }
        public string price { get; set; }
        public List<QuantityOption> quantites { get; set; }
        public dynamic dimensions { get; set; } 
    }
}