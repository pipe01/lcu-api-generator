using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsClubDataDto
    {
        [JsonProperty("clubKey")]
        public string ClubKey { get; set; }
        [JsonProperty("createdTs")]
        public long CreatedTs { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("jid")]
        public string Jid { get; set; }
        [JsonProperty("lastModifiedTs")]
        public long LastModifiedTs { get; set; }
        [JsonProperty("motd")]
        public string Motd { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("permissionMap")]
        public LolClubsClubPermissions PermissionMap { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}
