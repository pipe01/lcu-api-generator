using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LcdsGameInviteBaseRuntimeException
    {
        [JsonProperty("rootCauseClassname")]
        public string RootCauseClassname { get; set; }
    }
}
