using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolLobbyTeamBuilderMatchmakingSearchState
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
