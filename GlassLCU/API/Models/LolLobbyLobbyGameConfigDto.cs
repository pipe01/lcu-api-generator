using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyLobbyGameConfigDto
    {
        [JsonProperty("allowablePremadeSizes")]
        public int[] AllowablePremadeSizes { get; set; }
        [JsonProperty("customLobbyName")]
        public string CustomLobbyName { get; set; }
        [JsonProperty("customMutatorName")]
        public string CustomMutatorName { get; set; }
        [JsonProperty("customRewardsDisabledReasons")]
        public string[] CustomRewardsDisabledReasons { get; set; }
        [JsonProperty("customSpectatorPolicy")]
        public LolLobbyQueueCustomGameSpectatorPolicy CustomSpectatorPolicy { get; set; }
        [JsonProperty("customSpectators")]
        public LolLobbyLobbyParticipantDto[] CustomSpectators { get; set; }
        [JsonProperty("customTeam100")]
        public LolLobbyLobbyParticipantDto[] CustomTeam100 { get; set; }
        [JsonProperty("customTeam200")]
        public LolLobbyLobbyParticipantDto[] CustomTeam200 { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }
        [JsonProperty("isLobbyFull")]
        public bool IsLobbyFull { get; set; }
        [JsonProperty("isTeamBuilderManaged")]
        public bool IsTeamBuilderManaged { get; set; }
        [JsonProperty("mapId")]
        public int MapId { get; set; }
        [JsonProperty("maxHumanPlayers")]
        public int MaxHumanPlayers { get; set; }
        [JsonProperty("maxLobbySize")]
        public int MaxLobbySize { get; set; }
        [JsonProperty("maxTeamSize")]
        public int MaxTeamSize { get; set; }
        [JsonProperty("pickType")]
        public string PickType { get; set; }
        [JsonProperty("premadeSizeAllowed")]
        public bool PremadeSizeAllowed { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("showPositionSelector")]
        public bool ShowPositionSelector { get; set; }
    }
}
