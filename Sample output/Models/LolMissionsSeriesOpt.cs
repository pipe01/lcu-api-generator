using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMissionsSeriesOpt
    {
        [JsonProperty("optStatus")]
        public string OptStatus { get; set; }
        [JsonProperty("seriesId")]
        public string SeriesId { get; set; }
    }
}
