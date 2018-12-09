using Newtonsoft.Json;

namespace LCU_API_Generator
{
    public enum LolLobbyTeamBuilderMatchmakingReadyCheckState
    {
        Invalid,
        InProgress,
        EveryoneReady,
        StrangerNotReady,
        PartyNotReady,
        Error,
    }
}
