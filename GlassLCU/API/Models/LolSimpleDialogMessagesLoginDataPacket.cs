using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSimpleDialogMessagesLoginDataPacket
    {
        [JsonProperty("simpleMessages")]
        public LolSimpleDialogMessagesSimpleMessage[] SimpleMessages { get; set; }
    }
}
