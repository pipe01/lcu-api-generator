using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolGameClientChat
    {
        public static Task<string[]> GetLolGameClientChatV1Buddies()
            => Sender.Request<string[]>("get", $"/lol-game-client-chat/v1/buddies");
        public static Task DeleteLolGameClientChatV1IgnoredSummoners([Parameter("summonerName", "query")] string summonerName)
            => Sender.Request("delete", $"/lol-game-client-chat/v1/ignored-summoners?summonerName={System.Net.WebUtility.UrlEncode(summonerName.ToString())}");
        public static Task<string[]> GetLolGameClientChatV1IgnoredSummoners()
            => Sender.Request<string[]>("get", $"/lol-game-client-chat/v1/ignored-summoners");
        public static Task PostLolGameClientChatV1IgnoredSummoners([Parameter("summonerName", "query")] string summonerName)
            => Sender.Request("post", $"/lol-game-client-chat/v1/ignored-summoners?summonerName={System.Net.WebUtility.UrlEncode(summonerName.ToString())}");
        public static Task PostLolGameClientChatV1InstantMessages([Parameter("summonerName", "query")] string summonerName, [Parameter("message", "query")] string message)
            => Sender.Request("post", $"/lol-game-client-chat/v1/instant-messages?summonerName={System.Net.WebUtility.UrlEncode(summonerName.ToString())}&message={System.Net.WebUtility.UrlEncode(message.ToString())}");
        public static Task PostLolGameClientChatV1PartyMessages([Parameter("message", "query")] string message)
            => Sender.Request("post", $"/lol-game-client-chat/v1/party-messages?message={System.Net.WebUtility.UrlEncode(message.ToString())}");
    }
}
