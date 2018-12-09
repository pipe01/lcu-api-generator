using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LcdsInvitePrivileges
    {
        [JsonProperty("canInvite")]
        public bool CanInvite { get; set; }
    }
}
