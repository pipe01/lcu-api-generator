using Newtonsoft.Json;

namespace LCU_API_Generator
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
