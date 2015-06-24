using Newtonsoft.Json;

namespace Demonware.Models
{
    public class Manufacturer
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}