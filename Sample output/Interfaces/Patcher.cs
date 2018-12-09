using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class Patcher
    {
        public static Task<string> GetPatcherV1ExecutableVersion()
            => Sender.Request<string>("get", $"/patcher/v1/executable-version");
        public static Task<PatcherNotification[]> GetPatcherV1Notifications()
            => Sender.Request<PatcherNotification[]>("get", $"/patcher/v1/notifications");
        public static Task PostPatcherV1Notifications([Parameter("notificationId", "query")] string notificationId)
            => Sender.Request("post", $"/patcher/v1/notifications?notificationId={System.Net.WebUtility.UrlEncode(notificationId.ToString())}");
        public static Task<object> DeletePatcherV1NotificationsById([Parameter("id", "path")] string id)
            => Sender.Request<object>("delete", $"/patcher/v1/notifications/{id}");
        public static Task<PatcherP2PStatus> GetPatcherV1P2pStatus()
            => Sender.Request<PatcherP2PStatus>("get", $"/patcher/v1/p2p/status");
        public static Task<object> PatchPatcherV1P2pStatus([Parameter("data", "body")] PatcherP2PStatusUpdate data)
            => Sender.Request<object>("patch", $"/patcher/v1/p2p/status", data);
        public static Task<string[]> GetPatcherV1Products()
            => Sender.Request<string[]>("get", $"/patcher/v1/products");
        public static Task<object> PostPatcherV1ProductsLeagueOfLegendsFullRepairRequest()
            => Sender.Request<object>("post", $"/patcher/v1/products/league_of_legends/full-repair-request");
        public static Task<object> DeletePatcherV1ProductsByProductId([Parameter("product-id", "path")] string productId)
            => Sender.Request<object>("delete", $"/patcher/v1/products/{productId}");
        public static Task<object> PutPatcherV1ProductsByProductId([Parameter("product-id", "path")] string productId, [Parameter("data", "body")] PatcherProductResource data)
            => Sender.Request<object>("put", $"/patcher/v1/products/{productId}", data);
        public static Task<PatcherProductState> PostPatcherV1ProductsByProductIdDetectCorruptionRequest([Parameter("product-id", "path")] string productId)
            => Sender.Request<PatcherProductState>("post", $"/patcher/v1/products/{productId}/detect-corruption-request");
        public static Task PostPatcherV1ProductsByProductIdInjectError([Parameter("product-id", "path")] string productId, [Parameter("component-id", "query")] string componentId, [Parameter("error", "query")] string error)
            => Sender.Request("post", $"/patcher/v1/products/{productId}/inject-error?component-id={System.Net.WebUtility.UrlEncode(componentId.ToString())}&error={System.Net.WebUtility.UrlEncode(error.ToString())}");
        public static Task<object> PostPatcherV1ProductsByProductIdPartialRepairRequest([Parameter("product-id", "path")] string productId)
            => Sender.Request<object>("post", $"/patcher/v1/products/{productId}/partial-repair-request");
        public static Task<object> GetPatcherV1ProductsByProductIdPaths([Parameter("product-id", "path")] string productId)
            => Sender.Request<object>("get", $"/patcher/v1/products/{productId}/paths");
        public static Task<object> PostPatcherV1ProductsByProductIdSignalStartPatchingDelayed([Parameter("product-id", "path")] string productId)
            => Sender.Request<object>("post", $"/patcher/v1/products/{productId}/signal-start-patching-delayed");
        public static Task<object> PostPatcherV1ProductsByProductIdStartCheckingRequest([Parameter("product-id", "path")] string productId)
            => Sender.Request<object>("post", $"/patcher/v1/products/{productId}/start-checking-request");
        public static Task<object> PostPatcherV1ProductsByProductIdStartPatchingRequest([Parameter("product-id", "path")] string productId)
            => Sender.Request<object>("post", $"/patcher/v1/products/{productId}/start-patching-request");
        public static Task<PatcherProductState> GetPatcherV1ProductsByProductIdState([Parameter("product-id", "path")] string productId)
            => Sender.Request<PatcherProductState>("get", $"/patcher/v1/products/{productId}/state");
        public static Task<object> PostPatcherV1ProductsByProductIdStopCheckingRequest([Parameter("product-id", "path")] string productId)
            => Sender.Request<object>("post", $"/patcher/v1/products/{productId}/stop-checking-request");
        public static Task<object> PostPatcherV1ProductsByProductIdStopPatchingRequest([Parameter("product-id", "path")] string productId)
            => Sender.Request<object>("post", $"/patcher/v1/products/{productId}/stop-patching-request");
        public static Task<object> GetPatcherV1ProductsByProductIdTags([Parameter("product-id", "path")] string productId)
            => Sender.Request<object>("get", $"/patcher/v1/products/{productId}/tags");
        public static Task<object> DeletePatcherV1ProductsByProductIdByComponentIdHttpHeaders([Parameter("product-id", "path")] string productId, [Parameter("component-id", "path")] string componentId)
            => Sender.Request<object>("delete", $"/patcher/v1/products/{productId}/{componentId}/http-headers");
        public static Task<object> PutPatcherV1ProductsByProductIdByComponentIdHttpHeaders([Parameter("product-id", "path")] string productId, [Parameter("component-id", "path")] string componentId, [Parameter("headers", "body")] PatcherHeaderEntry[] headers)
            => Sender.Request<object>("put", $"/patcher/v1/products/{productId}/{componentId}/http-headers", headers);
        public static Task<object> PutPatcherV1SelfUpdateRestart([Parameter("forceRestartOnSelfUpdate", "query")] bool forceRestartOnSelfUpdate)
            => Sender.Request<object>("put", $"/patcher/v1/self-update-restart?forceRestartOnSelfUpdate={System.Net.WebUtility.UrlEncode(forceRestartOnSelfUpdate.ToString())}");
        public static Task<PatcherStatus> GetPatcherV1Status()
            => Sender.Request<PatcherStatus>("get", $"/patcher/v1/status");
    }
}
