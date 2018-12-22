using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolGeoinfo
    {
        public static Task<LolGeoinfoGeoInfo> GetLolGeoinfoV1Getlocation([Parameter("ip_address", "query")] string ip_address)
            => Sender.Request<LolGeoinfoGeoInfo>("get", $"/lol-geoinfo/v1/getlocation?ip_address={System.Net.WebUtility.UrlEncode(ip_address.ToString())}");
        public static Task<LolGeoinfoGeoInfoResponse> GetLolGeoinfoV1Whereami()
            => Sender.Request<LolGeoinfoGeoInfoResponse>("get", $"/lol-geoinfo/v1/whereami");
    }
}
