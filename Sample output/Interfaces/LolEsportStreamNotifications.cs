using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolEsportStreamNotifications
    {
        public static Task<LolEsportStreamNotificationsESportsLiveStreams> GetLolEsportStreamNotificationsV1LiveStreams()
            => Sender.Request<LolEsportStreamNotificationsESportsLiveStreams>("get", $"/lol-esport-stream-notifications/v1/live-streams");
        public static Task PostLolEsportStreamNotificationsV1SendStats([Parameter("eventType", "path")] string eventType, [Parameter("matchId", "path")] string matchId)
            => Sender.Request("post", $"/lol-esport-stream-notifications/v1/send-stats");
        public static Task<string> GetLolEsportStreamNotificationsV1StreamUrl()
            => Sender.Request<string>("get", $"/lol-esport-stream-notifications/v1/stream-url");
    }
}
