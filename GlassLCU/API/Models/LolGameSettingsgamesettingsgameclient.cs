using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameSettingsgamesettingsgameclient
    {
        [JsonProperty("running")]
        public bool Running { get; set; }
    }
}
