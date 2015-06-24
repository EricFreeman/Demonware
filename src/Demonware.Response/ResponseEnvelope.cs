using Newtonsoft.Json;

namespace Demonware.Response
{
    public class ResponseEnvelope<T>
    {
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "completed")]
        public bool Completed{ get; set; }

        [JsonProperty(PropertyName = "result")]
        public T Result { get; set; }
    }
}