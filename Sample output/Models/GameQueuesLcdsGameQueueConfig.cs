using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class GameQueuesLcdsGameQueueConfig
    {
        [JsonProperty("blockedMinutesThreshold")]
        public int BlockedMinutesThreshold { get; set; }
        [JsonProperty("botsCanSpawnOnBlueSide")]
        public bool BotsCanSpawnOnBlueSide { get; set; }
        [JsonProperty("cacheName")]
        public string CacheName { get; set; }
        [JsonProperty("disallowFreeChampions")]
        public bool DisallowFreeChampions { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("gameMutators")]
        public string[] GameMutators { get; set; }
        [JsonProperty("gameTypeConfigId")]
        public int GameTypeConfigId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("lastToggledOffTime")]
        public long LastToggledOffTime { get; set; }
        [JsonProperty("lastToggledOnTime")]
        public long LastToggledOnTime { get; set; }
        [JsonProperty("mapSelectionAlgorithm")]
        public string MapSelectionAlgorithm { get; set; }
        [JsonProperty("matchingThrottleConfig")]
        public GameQueuesLcdsMatchingThrottleConfig MatchingThrottleConfig { get; set; }
        [JsonProperty("maxLevel")]
        public int MaxLevel { get; set; }
        [JsonProperty("maxSummonerLevelForFirstWinOfTheDay")]
        public int MaxSummonerLevelForFirstWinOfTheDay { get; set; }
        [JsonProperty("maximumParticipantListSize")]
        public int MaximumParticipantListSize { get; set; }
        [JsonProperty("minLevel")]
        public int MinLevel { get; set; }
        [JsonProperty("minimumParticipantListSize")]
        public int MinimumParticipantListSize { get; set; }
        [JsonProperty("minimumQueueDodgeDelayTime")]
        public int MinimumQueueDodgeDelayTime { get; set; }
        [JsonProperty("numPlayersPerTeam")]
        public int NumPlayersPerTeam { get; set; }
        [JsonProperty("pointsConfigKey")]
        public string PointsConfigKey { get; set; }
        [JsonProperty("queueBonusKey")]
        public string QueueBonusKey { get; set; }
        [JsonProperty("queueState")]
        public string QueueState { get; set; }
        [JsonProperty("queueStateString")]
        public string QueueStateString { get; set; }
        [JsonProperty("randomizeTeamSizes")]
        public bool RandomizeTeamSizes { get; set; }
        [JsonProperty("ranked")]
        public bool Ranked { get; set; }
        [JsonProperty("supportedMapIds")]
        public int[] SupportedMapIds { get; set; }
        [JsonProperty("teamOnly")]
        public bool TeamOnly { get; set; }
        [JsonProperty("thresholdEnabled")]
        public bool ThresholdEnabled { get; set; }
        [JsonProperty("thresholdSize")]
        public long ThresholdSize { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("typeString")]
        public string TypeString { get; set; }
    }
}
