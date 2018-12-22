using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolClashMatchmakingReadyCheckState
    {
        Invalid,
        InProgress,
        EveryoneReady,
        StrangerNotReady,
        PartyNotReady,
        Error,
    }
}
