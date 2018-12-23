//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathCollectionsChampion
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("banVoPath")]
        public string BanVoPath { get; set; }
        [JsonProperty("chooseVoPath")]
        public string ChooseVoPath { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("passive")]
        public LolNpeTutorialPathCollectionsChampionSpell Passive { get; set; }
        [JsonProperty("roles")]
        public string[] Roles { get; set; }
        [JsonProperty("spells")]
        public LolNpeTutorialPathCollectionsChampionSpell[] Spells { get; set; }
        [JsonProperty("squarePortraitPath")]
        public string SquarePortraitPath { get; set; }
        [JsonProperty("stingerSfxPath")]
        public string StingerSfxPath { get; set; }
    }
}
