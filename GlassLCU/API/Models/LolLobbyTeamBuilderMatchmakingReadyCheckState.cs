using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
