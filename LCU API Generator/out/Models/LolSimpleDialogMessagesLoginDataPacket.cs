using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSimpleDialogMessagesLoginDataPacket
    {
        [JsonProperty("simpleMessages")]
        public LolSimpleDialogMessagesSimpleMessage[] SimpleMessages { get; set; }
    }
}
