//Auto-generated by https://github.com/pipe01/lcu-api-generator
using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;
using System.Reflection;

namespace GlassLCU.API.Interfaces
{
    public static class LolEsportStreamNotifications
    {
        /// <summary>
        /// <para>GET /lol-esport-stream-notifications/v1/live-streams</para>
        /// </summary>
        [Endpoint("/lol-esport-stream-notifications/v1/live-streams")]
        public static Task<LolEsportStreamNotificationsESportsLiveStreams> GetLolEsportStreamNotificationsV1LiveStreams()
            => Sender.Request<LolEsportStreamNotificationsESportsLiveStreams>("get", $"/lol-esport-stream-notifications/v1/live-streams");
        /// <summary>
        /// <para>POST /lol-esport-stream-notifications/v1/send-stats</para>
        /// </summary>
        [Endpoint("/lol-esport-stream-notifications/v1/send-stats")]
        public static Task PostLolEsportStreamNotificationsV1SendStats([Parameter("eventType", "path")] string eventType, [Parameter("matchId", "path")] string matchId)
            => Sender.Request("post", $"/lol-esport-stream-notifications/v1/send-stats");
        /// <summary>
        /// <para>GET /lol-esport-stream-notifications/v1/stream-url</para>
        /// </summary>
        [Endpoint("/lol-esport-stream-notifications/v1/stream-url")]
        public static Task<string> GetLolEsportStreamNotificationsV1StreamUrl()
            => Sender.Request<string>("get", $"/lol-esport-stream-notifications/v1/stream-url");

        public static string GetURL(string methodName)
        {
            return typeof(LolEsportStreamNotifications).GetMethod(methodName).GetCustomAttribute<EndpointAttribute>().URL;
        }
    }
}
