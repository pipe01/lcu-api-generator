using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
