using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRecommendationsMatchHistoryGame
    {
        [JsonProperty("gameCreation")]
        public long GameCreation { get; set; }
        [JsonProperty("gameCreationDate")]
        public string GameCreationDate { get; set; }
        [JsonProperty("gameDuration")]
        public int GameDuration { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("gameType")]
        public string GameType { get; set; }
        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }
        [JsonProperty("mapId")]
        public int MapId { get; set; }
        [JsonProperty("participantIdentities")]
        public LolRecommendationsMatchHistoryParticipantIdentities[] ParticipantIdentities { get; set; }
        [JsonProperty("participants")]
        public LolRecommendationsMatchHistoryParticipant[] Participants { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("seasonId")]
        public int SeasonId { get; set; }
    }
}
