using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolChampSelectLegacy
    {
        public static Task<LolChampSelectLegacyChampSelectBannableChampions> GetLolChampSelectLegacyV1BannableChampions()
            => Sender.Request<LolChampSelectLegacyChampSelectBannableChampions>("get", $"/lol-champ-select-legacy/v1/bannable-champions");
        public static Task<object> PostLolChampSelectLegacyV1BattleTrainingLaunch()
            => Sender.Request<object>("post", $"/lol-champ-select-legacy/v1/battle-training/launch");
        public static Task<int> GetLolChampSelectLegacyV1CurrentChampion()
            => Sender.Request<int>("get", $"/lol-champ-select-legacy/v1/current-champion");
        public static Task<bool> GetLolChampSelectLegacyV1ImplementationActive()
            => Sender.Request<bool>("get", $"/lol-champ-select-legacy/v1/implementation-active");
        public static Task<LolChampSelectLegacyChampSelectPickableChampions> GetLolChampSelectLegacyV1PickableChampions()
            => Sender.Request<LolChampSelectLegacyChampSelectPickableChampions>("get", $"/lol-champ-select-legacy/v1/pickable-champions");
        public static Task<LolChampSelectLegacyChampSelectSession> GetLolChampSelectLegacyV1Session()
            => Sender.Request<LolChampSelectLegacyChampSelectSession>("get", $"/lol-champ-select-legacy/v1/session");
        public static Task<object> PatchLolChampSelectLegacyV1SessionActionsById([Parameter("id", "path")] long id, [Parameter("data", "body")] LolChampSelectLegacyChampSelectAction data)
            => Sender.Request<object>("patch", $"/lol-champ-select-legacy/v1/session/actions/{id}", data);
        public static Task<object> PostLolChampSelectLegacyV1SessionActionsByIdComplete([Parameter("id", "path")] long id)
            => Sender.Request<object>("post", $"/lol-champ-select-legacy/v1/session/actions/{id}/complete");
        public static Task<object> PatchLolChampSelectLegacyV1SessionMySelection([Parameter("selection", "body")] LolChampSelectLegacyChampSelectMySelection selection)
            => Sender.Request<object>("patch", $"/lol-champ-select-legacy/v1/session/my-selection", selection);
        public static Task<object> PostLolChampSelectLegacyV1SessionMySelectionReroll()
            => Sender.Request<object>("post", $"/lol-champ-select-legacy/v1/session/my-selection/reroll");
        public static Task<LolChampSelectLegacyChampSelectTimer> GetLolChampSelectLegacyV1SessionTimer()
            => Sender.Request<LolChampSelectLegacyChampSelectTimer>("get", $"/lol-champ-select-legacy/v1/session/timer");
        public static Task<LolChampSelectLegacyChampSelectTradeContract[]> GetLolChampSelectLegacyV1SessionTrades()
            => Sender.Request<LolChampSelectLegacyChampSelectTradeContract[]>("get", $"/lol-champ-select-legacy/v1/session/trades");
        public static Task<LolChampSelectLegacyChampSelectTradeContract> GetLolChampSelectLegacyV1SessionTradesById([Parameter("id", "path")] long id)
            => Sender.Request<LolChampSelectLegacyChampSelectTradeContract>("get", $"/lol-champ-select-legacy/v1/session/trades/{id}");
        public static Task<object> PostLolChampSelectLegacyV1SessionTradesByIdAccept([Parameter("id", "path")] long id)
            => Sender.Request<object>("post", $"/lol-champ-select-legacy/v1/session/trades/{id}/accept");
        public static Task<object> PostLolChampSelectLegacyV1SessionTradesByIdCancel([Parameter("id", "path")] long id)
            => Sender.Request<object>("post", $"/lol-champ-select-legacy/v1/session/trades/{id}/cancel");
        public static Task<object> PostLolChampSelectLegacyV1SessionTradesByIdDecline([Parameter("id", "path")] long id)
            => Sender.Request<object>("post", $"/lol-champ-select-legacy/v1/session/trades/{id}/decline");
        public static Task<LolChampSelectLegacyChampSelectTradeContract> PostLolChampSelectLegacyV1SessionTradesByIdRequest([Parameter("id", "path")] long id)
            => Sender.Request<LolChampSelectLegacyChampSelectTradeContract>("post", $"/lol-champ-select-legacy/v1/session/trades/{id}/request");
        public static Task<LolChampSelectLegacyTeamBoost> GetLolChampSelectLegacyV1TeamBoost()
            => Sender.Request<LolChampSelectLegacyTeamBoost>("get", $"/lol-champ-select-legacy/v1/team-boost");
        public static Task<object> PostLolChampSelectLegacyV1TeamBoostPurchase()
            => Sender.Request<object>("post", $"/lol-champ-select-legacy/v1/team-boost/purchase");
    }
}
