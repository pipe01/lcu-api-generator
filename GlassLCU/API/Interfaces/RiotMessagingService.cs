using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class RiotMessagingService
    {
        public static Task DeleteRiotMessagingServiceV1Connect()
            => Sender.Request("delete", $"/riot-messaging-service/v1/connect");
        public static Task PostRiotMessagingServiceV1Connect([Parameter("idToken", "body")] string idToken)
            => Sender.Request("post", $"/riot-messaging-service/v1/connect", idToken);
        public static Task DeleteRiotMessagingServiceV1Entitlements()
            => Sender.Request("delete", $"/riot-messaging-service/v1/entitlements");
        public static Task PostRiotMessagingServiceV1Entitlements([Parameter("token", "body")] RiotMessagingServiceEntitlementsToken token)
            => Sender.Request("post", $"/riot-messaging-service/v1/entitlements", token);
        public static Task PostRiotMessagingServiceV1Reconnect()
            => Sender.Request("post", $"/riot-messaging-service/v1/reconnect");
        public static Task DeleteRiotMessagingServiceV1Session()
            => Sender.Request("delete", $"/riot-messaging-service/v1/session");
        public static Task<RiotMessagingServiceSession> GetRiotMessagingServiceV1Session()
            => Sender.Request<RiotMessagingServiceSession>("get", $"/riot-messaging-service/v1/session");
        public static Task<RiotMessagingServiceState> GetRiotMessagingServiceV1State()
            => Sender.Request<RiotMessagingServiceState>("get", $"/riot-messaging-service/v1/state");
    }
}
