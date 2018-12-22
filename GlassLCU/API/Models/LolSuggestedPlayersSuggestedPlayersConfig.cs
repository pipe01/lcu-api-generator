using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSuggestedPlayersSuggestedPlayersConfig
    {
        [JsonProperty("Enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("FriendsOfFriendsEnabled")]
        public bool FriendsOfFriendsEnabled { get; set; }
        [JsonProperty("FriendsOfFriendsLimit")]
        public int FriendsOfFriendsLimit { get; set; }
        [JsonProperty("MaxNumReplacements")]
        public int MaxNumReplacements { get; set; }
        [JsonProperty("MaxNumSuggestedPlayers")]
        public int MaxNumSuggestedPlayers { get; set; }
        [JsonProperty("OnlineFriendsLimit")]
        public int OnlineFriendsLimit { get; set; }
        [JsonProperty("PreviousPremadesLimit")]
        public int PreviousPremadesLimit { get; set; }
        [JsonProperty("VicoriousComradesLimit")]
        public int VicoriousComradesLimit { get; set; }
    }
}
