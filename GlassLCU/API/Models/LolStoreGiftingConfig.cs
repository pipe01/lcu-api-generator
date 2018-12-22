using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolStoreGiftingConfig
    {
        [JsonProperty("giftingHextecMaxDailyGiftsReceive")]
        public int GiftingHextecMaxDailyGiftsReceive { get; set; }
        [JsonProperty("giftingHextechMaxDailyGiftsSend")]
        public int GiftingHextechMaxDailyGiftsSend { get; set; }
        [JsonProperty("giftingItemMaxDailyGiftsReceive")]
        public int GiftingItemMaxDailyGiftsReceive { get; set; }
        [JsonProperty("giftingItemMaxDailyGiftsSend")]
        public int GiftingItemMaxDailyGiftsSend { get; set; }
        [JsonProperty("giftingItemMinLevelSend")]
        public int GiftingItemMinLevelSend { get; set; }
        [JsonProperty("giftingRestrictionFlagRioter")]
        public int GiftingRestrictionFlagRioter { get; set; }
        [JsonProperty("giftingRpMaxDailyGiftsReceive")]
        public int GiftingRpMaxDailyGiftsReceive { get; set; }
        [JsonProperty("giftingRpMaxDailyGiftsSend")]
        public int GiftingRpMaxDailyGiftsSend { get; set; }
        [JsonProperty("giftingRpMinLevelSend")]
        public int GiftingRpMinLevelSend { get; set; }
        [JsonProperty("recipientLevelLimitItem")]
        public int RecipientLevelLimitItem { get; set; }
        [JsonProperty("recipientLevelLimitRp")]
        public int RecipientLevelLimitRp { get; set; }
        [JsonProperty("requiresIdentityVerification")]
        public bool RequiresIdentityVerification { get; set; }
    }
}
