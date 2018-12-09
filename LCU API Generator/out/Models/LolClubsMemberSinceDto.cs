using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsMemberSinceDto
    {
        [JsonProperty("playerInfo")]
        public LolClubsPlayerInfoDto PlayerInfo { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("since")]
        public long Since { get; set; }
    }
}
