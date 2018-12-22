using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PaymentsPMCStartUrlRequest
    {
        [JsonProperty("gifteeAccountId")]
        public string GifteeAccountId { get; set; }
        [JsonProperty("gifteeMessage")]
        public string GifteeMessage { get; set; }
        [JsonProperty("isPrepaid")]
        public bool IsPrepaid { get; set; }
        [JsonProperty("localeId")]
        public string LocaleId { get; set; }
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}