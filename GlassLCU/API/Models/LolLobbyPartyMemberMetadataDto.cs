using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyPartyMemberMetadataDto
    {
        [JsonProperty("positionPref")]
        public string[] PositionPref { get; set; }
    }
}
