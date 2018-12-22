using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMissionsPlayerUpdateResponse
    {
        [JsonProperty("playerMissions")]
        public PlayerMissionDTO[] PlayerMissions { get; set; }
        [JsonProperty("playerSeries")]
        public SeriesDTO[] PlayerSeries { get; set; }
    }
}
