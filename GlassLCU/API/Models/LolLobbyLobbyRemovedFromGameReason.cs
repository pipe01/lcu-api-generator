using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolLobbyLobbyRemovedFromGameReason
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
