using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolReplays
    {
        public static Task<LolReplaysReplaysConfiguration> GetLolReplaysV1Configuration()
            => Sender.Request<LolReplaysReplaysConfiguration>("get", $"/lol-replays/v1/configuration");
        public static Task<LolReplaysReplayMetadata> GetLolReplaysV1MetadataByGameId([Parameter("gameId", "path")] long gameId)
            => Sender.Request<LolReplaysReplayMetadata>("get", $"/lol-replays/v1/metadata/{gameId}");
        public static Task PostLolReplaysV1MetadataByGameIdCreateGameVersionByGameVersionGameTypeByGameTypeQueueIdByQueueId([Parameter("gameId", "path")] long gameId, [Parameter("gameVersion", "path")] string gameVersion, [Parameter("gameType", "path")] string gameType, [Parameter("queueId", "path")] int queueId)
            => Sender.Request("post", $"/lol-replays/v1/metadata/{gameId}/create/gameVersion/{gameVersion}/gameType/{gameType}/queueId/{queueId}");
        public static Task<string> GetLolReplaysV1RoflsPath()
            => Sender.Request<string>("get", $"/lol-replays/v1/rofls/path");
        public static Task<string> GetLolReplaysV1RoflsPathDefault()
            => Sender.Request<string>("get", $"/lol-replays/v1/rofls/path/default");
        public static Task PostLolReplaysV1RoflsScan()
            => Sender.Request("post", $"/lol-replays/v1/rofls/scan");
        public static Task PostLolReplaysV1RoflsByGameIdDownload([Parameter("gameId", "path")] long gameId, [Parameter("contextData", "body")] LolReplaysReplayContextData contextData)
            => Sender.Request("post", $"/lol-replays/v1/rofls/{gameId}/download", contextData);
        public static Task PostLolReplaysV1RoflsByGameIdDownloadGraceful([Parameter("gameId", "path")] long gameId, [Parameter("contextData", "body")] LolReplaysReplayContextData contextData)
            => Sender.Request("post", $"/lol-replays/v1/rofls/{gameId}/download/graceful", contextData);
        public static Task PostLolReplaysV1RoflsByGameIdWatch([Parameter("gameId", "path")] long gameId, [Parameter("contextData", "body")] LolReplaysReplayContextData contextData)
            => Sender.Request("post", $"/lol-replays/v1/rofls/{gameId}/watch", contextData);
        public static Task PostLolReplaysV2MetadataByGameIdCreate([Parameter("gameId", "path")] long gameId, [Parameter("request", "body")] LolReplaysReplayCreateMetadata request)
            => Sender.Request("post", $"/lol-replays/v2/metadata/{gameId}/create", request);
    }
}
