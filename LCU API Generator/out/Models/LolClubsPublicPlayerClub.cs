using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsPublicPlayerClub
    {
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("members")]
        public LolClubsPublicClubMemberLists Members { get; set; }
    }
}
