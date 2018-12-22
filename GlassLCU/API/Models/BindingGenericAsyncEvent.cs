using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class BindingGenericAsyncEvent
    {
        /// <summary>
        /// Asynchronous operation token
        /// </summary>
        [JsonProperty("asyncToken")]
        public int AsyncToken { get; set; }
        /// <summary>
        /// Event data
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}