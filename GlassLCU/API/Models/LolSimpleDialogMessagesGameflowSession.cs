using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSimpleDialogMessagesGameflowSession
    {
        [JsonProperty("phase")]
        public LolSimpleDialogMessagesGameflowPhase Phase { get; set; }
    }
}
