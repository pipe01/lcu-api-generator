using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolServiceStatus
    {
        public static Task<LolServiceStatusServiceStatusResource> GetLolServiceStatusV1LcuStatus()
            => Sender.Request<LolServiceStatusServiceStatusResource>("get", $"/lol-service-status/v1/lcu-status");
        public static Task<LolServiceStatusTickerMessage[]> GetLolServiceStatusV1TickerMessages()
            => Sender.Request<LolServiceStatusTickerMessage[]>("get", $"/lol-service-status/v1/ticker-messages");
    }
}
