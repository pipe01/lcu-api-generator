using Newtonsoft.Json;

namespace LCU_API_Generator
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
