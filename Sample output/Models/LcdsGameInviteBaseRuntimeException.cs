using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LcdsGameInviteBaseRuntimeException
    {
        [JsonProperty("rootCauseClassname")]
        public string RootCauseClassname { get; set; }
    }
}
