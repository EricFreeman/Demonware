using Newtonsoft.Json;

namespace Demonware.Models
{
    public class Rebate
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "minQuantity")]
        public int MinQuantity { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }
    }
}