using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolLobbyTeamBuilderLobbyRemovedFromGameReason
    {
        None,
        Kicked,
        Disbanded,
        Left,
        ServiceError,
        Other,
        Timeout,
        GameStartError,
        ServiceShutdown,
    }
}
