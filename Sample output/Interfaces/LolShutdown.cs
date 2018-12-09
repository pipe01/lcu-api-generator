using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolShutdown
    {
        public static Task<LolShutdownShutdownNotification> GetLolShutdownV1Notification()
            => Sender.Request<LolShutdownShutdownNotification>("get", $"/lol-shutdown/v1/notification");
    }
}
