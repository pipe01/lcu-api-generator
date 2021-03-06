//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
