using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGeoinfoGeoInfoResponse
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
        [JsonProperty("geoInfo")]
        public LolGeoinfoGeoInfo GeoInfo { get; set; }
        [JsonProperty("isInitialized")]
        public bool IsInitialized { get; set; }
        [JsonProperty("isLatest")]
        public bool IsLatest { get; set; }
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}