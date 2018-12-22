using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootLootRecipeGdsResource
    {
        [JsonProperty("contextMenuText")]
        public string ContextMenuText { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("imagePath")]
        public string ImagePath { get; set; }
        [JsonProperty("introVideoPath")]
        public string IntroVideoPath { get; set; }
        [JsonProperty("loopVideoPath")]
        public string LoopVideoPath { get; set; }
        [JsonProperty("outroVideoPath")]
        public string OutroVideoPath { get; set; }
        [JsonProperty("requirementText")]
        public string RequirementText { get; set; }
    }
}
