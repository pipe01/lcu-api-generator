using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolChampSelect
    {
        public static Task<LolChampSelectChampSelectBannableChampions> GetLolChampSelectV1BannableChampions()
            => Sender.Request<LolChampSelectChampSelectBannableChampions>("get", $"/lol-champ-select/v1/bannable-champions");
        public static Task<object> PostLolChampSelectV1BattleTrainingLaunch()
            => Sender.Request<object>("post", $"/lol-champ-select/v1/battle-training/launch");
        public static Task<int> GetLolChampSelectV1CurrentChampion()
            => Sender.Request<int>("get", $"/lol-champ-select/v1/current-champion");
        public static Task<LolChampSelectChampSelectDisabledChampions> GetLolChampSelectV1DisabledChampions()
            => Sender.Request<LolChampSelectChampSelectDisabledChampions>("get", $"/lol-champ-select/v1/disabled-champions");
        public static Task<LolChampSelectChampSelectPickableChampions> GetLolChampSelectV1PickableChampions()
            => Sender.Request<LolChampSelectChampSelectPickableChampions>("get", $"/lol-champ-select/v1/pickable-champions");
        public static Task<LolChampSelectChampSelectPickableSkins> GetLolChampSelectV1PickableSkins()
            => Sender.Request<LolChampSelectChampSelectPickableSkins>("get", $"/lol-champ-select/v1/pickable-skins");
        public static Task<object> PostLolChampSelectV1RetrieveLatestGameDto()
            => Sender.Request<object>("post", $"/lol-champ-select/v1/retrieve-latest-game-dto");
        public static Task<LolChampSelectChampSelectSession> GetLolChampSelectV1Session()
            => Sender.Request<LolChampSelectChampSelectSession>("get", $"/lol-champ-select/v1/session");
        public static Task<object> PatchLolChampSelectV1SessionActionsById([Parameter("id", "path")] long id, [Parameter("data", "body")] LolChampSelectChampSelectAction data)
            => Sender.Request<object>("patch", $"/lol-champ-select/v1/session/actions/{id}", data);
        public static Task<object> PostLolChampSelectV1SessionActionsByIdComplete([Parameter("id", "path")] long id)
            => Sender.Request<object>("post", $"/lol-champ-select/v1/session/actions/{id}/complete");
        public static Task<object> PostLolChampSelectV1SessionBenchSwapByChampionId([Parameter("championId", "path")] int championId)
            => Sender.Request<object>("post", $"/lol-champ-select/v1/session/bench/swap/{championId}");
        public static Task<object> PatchLolChampSelectV1SessionMySelection([Parameter("selection", "body")] LolChampSelectChampSelectMySelection selection)
            => Sender.Request<object>("patch", $"/lol-champ-select/v1/session/my-selection", selection);
        public static Task<object> PostLolChampSelectV1SessionMySelectionReroll()
            => Sender.Request<object>("post", $"/lol-champ-select/v1/session/my-selection/reroll");
        public static Task<object> PostLolChampSelectV1SessionSimpleInventory()
            => Sender.Request<object>("post", $"/lol-champ-select/v1/session/simple-inventory");
        public static Task<LolChampSelectChampSelectTimer> GetLolChampSelectV1SessionTimer()
            => Sender.Request<LolChampSelectChampSelectTimer>("get", $"/lol-champ-select/v1/session/timer");
        public static Task<LolChampSelectChampSelectTradeContract[]> GetLolChampSelectV1SessionTrades()
            => Sender.Request<LolChampSelectChampSelectTradeContract[]>("get", $"/lol-champ-select/v1/session/trades");
        public static Task<LolChampSelectChampSelectTradeContract> GetLolChampSelectV1SessionTradesById([Parameter("id", "path")] long id)
            => Sender.Request<LolChampSelectChampSelectTradeContract>("get", $"/lol-champ-select/v1/session/trades/{id}");
        public static Task<object> PostLolChampSelectV1SessionTradesByIdAccept([Parameter("id", "path")] long id)
            => Sender.Request<object>("post", $"/lol-champ-select/v1/session/trades/{id}/accept");
        public static Task<object> PostLolChampSelectV1SessionTradesByIdCancel([Parameter("id", "path")] long id)
            => Sender.Request<object>("post", $"/lol-champ-select/v1/session/trades/{id}/cancel");
        public static Task<object> PostLolChampSelectV1SessionTradesByIdDecline([Parameter("id", "path")] long id)
            => Sender.Request<object>("post", $"/lol-champ-select/v1/session/trades/{id}/decline");
        public static Task<LolChampSelectChampSelectTradeContract> PostLolChampSelectV1SessionTradesByIdRequest([Parameter("id", "path")] long id)
            => Sender.Request<LolChampSelectChampSelectTradeContract>("post", $"/lol-champ-select/v1/session/trades/{id}/request");
        public static Task<LolChampSelectTeamBoost> GetLolChampSelectV1TeamBoost()
            => Sender.Request<LolChampSelectTeamBoost>("get", $"/lol-champ-select/v1/team-boost");
        public static Task<object> PostLolChampSelectV1TeamBoostPurchase()
            => Sender.Request<object>("post", $"/lol-champ-select/v1/team-boost/purchase");
    }
}
