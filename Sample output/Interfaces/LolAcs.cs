using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolAcs
    {
        public static Task<object> PostLolAcsV1AcsEndpointOverride([Parameter("data", "body")] LolAcsAcsEndPoint data)
            => Sender.Request<object>("post", $"/lol-acs/v1/acs-endpoint-override", data);
        public static Task<object> GetLolAcsV1Delta()
            => Sender.Request<object>("get", $"/lol-acs/v1/delta");
        public static Task<object> GetLolAcsV1GamesByGameId([Parameter("gameId", "path")] long gameId)
            => Sender.Request<object>("get", $"/lol-acs/v1/games/{gameId}");
        public static Task<object> GetLolAcsV1GametimelinesByGameId([Parameter("gameId", "path")] long gameId)
            => Sender.Request<object>("get", $"/lol-acs/v1/gametimelines/{gameId}");
        public static Task<object> GetLolAcsV1MatchlistsByAccountId([Parameter("accountId", "path")] long accountId)
            => Sender.Request<object>("get", $"/lol-acs/v1/matchlists/{accountId}");
        public static Task<LolAcsAcsChampionGamesCollection> GetLolAcsV1RecentlyPlayedChampionsByAccountId([Parameter("accountId", "path")] long accountId, [Parameter("force", "query")] bool force)
            => Sender.Request<LolAcsAcsChampionGamesCollection>("get", $"/lol-acs/v1/recently-played-champions/{accountId}?force={System.Net.WebUtility.UrlEncode(force.ToString())}");
        public static Task<object> GetLolAcsV2Matchlists([Parameter("accountId", "query")] long accountId, [Parameter("begIndex", "query")] int begIndex, [Parameter("endIndex", "query")] int endIndex)
            => Sender.Request<object>("get", $"/lol-acs/v2/matchlists?accountId={System.Net.WebUtility.UrlEncode(accountId.ToString())}&begIndex={System.Net.WebUtility.UrlEncode(begIndex.ToString())}&endIndex={System.Net.WebUtility.UrlEncode(endIndex.ToString())}");
        public static Task<LolAcsAcsChampionGamesCollection> GetLolAcsV2RecentlyPlayedChampionsCurrentSummoner([Parameter("force", "query")] bool force)
            => Sender.Request<LolAcsAcsChampionGamesCollection>("get", $"/lol-acs/v2/recently-played-champions/current-summoner?force={System.Net.WebUtility.UrlEncode(force.ToString())}");
        public static Task<LolAcsAcsChampionGamesCollection> GetLolAcsV2RecentlyPlayedChampionsByAccountId([Parameter("accountId", "path")] long accountId)
            => Sender.Request<LolAcsAcsChampionGamesCollection>("get", $"/lol-acs/v2/recently-played-champions/{accountId}");
        public static Task GetLolAcsV2RequestRecentlyPlayedChampionsCurrentSummoner([Parameter("force", "query")] bool force)
            => Sender.Request("get", $"/lol-acs/v2/request-recently-played-champions/current-summoner?force={System.Net.WebUtility.UrlEncode(force.ToString())}");
        public static Task GetLolAcsV2RequestRecentlyPlayedChampionsByAccountId([Parameter("accountId", "path")] long accountId, [Parameter("force", "query")] bool force)
            => Sender.Request("get", $"/lol-acs/v2/request-recently-played-champions/{accountId}?force={System.Net.WebUtility.UrlEncode(force.ToString())}");
    }
}
