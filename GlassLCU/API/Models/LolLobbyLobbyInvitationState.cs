using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolLobbyLobbyInvitationState
    {
        Requested,
        Pending,
        Accepted,
        Joined,
        Declined,
        Kicked,
        OnHold,
        Error,
    }
}
