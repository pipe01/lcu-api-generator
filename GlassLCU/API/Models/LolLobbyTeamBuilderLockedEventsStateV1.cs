using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderLockedEventsStateV1
    {
        [JsonProperty("allowLockedEvents")]
        public bool AllowLockedEvents { get; set; }
        [JsonProperty("lockedEventIndex")]
        public int LockedEventIndex { get; set; }
    }
}