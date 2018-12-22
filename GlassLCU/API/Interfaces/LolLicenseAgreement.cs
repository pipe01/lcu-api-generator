using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolLicenseAgreement
    {
        public static Task<LolLicenseAgreementLicenseAgreement[]> GetLolLicenseAgreementV1Agreements()
            => Sender.Request<LolLicenseAgreementLicenseAgreement[]>("get", $"/lol-license-agreement/v1/agreements");
        public static Task<object> PostLolLicenseAgreementV1AgreementsByIdAccept([Parameter("id", "path")] string id)
            => Sender.Request<object>("post", $"/lol-license-agreement/v1/agreements/{id}/accept");
        public static Task<object> PostLolLicenseAgreementV1AgreementsByIdDecline([Parameter("id", "path")] string id)
            => Sender.Request<object>("post", $"/lol-license-agreement/v1/agreements/{id}/decline");
        public static Task<LolLicenseAgreementLicenseAgreement[]> GetLolLicenseAgreementV1AllAgreements()
            => Sender.Request<LolLicenseAgreementLicenseAgreement[]>("get", $"/lol-license-agreement/v1/all-agreements");
    }
}
