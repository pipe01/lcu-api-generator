using Newtonsoft.Json;

namespace LCU_API_Generator
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
