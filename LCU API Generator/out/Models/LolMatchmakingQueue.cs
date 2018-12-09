using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchmakingQueue
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("isTeamBuilderManaged")]
        public bool IsTeamBuilderManaged { get; set; }
    }
}