using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolClubsPublic
    {
        public static Task<LolClubsPublicClubsPublicData[]> GetLolClubsPublicV1ClubsPublic([Parameter("summonerNames", "query")] string summonerNames)
            => Sender.Request<LolClubsPublicClubsPublicData[]>("get", $"/lol-clubs-public/v1/clubs/public?summonerNames={System.Net.WebUtility.UrlEncode(summonerNames.ToString())}");
        public static Task<LolClubsPublicClubsPublicData> GetLolClubsPublicV1ClubsPublicBySummonerId([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolClubsPublicClubsPublicData>("get", $"/lol-clubs-public/v1/clubs/public/{summonerId}");
        public static Task<LolClubsPublicClubTag> GetLolClubsPublicV1ClubsPublicBySummonerIdTag([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolClubsPublicClubTag>("get", $"/lol-clubs-public/v1/clubs/public/{summonerId}/tag");
    }
}
