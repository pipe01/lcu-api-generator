using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeRewardsMissionSeriesOptIn
    {
        [JsonProperty("optStatus")]
        public string OptStatus { get; set; }
        [JsonProperty("seriesId")]
        public string SeriesId { get; set; }
    }
}
