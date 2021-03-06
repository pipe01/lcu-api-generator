//Auto-generated by https://github.com/pipe01/lcu-api-generator
using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;
using System.Reflection;

namespace GlassLCU.API.Interfaces
{
    public static class LolServiceStatus
    {
        /// <summary>
        /// <para>GET /lol-service-status/v1/lcu-status</para>
        /// </summary>
        [Endpoint("/lol-service-status/v1/lcu-status")]
        public static Task<LolServiceStatusServiceStatusResource> GetLolServiceStatusV1LcuStatus()
            => Sender.Request<LolServiceStatusServiceStatusResource>("get", $"/lol-service-status/v1/lcu-status");
        /// <summary>
        /// <para>GET /lol-service-status/v1/ticker-messages</para>
        /// </summary>
        [Endpoint("/lol-service-status/v1/ticker-messages")]
        public static Task<LolServiceStatusTickerMessage[]> GetLolServiceStatusV1TickerMessages()
            => Sender.Request<LolServiceStatusTickerMessage[]>("get", $"/lol-service-status/v1/ticker-messages");

        public static string GetURL(string methodName)
        {
            return typeof(LolServiceStatus).GetMethod(methodName).GetCustomAttribute<EndpointAttribute>().URL;
        }
    }
}
