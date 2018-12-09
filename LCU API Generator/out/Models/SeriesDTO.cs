using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class SeriesDTO
    {
        [JsonProperty("createdDate")]
        public long CreatedDate { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("displayType")]
        public string DisplayType { get; set; }
        [JsonProperty("eligibilityType")]
        public string EligibilityType { get; set; }
        [JsonProperty("endDate")]
        public long EndDate { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("internalName")]
        public string InternalName { get; set; }
        [JsonProperty("lastUpdatedTimestamp")]
        public long LastUpdatedTimestamp { get; set; }
        [JsonProperty("media")]
        public SeriesMediaDTO Media { get; set; }
        [JsonProperty("optInButtonText")]
        public string OptInButtonText { get; set; }
        [JsonProperty("optOutButtonText")]
        public string OptOutButtonText { get; set; }
        [JsonProperty("parentInternalName")]
        public string ParentInternalName { get; set; }
        [JsonProperty("startDate")]
        public long StartDate { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("viewed")]
        public bool Viewed { get; set; }
        [JsonProperty("warnings")]
        public AlertDTO[] Warnings { get; set; }
    }
}
