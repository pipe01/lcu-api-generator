using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
