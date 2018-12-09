using Newtonsoft.Json;

namespace LCU_API_Generator
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
