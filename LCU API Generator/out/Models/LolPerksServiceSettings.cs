using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksServiceSettings
    {
        [JsonProperty("serverSideStorageAvailable")]
        public bool ServerSideStorageAvailable { get; set; }
    }
}
