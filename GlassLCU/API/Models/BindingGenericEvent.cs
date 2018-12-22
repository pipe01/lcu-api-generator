using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class BindingGenericEvent
    {
        /// <summary>
        /// Event data
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
