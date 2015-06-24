using System.Collections.Generic;
using Newtonsoft.Json;

namespace Demonware.Models
{
    public class InitialState
    {
        [JsonProperty(PropertyName = "mostPopularProducts")]
        public List<Product> MostPopularProducts { get; set; }

        [JsonProperty(PropertyName = "brands")]
        public List<BrandProducts> Brands { get; set; }
    }
}