using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathHowToWinObjectivesDto
    {
        [JsonProperty("barons")]
        public int Barons { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("dragons")]
        public int Dragons { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("heralds")]
        public int Heralds { get; set; }
        [JsonProperty("inhibitors")]
        public int Inhibitors { get; set; }
        [JsonProperty("newRecord")]
        public bool NewRecord { get; set; }
        [JsonProperty("nexus")]
        public int Nexus { get; set; }
        [JsonProperty("objectives")]
        public int Objectives { get; set; }
        [JsonProperty("towers")]
        public int Towers { get; set; }
    }
}
