using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderCellsV1
    {
        [JsonProperty("alliedTeam")]
        public LolLobbyTeamBuilderCellV1[] AlliedTeam { get; set; }
        [JsonProperty("enemyTeam")]
        public LolLobbyTeamBuilderCellV1[] EnemyTeam { get; set; }
    }
}
