//Auto-generated by https://github.com/pipe01/lcu-api-generator
using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;
using System.Reflection;

namespace GlassLCU.API.Interfaces
{
    public static class LolChampSelect
    {
        /// <summary>
        /// <para>GET /lol-champ-select/v1/bannable-champions</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/bannable-champions")]
        public static Task<LolChampSelectChampSelectBannableChampions> GetLolChampSelectV1BannableChampions()
            => Sender.Request<LolChampSelectChampSelectBannableChampions>("get", $"/lol-champ-select/v1/bannable-champions");
        /// <summary>
        /// <para>POST /lol-champ-select/v1/battle-training/launch</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/battle-training/launch")]
        public static Task<object> PostLolChampSelectV1BattleTrainingLaunch()
            => Sender.Request<object>("post", $"/lol-champ-select/v1/battle-training/launch");
        /// <summary>
        /// <para>GET /lol-champ-select/v1/current-champion</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/current-champion")]
        public static Task<int> GetLolChampSelectV1CurrentChampion()
            => Sender.Request<int>("get", $"/lol-champ-select/v1/current-champion");
        /// <summary>
        /// <para>GET /lol-champ-select/v1/disabled-champions</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/disabled-champions")]
        public static Task<LolChampSelectChampSelectDisabledChampions> GetLolChampSelectV1DisabledChampions()
            => Sender.Request<LolChampSelectChampSelectDisabledChampions>("get", $"/lol-champ-select/v1/disabled-champions");
        /// <summary>
        /// <para>GET /lol-champ-select/v1/pickable-champions</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/pickable-champions")]
        public static Task<LolChampSelectChampSelectPickableChampions> GetLolChampSelectV1PickableChampions()
            => Sender.Request<LolChampSelectChampSelectPickableChampions>("get", $"/lol-champ-select/v1/pickable-champions");
        /// <summary>
        /// <para>GET /lol-champ-select/v1/pickable-skins</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/pickable-skins")]
        public static Task<LolChampSelectChampSelectPickableSkins> GetLolChampSelectV1PickableSkins()
            => Sender.Request<LolChampSelectChampSelectPickableSkins>("get", $"/lol-champ-select/v1/pickable-skins");
        /// <summary>
        /// <para>POST /lol-champ-select/v1/retrieve-latest-game-dto</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/retrieve-latest-game-dto")]
        public static Task<object> PostLolChampSelectV1RetrieveLatestGameDto()
            => Sender.Request<object>("post", $"/lol-champ-select/v1/retrieve-latest-game-dto");
        /// <summary>
        /// <para>GET /lol-champ-select/v1/session</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/session")]
        public static Task<LolChampSelectChampSelectSession> GetLolChampSelectV1Session()
            => Sender.Request<LolChampSelectChampSelectSession>("get", $"/lol-champ-select/v1/session");
        /// <summary>
        /// <para>PATCH /lol-champ-select/v1/session/actions/{id}</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/session/actions/{id}")]
        public static Task<object> PatchLolChampSelectV1SessionActionsById([Parameter("id", "path")] long id, [Parameter("data", "body")] LolChampSelectChampSelectAction data)
            => Sender.Request<object>("patch", $"/lol-champ-select/v1/session/actions/{id}", data);
        /// <summary>
        /// <para>POST /lol-champ-select/v1/session/actions/{id}/complete</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/session/actions/{id}/complete")]
        public static Task<object> PostLolChampSelectV1SessionActionsByIdComplete([Parameter("id", "path")] long id)
            => Sender.Request<object>("post", $"/lol-champ-select/v1/session/actions/{id}/complete");
        /// <summary>
        /// <para>POST /lol-champ-select/v1/session/bench/swap/{championId}</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/session/bench/swap/{championId}")]
        public static Task<object> PostLolChampSelectV1SessionBenchSwapByChampionId([Parameter("championId", "path")] int championId)
            => Sender.Request<object>("post", $"/lol-champ-select/v1/session/bench/swap/{championId}");
        /// <summary>
        /// <para>PATCH /lol-champ-select/v1/session/my-selection</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/session/my-selection")]
        public static Task<object> PatchLolChampSelectV1SessionMySelection([Parameter("selection", "body")] LolChampSelectChampSelectMySelection selection)
            => Sender.Request<object>("patch", $"/lol-champ-select/v1/session/my-selection", selection);
        /// <summary>
        /// <para>POST /lol-champ-select/v1/session/my-selection/reroll</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/session/my-selection/reroll")]
        public static Task<object> PostLolChampSelectV1SessionMySelectionReroll()
            => Sender.Request<object>("post", $"/lol-champ-select/v1/session/my-selection/reroll");
        /// <summary>
        /// <para>POST /lol-champ-select/v1/session/simple-inventory</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/session/simple-inventory")]
        public static Task<object> PostLolChampSelectV1SessionSimpleInventory()
            => Sender.Request<object>("post", $"/lol-champ-select/v1/session/simple-inventory");
        /// <summary>
        /// <para>GET /lol-champ-select/v1/session/timer</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/session/timer")]
        public static Task<LolChampSelectChampSelectTimer> GetLolChampSelectV1SessionTimer()
            => Sender.Request<LolChampSelectChampSelectTimer>("get", $"/lol-champ-select/v1/session/timer");
        /// <summary>
        /// <para>GET /lol-champ-select/v1/session/trades</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/session/trades")]
        public static Task<LolChampSelectChampSelectTradeContract[]> GetLolChampSelectV1SessionTrades()
            => Sender.Request<LolChampSelectChampSelectTradeContract[]>("get", $"/lol-champ-select/v1/session/trades");
        /// <summary>
        /// <para>GET /lol-champ-select/v1/session/trades/{id}</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/session/trades/{id}")]
        public static Task<LolChampSelectChampSelectTradeContract> GetLolChampSelectV1SessionTradesById([Parameter("id", "path")] long id)
            => Sender.Request<LolChampSelectChampSelectTradeContract>("get", $"/lol-champ-select/v1/session/trades/{id}");
        /// <summary>
        /// <para>POST /lol-champ-select/v1/session/trades/{id}/accept</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/session/trades/{id}/accept")]
        public static Task<object> PostLolChampSelectV1SessionTradesByIdAccept([Parameter("id", "path")] long id)
            => Sender.Request<object>("post", $"/lol-champ-select/v1/session/trades/{id}/accept");
        /// <summary>
        /// <para>POST /lol-champ-select/v1/session/trades/{id}/cancel</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/session/trades/{id}/cancel")]
        public static Task<object> PostLolChampSelectV1SessionTradesByIdCancel([Parameter("id", "path")] long id)
            => Sender.Request<object>("post", $"/lol-champ-select/v1/session/trades/{id}/cancel");
        /// <summary>
        /// <para>POST /lol-champ-select/v1/session/trades/{id}/decline</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/session/trades/{id}/decline")]
        public static Task<object> PostLolChampSelectV1SessionTradesByIdDecline([Parameter("id", "path")] long id)
            => Sender.Request<object>("post", $"/lol-champ-select/v1/session/trades/{id}/decline");
        /// <summary>
        /// <para>POST /lol-champ-select/v1/session/trades/{id}/request</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/session/trades/{id}/request")]
        public static Task<LolChampSelectChampSelectTradeContract> PostLolChampSelectV1SessionTradesByIdRequest([Parameter("id", "path")] long id)
            => Sender.Request<LolChampSelectChampSelectTradeContract>("post", $"/lol-champ-select/v1/session/trades/{id}/request");
        /// <summary>
        /// <para>GET /lol-champ-select/v1/team-boost</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/team-boost")]
        public static Task<LolChampSelectTeamBoost> GetLolChampSelectV1TeamBoost()
            => Sender.Request<LolChampSelectTeamBoost>("get", $"/lol-champ-select/v1/team-boost");
        /// <summary>
        /// <para>POST /lol-champ-select/v1/team-boost/purchase</para>
        /// </summary>
        [Endpoint("/lol-champ-select/v1/team-boost/purchase")]
        public static Task<object> PostLolChampSelectV1TeamBoostPurchase()
            => Sender.Request<object>("post", $"/lol-champ-select/v1/team-boost/purchase");

        public static string GetURL(string methodName)
        {
            return typeof(LolChampSelect).GetMethod(methodName).GetCustomAttribute<EndpointAttribute>().URL;
        }
    }
}
