using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class BuildInfo
    {
        [JsonProperty("branch")]
        public string Branch { get; set; }
        [JsonProperty("branchFull")]
        public string BranchFull { get; set; }
        [JsonProperty("codeBuildId")]
        public int CodeBuildId { get; set; }
        [JsonProperty("contentBuildId")]
        public int ContentBuildId { get; set; }
        [JsonProperty("gameBranch")]
        public string GameBranch { get; set; }
        [JsonProperty("gameBranchFull")]
        public string GameBranchFull { get; set; }
        [JsonProperty("gameDataBuildId")]
        public int GameDataBuildId { get; set; }
        [JsonProperty("patchline")]
        public string Patchline { get; set; }
        [JsonProperty("patchlineVisibleName")]
        public string PatchlineVisibleName { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}