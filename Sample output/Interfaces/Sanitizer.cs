using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class Sanitizer
    {
        public static Task<SanitizerContainsSanitizedResponse> PostSanitizerV1ContainsSanitized([Parameter("request", "body")] SanitizerContainsSanitizedRequest request)
            => Sender.Request<SanitizerContainsSanitizedResponse>("post", $"/sanitizer/v1/containsSanitized", request);
        public static Task<SanitizerSanitizeResponse> PostSanitizerV1Sanitize([Parameter("request", "body")] SanitizerSanitizeRequest request)
            => Sender.Request<SanitizerSanitizeResponse>("post", $"/sanitizer/v1/sanitize", request);
        public static Task<SanitizerSanitizerStatus> GetSanitizerV1Status()
            => Sender.Request<SanitizerSanitizerStatus>("get", $"/sanitizer/v1/status");
    }
}
