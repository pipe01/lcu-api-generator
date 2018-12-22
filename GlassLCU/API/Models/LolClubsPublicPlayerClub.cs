using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
