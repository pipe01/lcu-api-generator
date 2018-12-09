using Newtonsoft.Json;

namespace LCU_API_Generator
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
