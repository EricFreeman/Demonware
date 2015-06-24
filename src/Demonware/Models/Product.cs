using System.Collections.Generic;
using Newtonsoft.Json;

namespace Demonware.Models
{
    public class Product
    {
        [JsonProperty(PropertyName = "brand")]
        public string Brand { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "manufacturer")]
        public Manufacturer Manufacturer { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "images")]
        public List<ProductImages> Images { get; set; }

        [JsonProperty(PropertyName = "price")]
        public string Price { get; set; }

        [JsonProperty(PropertyName = "quantites")]
        public List<QuantityOption> Quantities { get; set; }

        [JsonProperty(PropertyName = "dimensions")]
        public dynamic Dimensions { get; set; } 
    }
}