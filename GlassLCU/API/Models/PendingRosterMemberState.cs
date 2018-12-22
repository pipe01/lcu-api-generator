using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum PendingRosterMemberState
    {
        NOT_READY,
        FORCED_NOT_READY,
        READY,
        LEFT,
        KICK,
    }
}
