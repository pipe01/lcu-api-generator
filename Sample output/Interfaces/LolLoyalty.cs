using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolLoyalty
    {
        public static Task<LolLoyaltyLoyaltyStatusNotification> GetLolLoyaltyV1StatusNotification()
            => Sender.Request<LolLoyaltyLoyaltyStatusNotification>("get", $"/lol-loyalty/v1/status-notification");
    }
}
