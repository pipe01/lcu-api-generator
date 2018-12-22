using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolWorldsTokenCardLootTokenBankCardGdsResource
    {
        [JsonProperty("activationDate")]
        public string ActivationDate { get; set; }
        [JsonProperty("backsplashImagePath")]
        public string BacksplashImagePath { get; set; }
        [JsonProperty("buttonText")]
        public string ButtonText { get; set; }
        [JsonProperty("deactivationDate")]
        public string DeactivationDate { get; set; }
        [JsonProperty("lootItemName")]
        public string LootItemName { get; set; }
        [JsonProperty("nonPremiumCapCurrencyId")]
        public string NonPremiumCapCurrencyId { get; set; }
        [JsonProperty("premiumCapCurrencyId")]
        public string PremiumCapCurrencyId { get; set; }
        [JsonProperty("storeLinkItem")]
        public string StoreLinkItem { get; set; }
        [JsonProperty("storeLinkType")]
        public string StoreLinkType { get; set; }
        [JsonProperty("titleText")]
        public string TitleText { get; set; }
        [JsonProperty("tokenIconPath")]
        public string TokenIconPath { get; set; }
        [JsonProperty("tooltipDescriptionText")]
        public string TooltipDescriptionText { get; set; }
        [JsonProperty("tooltipSplashPath")]
        public string TooltipSplashPath { get; set; }
        [JsonProperty("tooltipTitleText")]
        public string TooltipTitleText { get; set; }
        [JsonProperty("unlockItemId")]
        public string UnlockItemId { get; set; }
    }
}
