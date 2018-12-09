using Newtonsoft.Json;

namespace LCU_API_Generator
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
