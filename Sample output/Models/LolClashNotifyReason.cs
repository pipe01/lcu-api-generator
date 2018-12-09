using Newtonsoft.Json;

namespace LCU_API_Generator
{
    public enum LolClashNotifyReason
    {
        SUGGESTION,
        DECLINE_SUGGESTION,
        ACCEPT_SUGGESTION,
        REVOKE_SUGGESTION,
        READY,
        UNREADY,
        OWNER_CLOSE,
        DISMISS,
        OWNER_TRANSFER,
        CHANGE_LOGO,
        CHANGE_NAME,
        CHANGE_SHORTNAME,
        CHANGE_POSITION,
        CHANGE_NAMETAGLOGO,
        INVITE,
        RESENT_INVITE,
        DECLINE_INVITE,
        ACCEPT_INVITE,
        REVOKE_INVITE,
        LEAVE,
        CAPTAIN_LEAVE,
        KICK,
        SET_TICKET,
        OFFER_TICKET,
        REVOKED_TICKET,
        DECLINE_TICKET,
        ACCEPT_TICKET,
        REWARD_GRANT_FAILED,
        REWARD_GRANT_RETRY,
        REVERTED_REGISTRATION,
    }
}
