using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class BindingAsyncFailureEvent
    {
        /// <summary>
        /// Asynchronous operation token
        /// </summary>
        [JsonProperty("asyncToken")]
        public int AsyncToken { get; set; }
        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
