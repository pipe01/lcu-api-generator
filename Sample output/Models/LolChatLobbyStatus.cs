using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatLobbyStatus
    {
        [JsonProperty("customSpectatorPolicy")]
        public LolChatQueueCustomGameSpectatorPolicy CustomSpectatorPolicy { get; set; }
        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }
        [JsonProperty("isLeader")]
        public bool IsLeader { get; set; }
        [JsonProperty("isPracticeTool")]
        public bool IsPracticeTool { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}
