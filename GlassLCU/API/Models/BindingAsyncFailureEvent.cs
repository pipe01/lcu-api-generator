using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
