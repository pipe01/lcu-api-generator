using Newtonsoft.Json;

namespace LCU_API_Generator
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
