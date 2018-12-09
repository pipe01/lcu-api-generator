using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolLogin
    {
        public static Task<object> PostLolLoginV1AccessToken([Parameter("AccessToken", "body")] LolLoginAccessToken AccessToken)
            => Sender.Request<object>("post", $"/lol-login/v1/access-token", AccessToken);
        public static Task<LolLoginAccountStateResource> GetLolLoginV1AccountState()
            => Sender.Request<LolLoginAccountStateResource>("get", $"/lol-login/v1/account-state");
        public static Task PostLolLoginV1AccountState()
            => Sender.Request("post", $"/lol-login/v1/account-state");
        public static Task<object> PostLolLoginV1ChangeSummonerName([Parameter("name", "body")] string name)
            => Sender.Request<object>("post", $"/lol-login/v1/change-summoner-name", name);
        public static Task<object> GetLolLoginV1LoginDataPacket()
            => Sender.Request<object>("get", $"/lol-login/v1/login-data-packet");
        public static Task<object> GetLolLoginV1LoginInGameCreds()
            => Sender.Request<object>("get", $"/lol-login/v1/login-in-game-creds");
        public static Task<LolLoginPlatformGeneratedCredentials> GetLolLoginV1LoginPlatformCredentials()
            => Sender.Request<LolLoginPlatformGeneratedCredentials>("get", $"/lol-login/v1/login-platform-credentials");
        public static Task<object> PostLolLoginV1NewPlayerFlowCompleted()
            => Sender.Request<object>("post", $"/lol-login/v1/new-player-flow-completed");
        public static Task DeleteLolLoginV1ServiceProxyAsyncRequestsByServiceNameByMethodName([Parameter("serviceName", "path")] string serviceName, [Parameter("methodName", "path")] string methodName, [Parameter("pluginId", "query")] int pluginId)
            => Sender.Request("delete", $"/lol-login/v1/service-proxy-async-requests/{serviceName}/{methodName}?pluginId={System.Net.WebUtility.UrlEncode(pluginId.ToString())}");
        public static Task PostLolLoginV1ServiceProxyAsyncRequestsByServiceNameByMethodName([Parameter("serviceName", "path")] string serviceName, [Parameter("methodName", "path")] string methodName, [Parameter("pluginId", "query")] int pluginId)
            => Sender.Request("post", $"/lol-login/v1/service-proxy-async-requests/{serviceName}/{methodName}?pluginId={System.Net.WebUtility.UrlEncode(pluginId.ToString())}");
        public static Task PostLolLoginV1ServiceProxyMethodRequests([Parameter("serviceName", "query")] string serviceName, [Parameter("methodName", "query")] string methodName, [Parameter("responseMethodName", "query")] string responseMethodName, [Parameter("responseErrorName", "query")] string responseErrorName, [Parameter("pluginId", "query")] int pluginId, [Parameter("payload", "query")] string payload)
            => Sender.Request("post", $"/lol-login/v1/service-proxy-method-requests?serviceName={System.Net.WebUtility.UrlEncode(serviceName.ToString())}&methodName={System.Net.WebUtility.UrlEncode(methodName.ToString())}&responseMethodName={System.Net.WebUtility.UrlEncode(responseMethodName.ToString())}&responseErrorName={System.Net.WebUtility.UrlEncode(responseErrorName.ToString())}&pluginId={System.Net.WebUtility.UrlEncode(pluginId.ToString())}&payload={System.Net.WebUtility.UrlEncode(payload.ToString())}");
        public static Task<string> PostLolLoginV1ServiceProxyUuidRequests([Parameter("serviceName", "query")] string serviceName, [Parameter("methodName", "query")] string methodName, [Parameter("pluginId", "query")] int pluginId, [Parameter("payload", "query")] string payload)
            => Sender.Request<string>("post", $"/lol-login/v1/service-proxy-uuid-requests?serviceName={System.Net.WebUtility.UrlEncode(serviceName.ToString())}&methodName={System.Net.WebUtility.UrlEncode(methodName.ToString())}&pluginId={System.Net.WebUtility.UrlEncode(pluginId.ToString())}&payload={System.Net.WebUtility.UrlEncode(payload.ToString())}");
        public static Task DeleteLolLoginV1Session()
            => Sender.Request("delete", $"/lol-login/v1/session");
        public static Task<LolLoginLoginSession> GetLolLoginV1Session()
            => Sender.Request<LolLoginLoginSession>("get", $"/lol-login/v1/session");
        public static Task<LolLoginLoginSession> PostLolLoginV1Session([Parameter("UsernameAndPassword", "body")] LolLoginUsernameAndPassword UsernameAndPassword)
            => Sender.Request<LolLoginLoginSession>("post", $"/lol-login/v1/session", UsernameAndPassword);
        public static Task<LolLoginLcdsResponse> PostLolLoginV1SessionInvoke([Parameter("destination", "query")] string destination, [Parameter("method", "query")] string method, [Parameter("args", "formData")] string args)
            => Sender.Request<LolLoginLcdsResponse>("post", $"/lol-login/v1/session/invoke?destination={System.Net.WebUtility.UrlEncode(destination.ToString())}&method={System.Net.WebUtility.UrlEncode(method.ToString())}");
        public static Task DeleteLolLoginV1ShutdownLocksByLockName([Parameter("lockName", "path")] string lockName)
            => Sender.Request("delete", $"/lol-login/v1/shutdown-locks/{lockName}");
        public static Task PutLolLoginV1ShutdownLocksByLockName([Parameter("lockName", "path")] string lockName)
            => Sender.Request("put", $"/lol-login/v1/shutdown-locks/{lockName}");
        public static Task<object> PostLolLoginV1SummonerCreated([Parameter("summonerId", "body")] LolLoginSummonerCreatedResource summonerId)
            => Sender.Request<object>("post", $"/lol-login/v1/summoner-created", summonerId);
        public static Task<LolLoginLoginSessionWallet> GetLolLoginV1Wallet()
            => Sender.Request<LolLoginLoginSessionWallet>("get", $"/lol-login/v1/wallet");
    }
}
