//Auto-generated by https://github.com/pipe01/lcu-api-generator
using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;
using System.Reflection;

namespace GlassLCU.API.Interfaces
{
    public static class LolMatchmaking
    {
        /// <summary>
        /// <para>GET /lol-matchmaking/v1/ready-check</para>
        /// </summary>
        [Endpoint("/lol-matchmaking/v1/ready-check")]
        public static Task<LolMatchmakingMatchmakingReadyCheckResource> GetLolMatchmakingV1ReadyCheck()
            => Sender.Request<LolMatchmakingMatchmakingReadyCheckResource>("get", $"/lol-matchmaking/v1/ready-check");
        /// <summary>
        /// <para>POST /lol-matchmaking/v1/ready-check/accept</para>
        /// </summary>
        [Endpoint("/lol-matchmaking/v1/ready-check/accept")]
        public static Task<object> PostLolMatchmakingV1ReadyCheckAccept()
            => Sender.Request<object>("post", $"/lol-matchmaking/v1/ready-check/accept");
        /// <summary>
        /// <para>POST /lol-matchmaking/v1/ready-check/decline</para>
        /// </summary>
        [Endpoint("/lol-matchmaking/v1/ready-check/decline")]
        public static Task<object> PostLolMatchmakingV1ReadyCheckDecline()
            => Sender.Request<object>("post", $"/lol-matchmaking/v1/ready-check/decline");
        /// <summary>
        /// <para>DELETE /lol-matchmaking/v1/search</para>
        /// </summary>
        [Endpoint("/lol-matchmaking/v1/search")]
        public static Task<object> DeleteLolMatchmakingV1Search()
            => Sender.Request<object>("delete", $"/lol-matchmaking/v1/search");
        /// <summary>
        /// <para>GET /lol-matchmaking/v1/search</para>
        /// </summary>
        [Endpoint("/lol-matchmaking/v1/search")]
        public static Task<LolMatchmakingMatchmakingSearchResource> GetLolMatchmakingV1Search()
            => Sender.Request<LolMatchmakingMatchmakingSearchResource>("get", $"/lol-matchmaking/v1/search");
        /// <summary>
        /// <para>POST /lol-matchmaking/v1/search</para>
        /// </summary>
        [Endpoint("/lol-matchmaking/v1/search")]
        public static Task<object> PostLolMatchmakingV1Search()
            => Sender.Request<object>("post", $"/lol-matchmaking/v1/search");
        /// <summary>
        /// <para>PUT /lol-matchmaking/v1/search</para>
        /// </summary>
        [Endpoint("/lol-matchmaking/v1/search")]
        public static Task<object> PutLolMatchmakingV1Search([Parameter("search", "body")] LolMatchmakingMatchmakingSearchResource search)
            => Sender.Request<object>("put", $"/lol-matchmaking/v1/search", search);
        /// <summary>
        /// <para>GET /lol-matchmaking/v1/search/errors</para>
        /// </summary>
        [Endpoint("/lol-matchmaking/v1/search/errors")]
        public static Task<LolMatchmakingMatchmakingSearchErrorResource[]> GetLolMatchmakingV1SearchErrors()
            => Sender.Request<LolMatchmakingMatchmakingSearchErrorResource[]>("get", $"/lol-matchmaking/v1/search/errors");
        /// <summary>
        /// <para>GET /lol-matchmaking/v1/search/errors/{id}</para>
        /// </summary>
        [Endpoint("/lol-matchmaking/v1/search/errors/{id}")]
        public static Task<LolMatchmakingMatchmakingSearchErrorResource> GetLolMatchmakingV1SearchErrorsById([Parameter("id", "path")] int id)
            => Sender.Request<LolMatchmakingMatchmakingSearchErrorResource>("get", $"/lol-matchmaking/v1/search/errors/{id}");

        public static string GetURL(string methodName)
        {
            return typeof(LolMatchmaking).GetMethod(methodName).GetCustomAttribute<EndpointAttribute>().URL;
        }
    }
}
