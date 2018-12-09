using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyOpenPartyToggleAnalytics
    {
        [JsonProperty("elapsedTime")]
        public long ElapsedTime { get; set; }
        [JsonProperty("endTimestamp")]
        public long EndTimestamp { get; set; }
        [JsonProperty("endTransition")]
        public string EndTransition { get; set; }
        [JsonProperty("eventData")]
        public object EventData { get; set; }
        [JsonProperty("eventTimestamp")]
        public long EventTimestamp { get; set; }
        [JsonProperty("eventType")]
        public string EventType { get; set; }
        [JsonProperty("finalState")]
        public string FinalState { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("initialState")]
        public string InitialState { get; set; }
        [JsonProperty("numOfToggles")]
        public int NumOfToggles { get; set; }
        [JsonProperty("partyId")]
        public string PartyId { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }
        [JsonProperty("startTimestamp")]
        public long StartTimestamp { get; set; }
        [JsonProperty("startTransition")]
        public string StartTransition { get; set; }
    }
}
