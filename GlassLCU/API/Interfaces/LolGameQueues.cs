using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolGameQueues
    {
        public static Task<LolGameQueuesQueueCustomGame> GetLolGameQueuesV1Custom()
            => Sender.Request<LolGameQueuesQueueCustomGame>("get", $"/lol-game-queues/v1/custom");
        public static Task<LolGameQueuesQueueCustomGame> GetLolGameQueuesV1CustomNonDefault()
            => Sender.Request<LolGameQueuesQueueCustomGame>("get", $"/lol-game-queues/v1/custom-non-default");
        public static Task<LolGameQueuesQueueGameTypeConfig> GetLolGameQueuesV1GameTypeConfigByGameTypeConfigId([Parameter("gameTypeConfigId", "path")] int gameTypeConfigId)
            => Sender.Request<LolGameQueuesQueueGameTypeConfig>("get", $"/lol-game-queues/v1/game-type-config/{gameTypeConfigId}");
        public static Task<LolGameQueuesQueueGameTypeConfig> GetLolGameQueuesV1GameTypeConfigByGameTypeConfigIdMapByMapId([Parameter("gameTypeConfigId", "path")] int gameTypeConfigId, [Parameter("mapId", "path")] int mapId)
            => Sender.Request<LolGameQueuesQueueGameTypeConfig>("get", $"/lol-game-queues/v1/game-type-config/{gameTypeConfigId}/map/{mapId}");
        public static Task<LolGameQueuesQueue[]> GetLolGameQueuesV1Queues()
            => Sender.Request<LolGameQueuesQueue[]>("get", $"/lol-game-queues/v1/queues");
        public static Task<LolGameQueuesQueue> GetLolGameQueuesV1QueuesTypeByQueueType([Parameter("queueType", "path")] string queueType)
            => Sender.Request<LolGameQueuesQueue>("get", $"/lol-game-queues/v1/queues/type/{queueType}");
        public static Task<LolGameQueuesQueue> GetLolGameQueuesV1QueuesById([Parameter("id", "path")] int id)
            => Sender.Request<LolGameQueuesQueue>("get", $"/lol-game-queues/v1/queues/{id}");
    }
}
