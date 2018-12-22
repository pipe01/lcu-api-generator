using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryGame
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
        public LolMatchHistoryMatchHistoryParticipantIdentities[] ParticipantIdentities { get; set; }
        [JsonProperty("participants")]
        public LolMatchHistoryMatchHistoryParticipant[] Participants { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("seasonId")]
        public int SeasonId { get; set; }
        [JsonProperty("teams")]
        public LolMatchHistoryMatchHistoryTeam[] Teams { get; set; }
    }
}
