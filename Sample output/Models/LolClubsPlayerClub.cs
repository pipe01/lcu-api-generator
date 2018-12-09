using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsPlayerClub
    {
        [JsonProperty("created")]
        public long Created { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("isClubTagEligible")]
        public bool IsClubTagEligible { get; set; }
        [JsonProperty("jid")]
        public string Jid { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("lastModified")]
        public long LastModified { get; set; }
        [JsonProperty("members")]
        public LolClubsClubMemberLists Members { get; set; }
        [JsonProperty("motd")]
        public string Motd { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("owner")]
        public LolClubsClubMember Owner { get; set; }
        [JsonProperty("permissions")]
        public LolClubsClubPermissions Permissions { get; set; }
        [JsonProperty("primary")]
        public bool Primary { get; set; }
        [JsonProperty("role")]
        public LolClubsClubRole Role { get; set; }
        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}
