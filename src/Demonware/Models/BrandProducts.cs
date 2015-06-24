using System.Collections.Generic;
using Newtonsoft.Json;

namespace Demonware.Models
{
    public class BrandProducts
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "products")]
        public List<Product> Products { get; set; }
    }
}