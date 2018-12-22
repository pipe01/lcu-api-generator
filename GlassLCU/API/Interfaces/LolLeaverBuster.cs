using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolLeaverBuster
    {
        public static Task<LolLeaverBusterLeaverBusterNotificationResource[]> GetLolLeaverBusterV1Notifications()
            => Sender.Request<LolLeaverBusterLeaverBusterNotificationResource[]>("get", $"/lol-leaver-buster/v1/notifications");
        public static Task<object> DeleteLolLeaverBusterV1NotificationsById([Parameter("id", "path")] int id)
            => Sender.Request<object>("delete", $"/lol-leaver-buster/v1/notifications/{id}");
        public static Task<LolLeaverBusterLeaverBusterNotificationResource> GetLolLeaverBusterV1NotificationsById([Parameter("id", "path")] int id)
            => Sender.Request<LolLeaverBusterLeaverBusterNotificationResource>("get", $"/lol-leaver-buster/v1/notifications/{id}");
    }
}
