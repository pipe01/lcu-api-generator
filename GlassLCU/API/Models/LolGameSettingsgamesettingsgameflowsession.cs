using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameSettingsgamesettingsgameflowsession
    {
        [JsonProperty("gameClient")]
        public LolGameSettingsgamesettingsgameclient GameClient { get; set; }
    }
}
