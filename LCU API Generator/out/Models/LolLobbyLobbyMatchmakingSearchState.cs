using Newtonsoft.Json;

namespace LCU_API_Generator
{
    public enum LolLobbyLobbyMatchmakingSearchState
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
