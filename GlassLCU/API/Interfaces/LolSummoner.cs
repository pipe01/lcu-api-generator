using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolSummoner
    {
        public static Task<bool> GetLolSummonerV1CheckNameAvailabilityByName([Parameter("name", "path")] string name)
            => Sender.Request<bool>("get", $"/lol-summoner/v1/check-name-availability/{name}");
        public static Task<LolSummonerSummoner> GetLolSummonerV1CurrentSummoner()
            => Sender.Request<LolSummonerSummoner>("get", $"/lol-summoner/v1/current-summoner");
        public static Task<LolSummonerAutoFillDto> GetLolSummonerV1CurrentSummonerAutofill()
            => Sender.Request<LolSummonerAutoFillDto>("get", $"/lol-summoner/v1/current-summoner/autofill");
        public static Task<LolSummonerSummoner> PutLolSummonerV1CurrentSummonerIcon([Parameter("body", "body")] LolSummonerSummonerIcon body)
            => Sender.Request<LolSummonerSummoner>("put", $"/lol-summoner/v1/current-summoner/icon", body);
        public static Task<string> GetLolSummonerV1CurrentSummonerJwt()
            => Sender.Request<string>("get", $"/lol-summoner/v1/current-summoner/jwt");
        public static Task<LolSummonerSummoner> PostLolSummonerV1CurrentSummonerName([Parameter("name", "body")] string name)
            => Sender.Request<LolSummonerSummoner>("post", $"/lol-summoner/v1/current-summoner/name", name);
        public static Task<LolSummonerSummonerRerollPoints> GetLolSummonerV1CurrentSummonerRerollPoints()
            => Sender.Request<LolSummonerSummonerRerollPoints>("get", $"/lol-summoner/v1/current-summoner/rerollPoints");
        public static Task<object> GetLolSummonerV1CurrentSummonerSummonerProfile()
            => Sender.Request<object>("get", $"/lol-summoner/v1/current-summoner/summoner-profile");
        public static Task<object> PostLolSummonerV1CurrentSummonerSummonerProfile([Parameter("body", "body")] LolSummonerSummonerProfileUpdate body)
            => Sender.Request<object>("post", $"/lol-summoner/v1/current-summoner/summoner-profile", body);
        public static Task<LolSummonerSummoner> PostLolSummonerV1CurrentSummonerXpInfo()
            => Sender.Request<LolSummonerSummoner>("post", $"/lol-summoner/v1/current-summoner/xpInfo");
        public static Task<object> GetLolSummonerV1SummonerProfile([Parameter("puuid", "query")] string puuid)
            => Sender.Request<object>("get", $"/lol-summoner/v1/summoner-profile?puuid={System.Net.WebUtility.UrlEncode(puuid.ToString())}");
        public static Task<LolSummonerSummoner> GetLolSummonerV1Summoners([Parameter("name", "query")] string name)
            => Sender.Request<LolSummonerSummoner>("get", $"/lol-summoner/v1/summoners?name={System.Net.WebUtility.UrlEncode(name.ToString())}");
        public static Task<LolSummonerInternalSummoner> PostLolSummonerV1Summoners([Parameter("name", "body")] LolSummonerSummonerRequestedName name)
            => Sender.Request<LolSummonerInternalSummoner>("post", $"/lol-summoner/v1/summoners", name);
        public static Task<LolSummonerSummoner> GetLolSummonerV1SummonersById([Parameter("id", "path")] long id)
            => Sender.Request<LolSummonerSummoner>("get", $"/lol-summoner/v1/summoners/{id}");
        public static Task<LolSummonerSummonerIdAndIcon[]> GetLolSummonerV2SummonerIcons([Parameter("ids", "query")] long[] ids)
            => Sender.Request<LolSummonerSummonerIdAndIcon[]>("get", $"/lol-summoner/v2/summoner-icons?ids={System.Net.WebUtility.UrlEncode(ids.ToString())}");
        public static Task<LolSummonerSummonerIdAndName[]> GetLolSummonerV2SummonerNames([Parameter("ids", "query")] long[] ids)
            => Sender.Request<LolSummonerSummonerIdAndName[]>("get", $"/lol-summoner/v2/summoner-names?ids={System.Net.WebUtility.UrlEncode(ids.ToString())}");
        public static Task<LolSummonerSummoner[]> GetLolSummonerV2Summoners([Parameter("name", "query")] string name = default, [Parameter("ids", "query")] long[] ids = default)
            => Sender.Request<LolSummonerSummoner[]>("get", $"/lol-summoner/v2/summoners?{(name != default ? $"name={System.Net.WebUtility.UrlEncode(name.ToString())}" : null)}&{(ids != default ? $"ids={System.Net.WebUtility.UrlEncode(ids.ToString())}" : null)}");
    }
}
