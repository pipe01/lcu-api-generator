using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PlayerMissionDTO
    {
        [JsonProperty("backgroundImageUrl")]
        public string BackgroundImageUrl { get; set; }
        [JsonProperty("celebrationType")]
        public string CelebrationType { get; set; }
        [JsonProperty("clientNotifyLevel")]
        public string ClientNotifyLevel { get; set; }
        [JsonProperty("completedDate")]
        public long CompletedDate { get; set; }
        [JsonProperty("completionExpression")]
        public string CompletionExpression { get; set; }
        [JsonProperty("cooldownTimeMillis")]
        public long CooldownTimeMillis { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("display")]
        public MissionDisplay Display { get; set; }
        [JsonProperty("displayType")]
        public string DisplayType { get; set; }
        [JsonProperty("endTime")]
        public long EndTime { get; set; }
        [JsonProperty("expiringWarnings")]
        public MissionAlertDTO[] ExpiringWarnings { get; set; }
        [JsonProperty("helperText")]
        public string HelperText { get; set; }
        [JsonProperty("iconImageUrl")]
        public string IconImageUrl { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("internalName")]
        public string InternalName { get; set; }
        [JsonProperty("isNew")]
        public bool IsNew { get; set; }
        [JsonProperty("lastUpdatedTimestamp")]
        public long LastUpdatedTimestamp { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("metadata")]
        public MissionMetadata Metadata { get; set; }
        [JsonProperty("missionType")]
        public string MissionType { get; set; }
        [JsonProperty("objectives")]
        public PlayerMissionObjectiveDTO[] Objectives { get; set; }
        [JsonProperty("requirements")]
        public string[] Requirements { get; set; }
        [JsonProperty("rewardStrategy")]
        public RewardStrategy RewardStrategy { get; set; }
        [JsonProperty("rewards")]
        public PlayerMissionRewardDTO[] Rewards { get; set; }
        [JsonProperty("seriesName")]
        public string SeriesName { get; set; }
        [JsonProperty("startTime")]
        public long StartTime { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("viewed")]
        public bool Viewed { get; set; }
    }
}
