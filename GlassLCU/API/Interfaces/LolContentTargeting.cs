using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolContentTargeting
    {
        public static Task<LolContentTargetingContentTargetingFilterResponse> GetLolContentTargetingV1Filters()
            => Sender.Request<LolContentTargetingContentTargetingFilterResponse>("get", $"/lol-content-targeting/v1/filters");
        public static Task<LolContentTargetingContentTargetingLocaleResponse> GetLolContentTargetingV1Locale()
            => Sender.Request<LolContentTargetingContentTargetingLocaleResponse>("get", $"/lol-content-targeting/v1/locale");
    }
}
