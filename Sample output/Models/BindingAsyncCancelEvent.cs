using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class BindingAsyncCancelEvent
    {
        /// <summary>
        /// Asynchronous operation token
        /// </summary>
        [JsonProperty("asyncToken")]
        public int AsyncToken { get; set; }
    }
}
