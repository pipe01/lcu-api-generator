using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyQueue
    {
        [JsonProperty("allowablePremadeSizes")]
        public int[] AllowablePremadeSizes { get; set; }
        [JsonProperty("areFreeChampionsAllowed")]
        public bool AreFreeChampionsAllowed { get; set; }
        [JsonProperty("assetMutator")]
        public string AssetMutator { get; set; }
        [JsonProperty("category")]
        public LolLobbyQueueGameCategory Category { get; set; }
        [JsonProperty("championsRequiredToPlay")]
        public int ChampionsRequiredToPlay { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("detailedDescription")]
        public string DetailedDescription { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("gameTypeConfig")]
        public LolLobbyQueueGameTypeConfig GameTypeConfig { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("isRanked")]
        public bool IsRanked { get; set; }
        [JsonProperty("isTeamBuilderManaged")]
        public bool IsTeamBuilderManaged { get; set; }
        [JsonProperty("isTeamOnly")]
        public bool IsTeamOnly { get; set; }
        [JsonProperty("mapId")]
        public int MapId { get; set; }
        [JsonProperty("maxSummonerLevelForFirstWinOfTheDay")]
        public int MaxSummonerLevelForFirstWinOfTheDay { get; set; }
        [JsonProperty("maximumParticipantListSize")]
        public int MaximumParticipantListSize { get; set; }
        [JsonProperty("minLevel")]
        public int MinLevel { get; set; }
        [JsonProperty("minimumParticipantListSize")]
        public int MinimumParticipantListSize { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("numPlayersPerTeam")]
        public int NumPlayersPerTeam { get; set; }
        [JsonProperty("queueAvailability")]
        public LolLobbyQueueAvailability QueueAvailability { get; set; }
        [JsonProperty("queueRewards")]
        public LolLobbyQueueReward QueueRewards { get; set; }
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
        [JsonProperty("showPositionSelector")]
        public bool ShowPositionSelector { get; set; }
        [JsonProperty("spectatorEnabled")]
        public bool SpectatorEnabled { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
