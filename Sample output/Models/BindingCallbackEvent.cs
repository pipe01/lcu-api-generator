using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class BindingCallbackEvent
    {
        /// <summary>
        /// ID of the callback being invoked
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// Callback parameters
        /// </summary>
        [JsonProperty("parameters")]
        public object[] Parameters { get; set; }
    }
}
