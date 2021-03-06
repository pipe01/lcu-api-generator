//Auto-generated by https://github.com/pipe01/lcu-api-generator
using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;
using System.Reflection;

namespace GlassLCU.API.Interfaces
{
    public static class LolGeoinfo
    {
        /// <summary>
        /// <para>GET /lol-geoinfo/v1/getlocation</para>
        /// </summary>
        [Endpoint("/lol-geoinfo/v1/getlocation")]
        public static Task<LolGeoinfoGeoInfo> GetLolGeoinfoV1Getlocation([Parameter("ip_address", "query")] string ip_address)
            => Sender.Request<LolGeoinfoGeoInfo>("get", $"/lol-geoinfo/v1/getlocation?ip_address={System.Net.WebUtility.UrlEncode(ip_address.ToString())}");
        /// <summary>
        /// <para>GET /lol-geoinfo/v1/whereami</para>
        /// </summary>
        [Endpoint("/lol-geoinfo/v1/whereami")]
        public static Task<LolGeoinfoGeoInfoResponse> GetLolGeoinfoV1Whereami()
            => Sender.Request<LolGeoinfoGeoInfoResponse>("get", $"/lol-geoinfo/v1/whereami");

        public static string GetURL(string methodName)
        {
            return typeof(LolGeoinfo).GetMethod(methodName).GetCustomAttribute<EndpointAttribute>().URL;
        }
    }
}
