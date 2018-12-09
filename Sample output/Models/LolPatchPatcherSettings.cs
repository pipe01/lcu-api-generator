using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPatchPatcherSettings
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }
        [JsonProperty("client_patcher")]
        public string Client_patcher { get; set; }
        [JsonProperty("game_patcher")]
        public string Game_patcher { get; set; }
        [JsonProperty("headers")]
        public object Headers { get; set; }
        [JsonProperty("patchline")]
        public string Patchline { get; set; }
        [JsonProperty("product_refresh_period")]
        public float Product_refresh_period { get; set; }
        [JsonProperty("self_update")]
        public LolPatchPatcherSelfUpdateSettings Self_update { get; set; }
    }
}
