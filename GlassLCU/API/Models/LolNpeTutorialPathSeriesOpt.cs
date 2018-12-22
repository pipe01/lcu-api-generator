using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathSeriesOpt
    {
        [JsonProperty("optStatus")]
        public string OptStatus { get; set; }
        [JsonProperty("seriesId")]
        public string SeriesId { get; set; }
    }
}
