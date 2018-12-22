using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class RsoAuth
    {
        public static Task DeleteRsoAuthV1Authorization()
            => Sender.Request("delete", $"/rso-auth/v1/authorization");
        public static Task<RsoAuthAuthorization> GetRsoAuthV1Authorization()
            => Sender.Request<RsoAuthAuthorization>("get", $"/rso-auth/v1/authorization");
        public static Task<RsoAuthAccessToken> GetRsoAuthV1AuthorizationAccessToken()
            => Sender.Request<RsoAuthAccessToken>("get", $"/rso-auth/v1/authorization/access-token");
        public static Task<RsoAuthEntitlementsToken> GetRsoAuthV1AuthorizationEntitlementsToken()
            => Sender.Request<RsoAuthEntitlementsToken>("get", $"/rso-auth/v1/authorization/entitlements-token");
        public static Task<RsoAuthAuthError> GetRsoAuthV1AuthorizationError()
            => Sender.Request<RsoAuthAuthError>("get", $"/rso-auth/v1/authorization/error");
        public static Task<RsoAuthAuthorization> PostRsoAuthV1AuthorizationGas([Parameter("creds", "body")] RsoAuthRSOPlayerCredentials creds)
            => Sender.Request<RsoAuthAuthorization>("post", $"/rso-auth/v1/authorization/gas", creds);
        public static Task<object> GetRsoAuthV1AuthorizationGasToken()
            => Sender.Request<object>("get", $"/rso-auth/v1/authorization/gas-token");
        public static Task<RsoAuthIdToken> GetRsoAuthV1AuthorizationIdToken()
            => Sender.Request<RsoAuthIdToken>("get", $"/rso-auth/v1/authorization/id-token");
        public static Task<RsoAuthAuthorization> PostRsoAuthV1AuthorizationRefresh()
            => Sender.Request<RsoAuthAuthorization>("post", $"/rso-auth/v1/authorization/refresh");
        public static Task<RsoAuthUserInfo> GetRsoAuthV1AuthorizationUserinfo()
            => Sender.Request<RsoAuthUserInfo>("get", $"/rso-auth/v1/authorization/userinfo");
        public static Task<RsoAuthUserInfo> PostRsoAuthV1AuthorizationUserinfo()
            => Sender.Request<RsoAuthUserInfo>("post", $"/rso-auth/v1/authorization/userinfo");
        public static Task DeleteRsoAuthV1Config()
            => Sender.Request("delete", $"/rso-auth/v1/config");
        public static Task PostRsoAuthV1Config([Parameter("config", "body")] RsoAuthRSOJWTConfig config)
            => Sender.Request("post", $"/rso-auth/v1/config", config);
        public static Task PutRsoAuthV1Config([Parameter("config", "body")] RsoAuthRSOJWTConfig config)
            => Sender.Request("put", $"/rso-auth/v1/config", config);
        public static Task<RsoAuthRSOJWTConfig> GetRsoAuthV1ConfigByPlatformId([Parameter("platformId", "path")] string platformId)
            => Sender.Request<RsoAuthRSOJWTConfig>("get", $"/rso-auth/v1/config/{platformId}");
        public static Task<RsoAuthDeviceId> PostRsoAuthV1DeviceId()
            => Sender.Request<RsoAuthDeviceId>("post", $"/rso-auth/v1/device-id");
        public static Task<RsoAuthRegionStatus> GetRsoAuthV1StatusByPlatformId([Parameter("platformId", "path")] string platformId)
            => Sender.Request<RsoAuthRegionStatus>("get", $"/rso-auth/v1/status/{platformId}");
        public static Task DeleteRsoAuthV2Config()
            => Sender.Request("delete", $"/rso-auth/v2/config");
        public static Task PostRsoAuthV2Config([Parameter("config", "body")] RsoAuthPublicClientConfig config)
            => Sender.Request("post", $"/rso-auth/v2/config", config);
    }
}
