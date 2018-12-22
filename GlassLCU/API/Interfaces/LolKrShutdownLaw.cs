using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolKrShutdownLaw
    {
        public static Task<LolKrShutdownLawQueueShutdownStatus> GetLolKrShutdownLawV1CustomStatus()
            => Sender.Request<LolKrShutdownLawQueueShutdownStatus>("get", $"/lol-kr-shutdown-law/v1/custom-status");
        public static Task<int[]> GetLolKrShutdownLawV1DisabledQueues()
            => Sender.Request<int[]>("get", $"/lol-kr-shutdown-law/v1/disabled-queues");
        public static Task<LolKrShutdownLawShutdownLawNotification> GetLolKrShutdownLawV1Notification()
            => Sender.Request<LolKrShutdownLawShutdownLawNotification>("get", $"/lol-kr-shutdown-law/v1/notification");
        public static Task<LolKrShutdownLawQueueShutdownStatus> GetLolKrShutdownLawV1QueueStatusByQueueId([Parameter("queue_id", "path")] int queue_id)
            => Sender.Request<LolKrShutdownLawQueueShutdownStatus>("get", $"/lol-kr-shutdown-law/v1/queue-status/{queue_id}");
        public static Task<LolKrShutdownLawAllQueueShutdownStatus> GetLolKrShutdownLawV1Status()
            => Sender.Request<LolKrShutdownLawAllQueueShutdownStatus>("get", $"/lol-kr-shutdown-law/v1/status");
    }
}
