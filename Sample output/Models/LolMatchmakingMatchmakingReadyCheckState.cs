using Newtonsoft.Json;

namespace LCU_API_Generator
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
