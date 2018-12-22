using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyUserInfoToken
    {
        [JsonProperty("userInfo")]
        public string UserInfo { get; set; }
    }
}
