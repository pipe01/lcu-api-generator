using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathTeam
    {
        [JsonProperty("baronKills")]
        public int BaronKills { get; set; }
        [JsonProperty("dragonKills")]
        public int DragonKills { get; set; }
        [JsonProperty("inhibitorKills")]
        public int InhibitorKills { get; set; }
        [JsonProperty("riftHeraldKills")]
        public int RiftHeraldKills { get; set; }
        [JsonProperty("teamId")]
        public int TeamId { get; set; }
        [JsonProperty("towerKills")]
        public int TowerKills { get; set; }
        [JsonProperty("win")]
        public string Win { get; set; }
    }
}
