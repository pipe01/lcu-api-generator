using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolServiceStatus
    {
        public static Task<LolServiceStatusServiceStatusResource> GetLolServiceStatusV1LcuStatus()
            => Sender.Request<LolServiceStatusServiceStatusResource>("get", $"/lol-service-status/v1/lcu-status");
        public static Task<LolServiceStatusTickerMessage[]> GetLolServiceStatusV1TickerMessages()
            => Sender.Request<LolServiceStatusTickerMessage[]>("get", $"/lol-service-status/v1/ticker-messages");
    }
}
