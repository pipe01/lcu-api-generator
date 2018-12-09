using Newtonsoft.Json;

namespace LCU_API_Generator
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
