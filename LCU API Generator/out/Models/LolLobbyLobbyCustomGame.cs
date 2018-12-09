using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLobbyCustomGame
    {
        [JsonProperty("filledPlayerSlots")]
        public int FilledPlayerSlots { get; set; }
        [JsonProperty("filledSpectatorSlots")]
        public int FilledSpectatorSlots { get; set; }
        [JsonProperty("gameType")]
        public string GameType { get; set; }
        [JsonProperty("hasPassword")]
        public bool HasPassword { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("lobbyName")]
        public string LobbyName { get; set; }
        [JsonProperty("mapId")]
        public int MapId { get; set; }
        [JsonProperty("maxPlayerSlots")]
        public int MaxPlayerSlots { get; set; }
        [JsonProperty("maxSpectatorSlots")]
        public long MaxSpectatorSlots { get; set; }
        [JsonProperty("ownerSummonerName")]
        public string OwnerSummonerName { get; set; }
        [JsonProperty("passbackUrl")]
        public string PassbackUrl { get; set; }
        [JsonProperty("spectatorPolicy")]
        public string SpectatorPolicy { get; set; }
    }
}
