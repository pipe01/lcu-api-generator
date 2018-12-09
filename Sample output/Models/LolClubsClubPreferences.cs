using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsClubPreferences
    {
        [JsonProperty("primaryClubKey")]
        public string PrimaryClubKey { get; set; }
        [JsonProperty("shareClubAffiliation")]
        public bool ShareClubAffiliation { get; set; }
    }
}
