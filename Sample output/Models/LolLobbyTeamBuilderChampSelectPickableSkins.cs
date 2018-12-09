using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderChampSelectPickableSkins
    {
        [JsonProperty("skinIds")]
        public int[] SkinIds { get; set; }
    }
}
