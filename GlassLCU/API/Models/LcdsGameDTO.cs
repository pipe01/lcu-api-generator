using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LcdsGameDTO
    {
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("gameMutators")]
        public string[] GameMutators { get; set; }
        [JsonProperty("gameState")]
        public string GameState { get; set; }
        [JsonProperty("gameType")]
        public string GameType { get; set; }
        [JsonProperty("gameTypeConfigId")]
        public int GameTypeConfigId { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("mapId")]
        public int MapId { get; set; }
        [JsonProperty("maxNumPlayers")]
        public int MaxNumPlayers { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("observers")]
        public LcdsPlayerParticipant[] Observers { get; set; }
        [JsonProperty("optimisticLock")]
        public long OptimisticLock { get; set; }
        [JsonProperty("ownerSummary")]
        public LcdsPlayerParticipant OwnerSummary { get; set; }
        [JsonProperty("passbackDataPacket")]
        public string PassbackDataPacket { get; set; }
        [JsonProperty("passbackUrl")]
        public string PassbackUrl { get; set; }
        [JsonProperty("practiceGameRewardsDisabledReasons")]
        public string[] PracticeGameRewardsDisabledReasons { get; set; }
        [JsonProperty("roomName")]
        public string RoomName { get; set; }
        [JsonProperty("roomPassword")]
        public string RoomPassword { get; set; }
        [JsonProperty("spectatorsAllowed")]
        public string SpectatorsAllowed { get; set; }
        [JsonProperty("teamOne")]
        public LcdsPlayerParticipant[] TeamOne { get; set; }
        [JsonProperty("teamTwo")]
        public LcdsPlayerParticipant[] TeamTwo { get; set; }
    }
}
