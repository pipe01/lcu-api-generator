using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RsoAuthUserInfo
    {
        [JsonProperty("userInfo")]
        public string UserInfo { get; set; }
    }
}
