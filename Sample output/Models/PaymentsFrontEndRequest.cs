using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PaymentsFrontEndRequest
    {
        [JsonProperty("gifteeAccountId")]
        public string GifteeAccountId { get; set; }
        [JsonProperty("gifteeMessage")]
        public string GifteeMessage { get; set; }
        [JsonProperty("isPrepaid")]
        public bool IsPrepaid { get; set; }
        [JsonProperty("localeId")]
        public string LocaleId { get; set; }
        [JsonProperty("rsoToken")]
        public string RsoToken { get; set; }
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}
