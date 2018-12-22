using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolPlayerMessaging
    {
        public static Task<LolPlayerMessagingDynamicCelebrationMessagingNotificationResource> GetLolPlayerMessagingV1CelebrationNotification()
            => Sender.Request<LolPlayerMessagingDynamicCelebrationMessagingNotificationResource>("get", $"/lol-player-messaging/v1/celebration/notification");
        public static Task<object> DeleteLolPlayerMessagingV1CelebrationNotificationByIdAcknowledge([Parameter("id", "path")] int id)
            => Sender.Request<object>("delete", $"/lol-player-messaging/v1/celebration/notification/{id}/acknowledge");
        public static Task<LolPlayerMessagingPlayerMessagingNotificationResource> GetLolPlayerMessagingV1Notification()
            => Sender.Request<LolPlayerMessagingPlayerMessagingNotificationResource>("get", $"/lol-player-messaging/v1/notification");
        public static Task<object> DeleteLolPlayerMessagingV1NotificationByIdAcknowledge([Parameter("id", "path")] int id)
            => Sender.Request<object>("delete", $"/lol-player-messaging/v1/notification/{id}/acknowledge");
    }
}
