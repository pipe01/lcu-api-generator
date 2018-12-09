using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class MultiLeagueEntryChangeEventDTO
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("mainChangeEventDTO")]
        public LeagueEntryChangeEventDTOV2 MainChangeEventDTO { get; set; }
        [JsonProperty("multiLeagueChangeEventJwt")]
        public string MultiLeagueChangeEventJwt { get; set; }
        [JsonProperty("participantId")]
        public string ParticipantId { get; set; }
        [JsonProperty("positionRanks")]
        public bool PositionRanks { get; set; }
        [JsonProperty("provisionalGameThreshold")]
        public int ProvisionalGameThreshold { get; set; }
        [JsonProperty("queueType")]
        public string QueueType { get; set; }
        [JsonProperty("relatedChangeEventDTOs")]
        public object RelatedChangeEventDTOs { get; set; }
        [JsonProperty("shardId")]
        public string ShardId { get; set; }
    }
}
