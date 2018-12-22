using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolGameSession
    {
        public static Task GetLolGameSessionV1ClearInfo()
            => Sender.Request("get", $"/lol-game-session/v1/clearInfo");
        public static Task<LolGameSessionGameSessionResult> GetLolGameSessionV1Echo()
            => Sender.Request<LolGameSessionGameSessionResult>("get", $"/lol-game-session/v1/echo");
        public static Task<LolGameSessionGameSessionReconnect> GetLolGameSessionV1ReconnectInfo()
            => Sender.Request<LolGameSessionGameSessionReconnect>("get", $"/lol-game-session/v1/reconnectInfo");
        public static Task<LolGameSessionGameSessionResult> GetLolGameSessionV1RemoteEcho([Parameter("message", "query")] string message)
            => Sender.Request<LolGameSessionGameSessionResult>("get", $"/lol-game-session/v1/remote-echo?message={System.Net.WebUtility.UrlEncode(message.ToString())}");
    }
}
