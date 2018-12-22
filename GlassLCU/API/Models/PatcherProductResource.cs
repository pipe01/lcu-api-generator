using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PatcherProductResource
    {
        [JsonProperty("components")]
        public PatcherComponentResource[] Components { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("refresh_period")]
        public int Refresh_period { get; set; }
    }
}
