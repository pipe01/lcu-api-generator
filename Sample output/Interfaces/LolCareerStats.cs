using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolCareerStats
    {
        public static Task<LolCareerStatsChampionQueueStatsResponse> GetLolCareerStatsV1ChampionAveragesSeasonBySeasonByChampionIdByPositionByTierByQueue([Parameter("season", "path")] int season, [Parameter("championId", "path")] int championId, [Parameter("position", "path")] string position, [Parameter("tier", "path")] string tier, [Parameter("queue", "path")] string queue)
            => Sender.Request<LolCareerStatsChampionQueueStatsResponse>("get", $"/lol-career-stats/v1/champion-averages/season/{season}/{championId}/{position}/{tier}/{queue}");
        public static Task<LolCareerStatsChampionQueueStatsResponse> GetLolCareerStatsV1ChampionAveragesByChampionIdByPositionByTierByQueue([Parameter("championId", "path")] int championId, [Parameter("position", "path")] string position, [Parameter("tier", "path")] string tier, [Parameter("queue", "path")] string queue)
            => Sender.Request<LolCareerStatsChampionQueueStatsResponse>("get", $"/lol-career-stats/v1/champion-averages/{championId}/{position}/{tier}/{queue}");
        public static Task<LolCareerStatsExpertPlayer[]> GetLolCareerStatsV1ChampionExpertsSeasonBySeasonByChampionIdByPosition([Parameter("season", "path")] int season, [Parameter("championId", "path")] int championId, [Parameter("position", "path")] string position)
            => Sender.Request<LolCareerStatsExpertPlayer[]>("get", $"/lol-career-stats/v1/champion-experts/season/{season}/{championId}/{position}");
        public static Task<LolCareerStatsExpertPlayer[]> GetLolCareerStatsV1ChampionExpertsByChampionIdByPosition([Parameter("championId", "path")] int championId, [Parameter("position", "path")] string position)
            => Sender.Request<LolCareerStatsExpertPlayer[]>("get", $"/lol-career-stats/v1/champion-experts/{championId}/{position}");
        public static Task<LolCareerStatsStatisticsPercentilesResponse[]> PostLolCareerStatsV1ChampionStatsPercentiles([Parameter("body", "body")] LolCareerStatsStatsQueryRequest[] body)
            => Sender.Request<LolCareerStatsStatisticsPercentilesResponse[]>("post", $"/lol-career-stats/v1/champion-stats-percentiles", body);
        public static Task<LolCareerStatsChampionQueueStatsResponse> GetLolCareerStatsV1PositionAveragesSeasonBySeasonByPositionByTierByQueue([Parameter("season", "path")] int season, [Parameter("position", "path")] string position, [Parameter("tier", "path")] string tier, [Parameter("queue", "path")] string queue)
            => Sender.Request<LolCareerStatsChampionQueueStatsResponse>("get", $"/lol-career-stats/v1/position-averages/season/{season}/{position}/{tier}/{queue}");
        public static Task<LolCareerStatsChampionQueueStatsResponse> GetLolCareerStatsV1PositionAveragesByPositionByTierByQueue([Parameter("position", "path")] string position, [Parameter("tier", "path")] string tier, [Parameter("queue", "path")] string queue)
            => Sender.Request<LolCareerStatsChampionQueueStatsResponse>("get", $"/lol-career-stats/v1/position-averages/{position}/{tier}/{queue}");
        public static Task<LolCareerStatsExpertPlayer[]> GetLolCareerStatsV1PositionExpertsSeasonBySeasonByPosition([Parameter("season", "path")] int season, [Parameter("position", "path")] string position)
            => Sender.Request<LolCareerStatsExpertPlayer[]>("get", $"/lol-career-stats/v1/position-experts/season/{season}/{position}");
        public static Task<LolCareerStatsExpertPlayer[]> GetLolCareerStatsV1PositionExpertsByPosition([Parameter("position", "path")] string position)
            => Sender.Request<LolCareerStatsExpertPlayer[]>("get", $"/lol-career-stats/v1/position-experts/{position}");
        public static Task<LolCareerStatsStatisticsPercentilesResponse[]> PostLolCareerStatsV1PositionStatsPercentiles([Parameter("body", "body")] LolCareerStatsPositionStatsQueryRequest[] body)
            => Sender.Request<LolCareerStatsStatisticsPercentilesResponse[]>("post", $"/lol-career-stats/v1/position-stats-percentiles", body);
        public static Task<object> GetLolCareerStatsV1SummonerGamesByPuuid([Parameter("puuid", "path")] string puuid)
            => Sender.Request<object>("get", $"/lol-career-stats/v1/summoner-games/{puuid}");
        public static Task<object> GetLolCareerStatsV1SummonerGamesByPuuidSeasonBySeason([Parameter("puuid", "path")] string puuid, [Parameter("season", "path")] int season)
            => Sender.Request<object>("get", $"/lol-career-stats/v1/summoner-games/{puuid}/season/{season}");
        public static Task<object> GetLolCareerStatsV1SummonerStatsByPuuidBySeasonByQueueByPosition([Parameter("puuid", "path")] string puuid, [Parameter("season", "path")] int season, [Parameter("queue", "path")] string queue, [Parameter("position", "path")] string position, [Parameter("championId", "query")] int championId)
            => Sender.Request<object>("get", $"/lol-career-stats/v1/summoner-stats/{puuid}/{season}/{queue}/{position}?championId={System.Net.WebUtility.UrlEncode(championId.ToString())}");
    }
}
