using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderChampSelectPickableSkins
    {
        [JsonProperty("skinIds")]
        public int[] SkinIds { get; set; }
    }
}
