using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGameSettingsgamesettingsgameflowsession
    {
        [JsonProperty("gameClient")]
        public LolGameSettingsgamesettingsgameclient GameClient { get; set; }
    }
}
