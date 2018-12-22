using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LcdsInvitePrivileges
    {
        [JsonProperty("canInvite")]
        public bool CanInvite { get; set; }
    }
}
