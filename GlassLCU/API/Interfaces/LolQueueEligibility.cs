using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolQueueEligibility
    {
        public static Task<LolQueueEligibilityEligibility[]> PostLolQueueEligibilityV1Eligibility([Parameter("eligibilityQueryParam", "body")] LolQueueEligibilityEligibilityQueryParams eligibilityQueryParam)
            => Sender.Request<LolQueueEligibilityEligibility[]>("post", $"/lol-queue-eligibility/v1/eligibility", eligibilityQueryParam);
        public static Task<bool> GetLolQueueEligibilityV1InitialConfigurationComplete()
            => Sender.Request<bool>("get", $"/lol-queue-eligibility/v1/initial-configuration-complete");
        public static Task<LolQueueEligibilityEligibility[]> PostLolQueueEligibilityV2Eligibility([Parameter("eligibilityQueryParam", "body")] LolQueueEligibilityEligibilityQueryParams eligibilityQueryParam)
            => Sender.Request<LolQueueEligibilityEligibility[]>("post", $"/lol-queue-eligibility/v2/eligibility", eligibilityQueryParam);
        public static Task<LolQueueEligibilityEligibility[]> GetLolQueueEligibilityV3Custom([Parameter("teamSize", "query")] int teamSize, [Parameter("pickMode", "query")] string pickMode)
            => Sender.Request<LolQueueEligibilityEligibility[]>("get", $"/lol-queue-eligibility/v3/custom?teamSize={System.Net.WebUtility.UrlEncode(teamSize.ToString())}&pickMode={System.Net.WebUtility.UrlEncode(pickMode.ToString())}");
        public static Task<LolQueueEligibilityEligibility[]> GetLolQueueEligibilityV3Eligibility([Parameter("summonerIds", "query")] long[] summonerIds, [Parameter("queueIds", "query")] int[] queueIds)
            => Sender.Request<LolQueueEligibilityEligibility[]>("get", $"/lol-queue-eligibility/v3/eligibility?summonerIds={System.Net.WebUtility.UrlEncode(summonerIds.ToString())}&queueIds={System.Net.WebUtility.UrlEncode(queueIds.ToString())}");
    }
}
