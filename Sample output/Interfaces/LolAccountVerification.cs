using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolAccountVerification
    {
        public static Task<LolAccountVerificationAuthenticateResponse> PostLolAccountVerificationV1Authenticate([Parameter("AuthenticateRequest", "body")] LolAccountVerificationAuthenticateRequest AuthenticateRequest)
            => Sender.Request<LolAccountVerificationAuthenticateResponse>("post", $"/lol-account-verification/v1/authenticate", AuthenticateRequest);
        public static Task<LolAccountVerificationDeviceResponse> GetLolAccountVerificationV1Device()
            => Sender.Request<LolAccountVerificationDeviceResponse>("get", $"/lol-account-verification/v1/device");
        public static Task<LolAccountVerificationInvalidateResponse> PostLolAccountVerificationV1Invalidate()
            => Sender.Request<LolAccountVerificationInvalidateResponse>("post", $"/lol-account-verification/v1/invalidate");
        public static Task<LolAccountVerificationIsVerifiedResponse> GetLolAccountVerificationV1IsVerified()
            => Sender.Request<LolAccountVerificationIsVerifiedResponse>("get", $"/lol-account-verification/v1/is-verified");
        public static Task<LolAccountVerificationSendTokenResponse> PostLolAccountVerificationV1SendToken([Parameter("SendTokenRequest", "body")] LolAccountVerificationSendTokenRequest SendTokenRequest)
            => Sender.Request<LolAccountVerificationSendTokenResponse>("post", $"/lol-account-verification/v1/send-token", SendTokenRequest);
        public static Task<LolAccountVerificationVerifyResponse> PostLolAccountVerificationV1Verify([Parameter("VerifyRequest", "body")] LolAccountVerificationVerifyRequest VerifyRequest)
            => Sender.Request<LolAccountVerificationVerifyResponse>("post", $"/lol-account-verification/v1/verify", VerifyRequest);
    }
}
