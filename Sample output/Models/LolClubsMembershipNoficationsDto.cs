using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsMembershipNoficationsDto
    {
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("clubKey")]
        public string ClubKey { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
