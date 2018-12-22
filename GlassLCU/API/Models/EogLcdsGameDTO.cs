using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class EogLcdsGameDTO
    {
        [JsonProperty("bannedChampions")]
        public BannedChampion[] BannedChampions { get; set; }
        [JsonProperty("gameState")]
        public string GameState { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("teamOne")]
        public PlayerParticipant[] TeamOne { get; set; }
        [JsonProperty("teamTwo")]
        public PlayerParticipant[] TeamTwo { get; set; }
    }
}