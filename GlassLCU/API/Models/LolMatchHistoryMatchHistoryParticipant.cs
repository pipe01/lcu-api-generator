using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryParticipant
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("highestAchievedSeasonTier")]
        public string HighestAchievedSeasonTier { get; set; }
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
        [JsonProperty("spell1Id")]
        public int Spell1Id { get; set; }
        [JsonProperty("spell2Id")]
        public int Spell2Id { get; set; }
        [JsonProperty("stats")]
        public LolMatchHistoryMatchHistoryParticipantStatistics Stats { get; set; }
        [JsonProperty("teamId")]
        public int TeamId { get; set; }
        [JsonProperty("timeline")]
        public LolMatchHistoryMatchHistoryTimeline Timeline { get; set; }
    }
}