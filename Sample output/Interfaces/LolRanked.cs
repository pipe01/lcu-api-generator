using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolRanked
    {
        public static Task<LolRankedRankedApexQueueInfo> GetLolRankedV1ApexLeaguesByQueueTypeByTier([Parameter("queueType", "path")] string queueType, [Parameter("tier", "path")] string tier)
            => Sender.Request<LolRankedRankedApexQueueInfo>("get", $"/lol-ranked/v1/apex-leagues/{queueType}/{tier}");
        public static Task<LolRankedLeaguesNotification> GetLolRankedV1CurrentLpChangeNotification()
            => Sender.Request<LolRankedLeaguesNotification>("get", $"/lol-ranked/v1/current-lp-change-notification");
        public static Task<LolRankedLeaguesNotification[]> GetLolRankedV1Notifications()
            => Sender.Request<LolRankedLeaguesNotification[]>("get", $"/lol-ranked/v1/notifications");
        public static Task<object> PostLolRankedV1NotificationsByIdAcknowledge([Parameter("id", "path")] long id)
            => Sender.Request<object>("post", $"/lol-ranked/v1/notifications/{id}/acknowledge");
        public static Task<LolRankedRankedDashboardInfo> GetLolRankedV1RankedDashboardBySummonerId([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolRankedRankedDashboardInfo>("get", $"/lol-ranked/v1/ranked-dashboard/{summonerId}");
        public static Task<LolRankedRankedOverviewInfo> GetLolRankedV1RankedOverviewBySummonerId([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolRankedRankedOverviewInfo>("get", $"/lol-ranked/v1/ranked-overview/{summonerId}");
        public static Task<LolRankedRankedRewardUpdate> GetLolRankedV1RankedRewardUpdate()
            => Sender.Request<LolRankedRankedRewardUpdate>("get", $"/lol-ranked/v1/ranked-reward-update");
        public static Task<LolRankedRankedRewardsData> GetLolRankedV1RankedRewardsData()
            => Sender.Request<LolRankedRankedRewardsData>("get", $"/lol-ranked/v1/ranked-rewards-data");
        public static Task<SignedRankedDashboardDTO> GetLolRankedV1SignedRankedDashboard()
            => Sender.Request<SignedRankedDashboardDTO>("get", $"/lol-ranked/v1/signed-ranked-dashboard");
        public static Task<LolRankedLeagueChampAndStat[]> GetLolRankedV1SummonerTopChampsBySummonerId([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolRankedLeagueChampAndStat[]>("get", $"/lol-ranked/v1/summoner-top-champs/{summonerId}");
        public static Task<LolRankedLeaguesNotification[]> GetLolRankedV1VignetteNotifications()
            => Sender.Request<LolRankedLeaguesNotification[]>("get", $"/lol-ranked/v1/vignette-notifications");
        public static Task<LolRankedParticipantTiers[]> GetLolRankedV2Tiers([Parameter("summonerIds", "query")] long[] summonerIds, [Parameter("queueTypes", "query")] LolRankedLeagueQueueType[] queueTypes)
            => Sender.Request<LolRankedParticipantTiers[]>("get", $"/lol-ranked/v2/tiers?summonerIds={System.Net.WebUtility.UrlEncode(summonerIds.ToString())}&queueTypes={System.Net.WebUtility.UrlEncode(queueTypes.ToString())}");
    }
}
