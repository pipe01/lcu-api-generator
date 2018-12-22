using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PaymentsPMCStartUrlResult
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("localeId")]
        public string LocaleId { get; set; }
        [JsonProperty("playerFacingId")]
        public string PlayerFacingId { get; set; }
        [JsonProperty("pmcStartUrl")]
        public string PmcStartUrl { get; set; }
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
        [JsonProperty("userId")]
        public string UserId { get; set; }
    }
}
