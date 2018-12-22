using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolWorldsTokenCardTokenUpsell
    {
        [JsonProperty("backgroundUrl")]
        public string BackgroundUrl { get; set; }
        [JsonProperty("buttonText")]
        public string ButtonText { get; set; }
        [JsonProperty("currencyUrl")]
        public string CurrencyUrl { get; set; }
        [JsonProperty("currentlyLocked")]
        public LolWorldsTokenCardTokenUpsellLockedType CurrentlyLocked { get; set; }
        [JsonProperty("dependentInventoryId")]
        public int DependentInventoryId { get; set; }
        [JsonProperty("dependentInventoryType")]
        public string DependentInventoryType { get; set; }
        [JsonProperty("endDate")]
        public string EndDate { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("internalName")]
        public string InternalName { get; set; }
        [JsonProperty("lockedCount")]
        public int LockedCount { get; set; }
        [JsonProperty("premiumCurrencyName")]
        public string PremiumCurrencyName { get; set; }
        [JsonProperty("purchaseUrl")]
        public string PurchaseUrl { get; set; }
        [JsonProperty("startDate")]
        public string StartDate { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("tooltipBackgroundUrl")]
        public string TooltipBackgroundUrl { get; set; }
        [JsonProperty("tooltipDescription")]
        public string TooltipDescription { get; set; }
        [JsonProperty("tooltipTitle")]
        public string TooltipTitle { get; set; }
    }
}
