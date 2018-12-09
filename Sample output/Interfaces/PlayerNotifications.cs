using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class PlayerNotifications
    {
        public static Task<PlayerNotificationsPlayerNotificationConfigResource> GetPlayerNotificationsV1Config()
            => Sender.Request<PlayerNotificationsPlayerNotificationConfigResource>("get", $"/player-notifications/v1/config");
        public static Task<PlayerNotificationsPlayerNotificationConfigResource> PutPlayerNotificationsV1Config([Parameter("config", "body")] PlayerNotificationsPlayerNotificationConfigResource config)
            => Sender.Request<PlayerNotificationsPlayerNotificationConfigResource>("put", $"/player-notifications/v1/config", config);
        public static Task<PlayerNotificationsPlayerNotificationResource[]> GetPlayerNotificationsV1Notifications()
            => Sender.Request<PlayerNotificationsPlayerNotificationResource[]>("get", $"/player-notifications/v1/notifications");
        public static Task<PlayerNotificationsPlayerNotificationResource> PostPlayerNotificationsV1Notifications([Parameter("notification", "body")] PlayerNotificationsPlayerNotificationResource notification)
            => Sender.Request<PlayerNotificationsPlayerNotificationResource>("post", $"/player-notifications/v1/notifications", notification);
        public static Task<object> DeletePlayerNotificationsV1NotificationsById([Parameter("id", "path")] long id)
            => Sender.Request<object>("delete", $"/player-notifications/v1/notifications/{id}");
        public static Task<PlayerNotificationsPlayerNotificationResource> GetPlayerNotificationsV1NotificationsById([Parameter("id", "path")] long id)
            => Sender.Request<PlayerNotificationsPlayerNotificationResource>("get", $"/player-notifications/v1/notifications/{id}");
        public static Task<PlayerNotificationsPlayerNotificationResource> PutPlayerNotificationsV1NotificationsById([Parameter("id", "path")] long id, [Parameter("notification", "body")] object notification)
            => Sender.Request<PlayerNotificationsPlayerNotificationResource>("put", $"/player-notifications/v1/notifications/{id}", notification);
    }
}
