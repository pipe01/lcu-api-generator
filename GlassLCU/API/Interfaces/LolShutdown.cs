using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolShutdown
    {
        public static Task<LolShutdownShutdownNotification> GetLolShutdownV1Notification()
            => Sender.Request<LolShutdownShutdownNotification>("get", $"/lol-shutdown/v1/notification");
    }
}
