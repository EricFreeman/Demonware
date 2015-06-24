using Newtonsoft.Json;

namespace Demonware.Models
{
    public class ProductImages
    {
        [JsonProperty(PropertyName = "smallUrl")]
        public string SmallUrl { get; set; }

        [JsonProperty(PropertyName = "mediumUrl")]
        public string MediumUrl { get; set; }

        [JsonProperty(PropertyName = "largeUrl")]
        public string LargeUrl { get; set; }
    }
}