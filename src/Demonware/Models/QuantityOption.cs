using Newtonsoft.Json;

namespace Demonware.Models
{
    public class QuantityOption
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "months")]
        public string Months { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

        [JsonProperty(PropertyName = "minimum")]
        public int Minimum { get; set; }

        [JsonProperty(PropertyName = "maximum")]
        public int Maximum { get; set; }

        [JsonProperty(PropertyName = "rebate")]
        public Rebate Rebate { get; set; }
    }
}