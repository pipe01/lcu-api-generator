using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolTrophies
    {
        public static Task<LolTrophiesTrophyProfileData> GetLolTrophiesV1CurrentSummonerTrophiesProfile()
            => Sender.Request<LolTrophiesTrophyProfileData>("get", $"/lol-trophies/v1/current-summoner/trophies/profile");
        public static Task<LolTrophiesTrophyProfileData> GetLolTrophiesV1PlayersByPuuidTrophiesProfile([Parameter("puuid", "path")] string puuid)
            => Sender.Request<LolTrophiesTrophyProfileData>("get", $"/lol-trophies/v1/players/{puuid}/trophies/profile");
    }
}
