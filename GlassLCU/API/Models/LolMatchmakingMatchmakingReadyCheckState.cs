using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolMatchmakingMatchmakingReadyCheckState
    {
        Invalid,
        InProgress,
        EveryoneReady,
        StrangerNotReady,
        PartyNotReady,
        Error,
    }
}
