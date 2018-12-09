using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolEmailVerification
    {
        public static Task<object> PostLolEmailVerificationV1ConfirmEmail()
            => Sender.Request<object>("post", $"/lol-email-verification/v1/confirm-email");
        public static Task<LolEmailVerificationEmailVerificationSession> GetLolEmailVerificationV1Email()
            => Sender.Request<LolEmailVerificationEmailVerificationSession>("get", $"/lol-email-verification/v1/email");
        public static Task<object> PutLolEmailVerificationV1Email([Parameter("EmailUpdate", "body")] LolEmailVerificationEmailUpdate EmailUpdate)
            => Sender.Request<object>("put", $"/lol-email-verification/v1/email", EmailUpdate);
    }
}
