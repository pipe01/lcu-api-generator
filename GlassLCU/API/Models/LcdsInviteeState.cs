using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LcdsInviteeState
    {
        CREATOR,
        PENDING,
        DECLINED,
        ACCEPTED,
        ACCEPT_FAILED,
        JOINED,
        QUIT,
        KICKED,
        BANNED,
    }
}
