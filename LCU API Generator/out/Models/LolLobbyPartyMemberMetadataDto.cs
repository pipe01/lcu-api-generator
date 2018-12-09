using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyPartyMemberMetadataDto
    {
        [JsonProperty("positionPref")]
        public string[] PositionPref { get; set; }
    }
}
