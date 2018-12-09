using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryTeam
    {
        [JsonProperty("bans")]
        public LolMatchHistoryMatchHistoryTeamBan[] Bans { get; set; }
        [JsonProperty("baronKills")]
        public int BaronKills { get; set; }
        [JsonProperty("dominionVictoryScore")]
        public int DominionVictoryScore { get; set; }
        [JsonProperty("dragonKills")]
        public int DragonKills { get; set; }
        [JsonProperty("firstBaron")]
        public bool FirstBaron { get; set; }
        [JsonProperty("firstBlood")]
        public bool FirstBlood { get; set; }
        [JsonProperty("firstDargon")]
        public bool FirstDargon { get; set; }
        [JsonProperty("firstInhibitor")]
        public bool FirstInhibitor { get; set; }
        [JsonProperty("firstTower")]
        public bool FirstTower { get; set; }
        [JsonProperty("inhibitorKills")]
        public int InhibitorKills { get; set; }
        [JsonProperty("riftHeraldKills")]
        public int RiftHeraldKills { get; set; }
        [JsonProperty("teamId")]
        public int TeamId { get; set; }
        [JsonProperty("towerKills")]
        public int TowerKills { get; set; }
        [JsonProperty("vilemawKills")]
        public int VilemawKills { get; set; }
        [JsonProperty("win")]
        public string Win { get; set; }
    }
}
