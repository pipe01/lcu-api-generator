using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolTrophies
    {
        public static Task<LolTrophiesTrophyProfileData> GetLolTrophiesV1CurrentSummonerTrophiesProfile()
            => Sender.Request<LolTrophiesTrophyProfileData>("get", $"/lol-trophies/v1/current-summoner/trophies/profile");
        public static Task<LolTrophiesTrophyProfileData> GetLolTrophiesV1PlayersByPuuidTrophiesProfile([Parameter("puuid", "path")] string puuid)
            => Sender.Request<LolTrophiesTrophyProfileData>("get", $"/lol-trophies/v1/players/{puuid}/trophies/profile");
    }
}
