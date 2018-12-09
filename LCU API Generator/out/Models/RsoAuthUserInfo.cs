using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RsoAuthUserInfo
    {
        [JsonProperty("userInfo")]
        public string UserInfo { get; set; }
    }
}
