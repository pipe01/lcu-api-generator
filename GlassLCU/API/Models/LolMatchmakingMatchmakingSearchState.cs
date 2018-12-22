using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolMatchmakingMatchmakingSearchState
    {
        Invalid,
        AbandonedLowPriorityQueue,
        Canceled,
        Searching,
        Found,
        Error,
        ServiceError,
        ServiceShutdown,
    }
}
