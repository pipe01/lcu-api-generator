using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryParticipantFrame
    {
        [JsonProperty("currentGold")]
        public int CurrentGold { get; set; }
        [JsonProperty("dominionScore")]
        public int DominionScore { get; set; }
        [JsonProperty("jungleMinionsKilled")]
        public int JungleMinionsKilled { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("minionsKilled")]
        public int MinionsKilled { get; set; }
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
        [JsonProperty("position")]
        public LolMatchHistoryMatchHistoryPosition Position { get; set; }
        [JsonProperty("teamScore")]
        public int TeamScore { get; set; }
        [JsonProperty("totalGold")]
        public int TotalGold { get; set; }
        [JsonProperty("xp")]
        public int Xp { get; set; }
    }
}