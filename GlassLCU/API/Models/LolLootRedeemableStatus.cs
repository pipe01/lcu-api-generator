using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolLootRedeemableStatus
    {
        UNKNOWN,
        REDEEMABLE,
        REDEEMABLE_RENTAL,
        NOT_REDEEMABLE,
        NOT_REDEEMABLE_RENTAL,
        ALREADY_OWNED,
        ALREADY_RENTED,
        CHAMPION_NOT_OWNED,
        SKIN_NOT_OWNED,
    }
}
