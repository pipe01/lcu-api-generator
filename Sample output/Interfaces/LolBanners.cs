using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolBanners
    {
        public static Task<LolBannersBannerFlag[]> GetLolBannersV1CurrentSummonerFlags()
            => Sender.Request<LolBannersBannerFlag[]>("get", $"/lol-banners/v1/current-summoner/flags");
        public static Task<LolBannersBannerFlag> GetLolBannersV1CurrentSummonerFlagsEquipped()
            => Sender.Request<LolBannersBannerFlag>("get", $"/lol-banners/v1/current-summoner/flags/equipped");
        public static Task<LolBannersBannerFlag> PutLolBannersV1CurrentSummonerFlagsEquipped([Parameter("flag", "body")] LolBannersBannerFlag flag)
            => Sender.Request<LolBannersBannerFlag>("put", $"/lol-banners/v1/current-summoner/flags/equipped", flag);
        public static Task<LolBannersBannerFrame> GetLolBannersV1CurrentSummonerFramesEquipped()
            => Sender.Request<LolBannersBannerFrame>("get", $"/lol-banners/v1/current-summoner/frames/equipped");
        public static Task<LolBannersBannerFlag> GetLolBannersV1PlayersByPuuidFlagsEquipped([Parameter("puuid", "path")] string puuid)
            => Sender.Request<LolBannersBannerFlag>("get", $"/lol-banners/v1/players/{puuid}/flags/equipped");
    }
}
