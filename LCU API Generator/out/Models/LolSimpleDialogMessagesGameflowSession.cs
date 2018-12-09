using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSimpleDialogMessagesGameflowSession
    {
        [JsonProperty("phase")]
        public LolSimpleDialogMessagesGameflowPhase Phase { get; set; }
    }
}
