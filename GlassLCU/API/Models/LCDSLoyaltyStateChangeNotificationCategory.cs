using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LCDSLoyaltyStateChangeNotificationCategory
    {
        Legacy,
        Grant,
        Expiry,
        Change,
        Revoke,
        Disabled,
    }
}
