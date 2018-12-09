using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolPatch
    {
        public static Task<LolPatchChunkingPatcherEnvironment> GetLolPatchV1Environment()
            => Sender.Request<LolPatchChunkingPatcherEnvironment>("get", $"/lol-patch/v1/environment");
        public static Task<LolPatchNotification[]> GetLolPatchV1Notifications()
            => Sender.Request<LolPatchNotification[]>("get", $"/lol-patch/v1/notifications");
        public static Task DeleteLolPatchV1NotificationsById([Parameter("id", "path")] string id)
            => Sender.Request("delete", $"/lol-patch/v1/notifications/{id}");
        public static Task PostLolPatchV1ProductsLeagueOfLegendsDetectCorruptionRequest()
            => Sender.Request("post", $"/lol-patch/v1/products/league_of_legends/detect-corruption-request");
        public static Task<LolPatchInstallPaths> GetLolPatchV1ProductsLeagueOfLegendsInstallLocation()
            => Sender.Request<LolPatchInstallPaths>("get", $"/lol-patch/v1/products/league_of_legends/install-location");
        public static Task PostLolPatchV1ProductsLeagueOfLegendsPartialRepairRequest()
            => Sender.Request("post", $"/lol-patch/v1/products/league_of_legends/partial-repair-request");
        public static Task PostLolPatchV1ProductsLeagueOfLegendsStartCheckingRequest()
            => Sender.Request("post", $"/lol-patch/v1/products/league_of_legends/start-checking-request");
        public static Task PostLolPatchV1ProductsLeagueOfLegendsStartPatchingRequest()
            => Sender.Request("post", $"/lol-patch/v1/products/league_of_legends/start-patching-request");
        public static Task<LolPatchProductState> GetLolPatchV1ProductsLeagueOfLegendsState()
            => Sender.Request<LolPatchProductState>("get", $"/lol-patch/v1/products/league_of_legends/state");
        public static Task PostLolPatchV1ProductsLeagueOfLegendsStopCheckingRequest()
            => Sender.Request("post", $"/lol-patch/v1/products/league_of_legends/stop-checking-request");
        public static Task PostLolPatchV1ProductsLeagueOfLegendsStopPatchingRequest([Parameter("restart", "query")] bool restart)
            => Sender.Request("post", $"/lol-patch/v1/products/league_of_legends/stop-patching-request?restart={System.Net.WebUtility.UrlEncode(restart.ToString())}");
        public static Task PutLolPatchV1SelfUpdateRestart([Parameter("forceRestartOnSelfUpdate", "query")] bool forceRestartOnSelfUpdate)
            => Sender.Request("put", $"/lol-patch/v1/self-update-restart?forceRestartOnSelfUpdate={System.Net.WebUtility.UrlEncode(forceRestartOnSelfUpdate.ToString())}");
    }
}
