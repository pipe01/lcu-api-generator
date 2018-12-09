using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsPlayerMembershipPreferencesDto
    {
        [JsonProperty("primaryActiveClubKey")]
        public string PrimaryActiveClubKey { get; set; }
        [JsonProperty("shareClubAffiliation")]
        public bool ShareClubAffiliation { get; set; }
    }
}
