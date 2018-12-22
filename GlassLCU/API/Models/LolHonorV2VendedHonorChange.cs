using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolHonorV2VendedHonorChange
    {
        [JsonProperty("actionType")]
        public string ActionType { get; set; }
        [JsonProperty("currentState")]
        public LolHonorV2VendedHonorState CurrentState { get; set; }
        [JsonProperty("dynamicHonorMessage")]
        public LolHonorV2DynamicHonorMessage DynamicHonorMessage { get; set; }
        [JsonProperty("previousState")]
        public LolHonorV2VendedHonorState PreviousState { get; set; }
        [JsonProperty("reward")]
        public LolHonorV2Reward Reward { get; set; }
    }
}
