using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class EndOfGameLcdsTeamInfo
    {
        [JsonProperty("memberStatusString")]
        public string MemberStatusString { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("secondsUntilEligibleForDeletion")]
        public long SecondsUntilEligibleForDeletion { get; set; }
        [JsonProperty("tag")]
        public string Tag { get; set; }
        [JsonProperty("teamId")]
        public EndOfGameLcdsTeamId TeamId { get; set; }
    }
}
