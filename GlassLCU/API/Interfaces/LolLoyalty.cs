using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolLoyalty
    {
        public static Task<LolLoyaltyLoyaltyStatusNotification> GetLolLoyaltyV1StatusNotification()
            => Sender.Request<LolLoyaltyLoyaltyStatusNotification>("get", $"/lol-loyalty/v1/status-notification");
    }
}
