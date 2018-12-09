using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolNpeRewards
    {
        public static Task PostLolNpeRewardsV1FetchRewards()
            => Sender.Request("post", $"/lol-npe-rewards/v1/fetch-rewards");
        public static Task<LolNpeRewardsRewardSeries> GetLolNpeRewardsV1LevelRewards()
            => Sender.Request<LolNpeRewardsRewardSeries>("get", $"/lol-npe-rewards/v1/level-rewards");
        public static Task<LolNpeRewardsRewardSeriesState> GetLolNpeRewardsV1LevelRewardsState()
            => Sender.Request<LolNpeRewardsRewardSeriesState>("get", $"/lol-npe-rewards/v1/level-rewards/state");
        public static Task<LolNpeRewardsRewardSeries> GetLolNpeRewardsV1LoginRewards()
            => Sender.Request<LolNpeRewardsRewardSeries>("get", $"/lol-npe-rewards/v1/login-rewards");
        public static Task<LolNpeRewardsRewardSeriesState> GetLolNpeRewardsV1LoginRewardsState()
            => Sender.Request<LolNpeRewardsRewardSeriesState>("get", $"/lol-npe-rewards/v1/login-rewards/state");
    }
}
