using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampionsCollectionsChampion
    {
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("banVoPath")]
        public string BanVoPath { get; set; }
        [JsonProperty("botEnabled")]
        public bool BotEnabled { get; set; }
        [JsonProperty("chooseVoPath")]
        public string ChooseVoPath { get; set; }
        [JsonProperty("disabledQueues")]
        public string[] DisabledQueues { get; set; }
        [JsonProperty("freeToPlay")]
        public bool FreeToPlay { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("ownership")]
        public LolChampionsCollectionsOwnership Ownership { get; set; }
        [JsonProperty("passive")]
        public LolChampionsCollectionsChampionSpell Passive { get; set; }
        [JsonProperty("purchased")]
        public long Purchased { get; set; }
        [JsonProperty("rankedPlayEnabled")]
        public bool RankedPlayEnabled { get; set; }
        [JsonProperty("roles")]
        public string[] Roles { get; set; }
        [JsonProperty("skins")]
        public LolChampionsCollectionsChampionSkin[] Skins { get; set; }
        [JsonProperty("spells")]
        public LolChampionsCollectionsChampionSpell[] Spells { get; set; }
        [JsonProperty("squarePortraitPath")]
        public string SquarePortraitPath { get; set; }
        [JsonProperty("stingerSfxPath")]
        public string StingerSfxPath { get; set; }
        [JsonProperty("tacticalInfo")]
        public LolChampionsCollectionsChampionTacticalInfo TacticalInfo { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
