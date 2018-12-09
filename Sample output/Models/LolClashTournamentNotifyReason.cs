using Newtonsoft.Json;

namespace LCU_API_Generator
{
    public enum LolClashTournamentNotifyReason
    {
        NEW_TOURNAMENT,
        UPDATE_TOURNAMENT,
        CANCEL_TOURNAMENT,
        CANCEL_PERIOD,
        ADD_PHASE,
        UPDATE_PHASE,
        REVERT_PHASE,
    }
}
