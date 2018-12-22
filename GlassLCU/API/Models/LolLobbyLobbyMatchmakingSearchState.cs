using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
