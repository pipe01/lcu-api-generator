using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolMatchHistory
    {
        public static Task<LolMatchHistoryMatchHistoryPlayerDelta> GetLolMatchHistoryV1Delta()
            => Sender.Request<LolMatchHistoryMatchHistoryPlayerDelta>("get", $"/lol-match-history/v1/delta");
        public static Task<LolMatchHistoryMatchHistoryList> GetLolMatchHistoryV1FriendMatchlistsByAccountId([Parameter("accountId", "path")] long accountId)
            => Sender.Request<LolMatchHistoryMatchHistoryList>("get", $"/lol-match-history/v1/friend-matchlists/{accountId}");
        public static Task<LolMatchHistoryMatchHistoryTimelineFrames> GetLolMatchHistoryV1GameTimelinesByGameId([Parameter("gameId", "path")] long gameId)
            => Sender.Request<LolMatchHistoryMatchHistoryTimelineFrames>("get", $"/lol-match-history/v1/game-timelines/{gameId}");
        public static Task<LolMatchHistoryMatchHistoryGame> GetLolMatchHistoryV1GamesByGameId([Parameter("gameId", "path")] long gameId)
            => Sender.Request<LolMatchHistoryMatchHistoryGame>("get", $"/lol-match-history/v1/games/{gameId}");
        public static Task<LolMatchHistoryMatchHistoryList> GetLolMatchHistoryV1Matchlist()
            => Sender.Request<LolMatchHistoryMatchHistoryList>("get", $"/lol-match-history/v1/matchlist");
        public static Task<LolMatchHistoryRecentlyPlayedSummoner[]> GetLolMatchHistoryV1RecentlyPlayedSummoners()
            => Sender.Request<LolMatchHistoryRecentlyPlayedSummoner[]>("get", $"/lol-match-history/v1/recently-played-summoners");
        public static Task<string> GetLolMatchHistoryV1WebUrl()
            => Sender.Request<string>("get", $"/lol-match-history/v1/web-url");
        public static Task<LolMatchHistoryMatchHistoryList> GetLolMatchHistoryV2Matchlist([Parameter("begIndex", "query")] int begIndex, [Parameter("endIndex", "query")] int endIndex)
            => Sender.Request<LolMatchHistoryMatchHistoryList>("get", $"/lol-match-history/v2/matchlist?begIndex={System.Net.WebUtility.UrlEncode(begIndex.ToString())}&endIndex={System.Net.WebUtility.UrlEncode(endIndex.ToString())}");
    }
}
