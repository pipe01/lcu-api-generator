using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPlayerMessagingDynamicCelebrationMessagingNotificationResource
    {
        [JsonProperty("celebrationBody")]
        public string CelebrationBody { get; set; }
        [JsonProperty("celebrationMessage")]
        public string CelebrationMessage { get; set; }
        [JsonProperty("celebrationTitle")]
        public string CelebrationTitle { get; set; }
        [JsonProperty("celebrationType")]
        public string CelebrationType { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("itemId")]
        public string ItemId { get; set; }
        [JsonProperty("itemQuantity")]
        public string ItemQuantity { get; set; }
        [JsonProperty("msgId")]
        public string MsgId { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
    }
}