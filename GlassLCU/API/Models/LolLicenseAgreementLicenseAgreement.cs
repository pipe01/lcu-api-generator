using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLicenseAgreementLicenseAgreement
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("licenseType")]
        public LolLicenseAgreementLicenseAgreementType LicenseType { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}