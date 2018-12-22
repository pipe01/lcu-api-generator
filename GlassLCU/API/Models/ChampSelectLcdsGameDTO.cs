using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ChampSelectLcdsGameDTO
    {
        [JsonProperty("bannedChampions")]
        public BannedChampion[] BannedChampions { get; set; }
        [JsonProperty("gameMutators")]
        public string[] GameMutators { get; set; }
        [JsonProperty("gameState")]
        public string GameState { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("optimisticLock")]
        public long OptimisticLock { get; set; }
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }
        [JsonProperty("playerChampionSelections")]
        public ChampSelectLcdsPlayerChampionSelectionDTO[] PlayerChampionSelections { get; set; }
        [JsonProperty("queueTypeName")]
        public string QueueTypeName { get; set; }
        [JsonProperty("roomName")]
        public string RoomName { get; set; }
        [JsonProperty("roomPassword")]
        public string RoomPassword { get; set; }
        [JsonProperty("spectatorDelay")]
        public long SpectatorDelay { get; set; }
        [JsonProperty("statusOfParticipants")]
        public string StatusOfParticipants { get; set; }
        [JsonProperty("teamOne")]
        public object[] TeamOne { get; set; }
        [JsonProperty("teamTwo")]
        public object[] TeamTwo { get; set; }
    }
}
