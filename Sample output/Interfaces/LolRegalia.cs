//Auto-generated by https://github.com/pipe01/lcu-api-generator
using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;
using System.Reflection;

namespace GlassLCU.API.Interfaces
{
    public static class LolRegalia
    {
        /// <summary>
        /// <para>GET /lol-regalia/v2/config</para>
        /// </summary>
        [Endpoint("/lol-regalia/v2/config")]
        public static Task<LolRegaliaRegaliaFrontendConfig> GetLolRegaliaV2Config()
            => Sender.Request<LolRegaliaRegaliaFrontendConfig>("get", $"/lol-regalia/v2/config");
        /// <summary>
        /// <para>GET /lol-regalia/v2/current-summoner/regalia</para>
        /// </summary>
        [Endpoint("/lol-regalia/v2/current-summoner/regalia")]
        public static Task<LolRegaliaRegaliaWithPreferences> GetLolRegaliaV2CurrentSummonerRegalia()
            => Sender.Request<LolRegaliaRegaliaWithPreferences>("get", $"/lol-regalia/v2/current-summoner/regalia");
        /// <summary>
        /// <para>PUT /lol-regalia/v2/current-summoner/regalia</para>
        /// </summary>
        [Endpoint("/lol-regalia/v2/current-summoner/regalia")]
        public static Task<LolRegaliaRegaliaWithPreferences> PutLolRegaliaV2CurrentSummonerRegalia([Parameter("regalia", "body")] LolRegaliaRegaliaPreferences regalia)
            => Sender.Request<LolRegaliaRegaliaWithPreferences>("put", $"/lol-regalia/v2/current-summoner/regalia", regalia);
        /// <summary>
        /// <para>GET /lol-regalia/v2/summoners/{summonerId}/regalia</para>
        /// </summary>
        [Endpoint("/lol-regalia/v2/summoners/{summonerId}/regalia")]
        public static Task<LolRegaliaRegalia> GetLolRegaliaV2SummonersBySummonerIdRegalia([Parameter("summonerId", "path")] long summonerId, [Parameter("hovercard", "query")] bool hovercard)
            => Sender.Request<LolRegaliaRegalia>("get", $"/lol-regalia/v2/summoners/{summonerId}/regalia?hovercard={System.Net.WebUtility.UrlEncode(hovercard.ToString())}");
        /// <summary>
        /// <para>GET /lol-regalia/v2/summoners/{summonerId}/regalia/async</para>
        /// </summary>
        [Endpoint("/lol-regalia/v2/summoners/{summonerId}/regalia/async")]
        public static Task<LolRegaliaRegaliaAsync> GetLolRegaliaV2SummonersBySummonerIdRegaliaAsync([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolRegaliaRegaliaAsync>("get", $"/lol-regalia/v2/summoners/{summonerId}/regalia/async");

        public static string GetURL(string methodName)
        {
            return typeof(LolRegalia).GetMethod(methodName).GetCustomAttribute<EndpointAttribute>().URL;
        }
    }
}
