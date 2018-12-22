using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolLobbyTeamBuilder
    {
        public static Task<LolLobbyTeamBuilderChampSelectBannableChampions> GetLolLobbyTeamBuilderChampSelectV1BannableChampions()
            => Sender.Request<LolLobbyTeamBuilderChampSelectBannableChampions>("get", $"/lol-lobby-team-builder/champ-select/v1/bannable-champions");
        public static Task<int> GetLolLobbyTeamBuilderChampSelectV1CurrentChampion()
            => Sender.Request<int>("get", $"/lol-lobby-team-builder/champ-select/v1/current-champion");
        public static Task<LolLobbyTeamBuilderChampSelectDisabledChampions> GetLolLobbyTeamBuilderChampSelectV1DisabledChampions()
            => Sender.Request<LolLobbyTeamBuilderChampSelectDisabledChampions>("get", $"/lol-lobby-team-builder/champ-select/v1/disabled-champions");
        public static Task<bool> GetLolLobbyTeamBuilderChampSelectV1HasAutoAssignedSmite()
            => Sender.Request<bool>("get", $"/lol-lobby-team-builder/champ-select/v1/has-auto-assigned-smite");
        public static Task<bool> GetLolLobbyTeamBuilderChampSelectV1ImplementationActive()
            => Sender.Request<bool>("get", $"/lol-lobby-team-builder/champ-select/v1/implementation-active");
        public static Task<LolLobbyTeamBuilderChampSelectPickableChampions> GetLolLobbyTeamBuilderChampSelectV1PickableChampions()
            => Sender.Request<LolLobbyTeamBuilderChampSelectPickableChampions>("get", $"/lol-lobby-team-builder/champ-select/v1/pickable-champions");
        public static Task<LolLobbyTeamBuilderChampSelectPickableSkins> GetLolLobbyTeamBuilderChampSelectV1PickableSkins()
            => Sender.Request<LolLobbyTeamBuilderChampSelectPickableSkins>("get", $"/lol-lobby-team-builder/champ-select/v1/pickable-skins");
        public static Task<LolLobbyTeamBuilderChampionSelectPreferences> GetLolLobbyTeamBuilderChampSelectV1Preferences()
            => Sender.Request<LolLobbyTeamBuilderChampionSelectPreferences>("get", $"/lol-lobby-team-builder/champ-select/v1/preferences");
        public static Task<object> PostLolLobbyTeamBuilderChampSelectV1RetrieveLatestGameDto()
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/champ-select/v1/retrieve-latest-game-dto");
        public static Task<bool> GetLolLobbyTeamBuilderChampSelectV1SendingLoadoutsGcosEnabled()
            => Sender.Request<bool>("get", $"/lol-lobby-team-builder/champ-select/v1/sending-loadouts-gcos-enabled");
        public static Task<LolLobbyTeamBuilderChampSelectSession> GetLolLobbyTeamBuilderChampSelectV1Session()
            => Sender.Request<LolLobbyTeamBuilderChampSelectSession>("get", $"/lol-lobby-team-builder/champ-select/v1/session");
        public static Task<object> PatchLolLobbyTeamBuilderChampSelectV1SessionActionsById([Parameter("id", "path")] int id, [Parameter("data", "body")] LolLobbyTeamBuilderChampSelectAction data)
            => Sender.Request<object>("patch", $"/lol-lobby-team-builder/champ-select/v1/session/actions/{id}", data);
        public static Task<object> PostLolLobbyTeamBuilderChampSelectV1SessionActionsByIdComplete([Parameter("id", "path")] int id)
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/champ-select/v1/session/actions/{id}/complete");
        public static Task<object> PostLolLobbyTeamBuilderChampSelectV1SessionBenchSwapByChampionId([Parameter("championId", "path")] int championId)
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/champ-select/v1/session/bench/swap/{championId}");
        public static Task<object> PatchLolLobbyTeamBuilderChampSelectV1SessionMySelection([Parameter("selection", "body")] LolLobbyTeamBuilderChampSelectMySelection selection)
            => Sender.Request<object>("patch", $"/lol-lobby-team-builder/champ-select/v1/session/my-selection", selection);
        public static Task<object> PostLolLobbyTeamBuilderChampSelectV1SessionMySelectionReroll()
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/champ-select/v1/session/my-selection/reroll");
        public static Task<LolLobbyTeamBuilderChampSelectTimer> GetLolLobbyTeamBuilderChampSelectV1SessionTimer()
            => Sender.Request<LolLobbyTeamBuilderChampSelectTimer>("get", $"/lol-lobby-team-builder/champ-select/v1/session/timer");
        public static Task<LolLobbyTeamBuilderChampSelectTradeContract[]> GetLolLobbyTeamBuilderChampSelectV1SessionTrades()
            => Sender.Request<LolLobbyTeamBuilderChampSelectTradeContract[]>("get", $"/lol-lobby-team-builder/champ-select/v1/session/trades");
        public static Task<LolLobbyTeamBuilderChampSelectTradeContract> GetLolLobbyTeamBuilderChampSelectV1SessionTradesById([Parameter("id", "path")] long id)
            => Sender.Request<LolLobbyTeamBuilderChampSelectTradeContract>("get", $"/lol-lobby-team-builder/champ-select/v1/session/trades/{id}");
        public static Task<object> PostLolLobbyTeamBuilderChampSelectV1SessionTradesByIdAccept([Parameter("id", "path")] int id)
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/champ-select/v1/session/trades/{id}/accept");
        public static Task<object> PostLolLobbyTeamBuilderChampSelectV1SessionTradesByIdCancel([Parameter("id", "path")] int id)
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/champ-select/v1/session/trades/{id}/cancel");
        public static Task<object> PostLolLobbyTeamBuilderChampSelectV1SessionTradesByIdDecline([Parameter("id", "path")] int id)
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/champ-select/v1/session/trades/{id}/decline");
        public static Task<LolLobbyTeamBuilderChampSelectTradeContract> PostLolLobbyTeamBuilderChampSelectV1SessionTradesByIdRequest([Parameter("id", "path")] int id)
            => Sender.Request<LolLobbyTeamBuilderChampSelectTradeContract>("post", $"/lol-lobby-team-builder/champ-select/v1/session/trades/{id}/request");
        public static Task PostLolLobbyTeamBuilderChampSelectV1SimpleInventory()
            => Sender.Request("post", $"/lol-lobby-team-builder/champ-select/v1/simple-inventory");
        public static Task<LolLobbyTeamBuilderTeamBoost> GetLolLobbyTeamBuilderChampSelectV1TeamBoost()
            => Sender.Request<LolLobbyTeamBuilderTeamBoost>("get", $"/lol-lobby-team-builder/champ-select/v1/team-boost");
        public static Task<object> PostLolLobbyTeamBuilderChampSelectV1TeamBoostPurchase()
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/champ-select/v1/team-boost/purchase");
        public static Task<object> PostLolLobbyTeamBuilderV1InvitationsAccept([Parameter("invitation", "body")] LolLobbyTeamBuilderLobbyInvitation invitation)
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/v1/invitations/accept", invitation);
        public static Task DeleteLolLobbyTeamBuilderV1Lobby()
            => Sender.Request("delete", $"/lol-lobby-team-builder/v1/lobby");
        public static Task<LolLobbyTeamBuilderLobby> GetLolLobbyTeamBuilderV1Lobby()
            => Sender.Request<LolLobbyTeamBuilderLobby>("get", $"/lol-lobby-team-builder/v1/lobby");
        public static Task<LolLobbyTeamBuilderLobby> PostLolLobbyTeamBuilderV1Lobby([Parameter("lobby", "body")] LolLobbyTeamBuilderLobby lobby)
            => Sender.Request<LolLobbyTeamBuilderLobby>("post", $"/lol-lobby-team-builder/v1/lobby", lobby);
        public static Task<LolLobbyTeamBuilderLobbyCountdownTimer> GetLolLobbyTeamBuilderV1LobbyCountdown()
            => Sender.Request<LolLobbyTeamBuilderLobbyCountdownTimer>("get", $"/lol-lobby-team-builder/v1/lobby/countdown");
        public static Task<object> PostLolLobbyTeamBuilderV1LobbyMembersByIdKick([Parameter("id", "path")] long id)
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/v1/lobby/members/{id}/kick");
        public static Task<object> PostLolLobbyTeamBuilderV1LobbyMembersByIdPromote([Parameter("id", "path")] long id)
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/v1/lobby/members/{id}/promote");
        public static Task<LolLobbyTeamBuilderMatchmakingSearchResource> GetLolLobbyTeamBuilderV1Matchmaking()
            => Sender.Request<LolLobbyTeamBuilderMatchmakingSearchResource>("get", $"/lol-lobby-team-builder/v1/matchmaking");
        public static Task<object> PostLolLobbyTeamBuilderV1MatchmakingLowPriorityQueueAbandon([Parameter("leaverBusterToken", "body")] string leaverBusterToken)
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/v1/matchmaking/low-priority-queue/abandon", leaverBusterToken);
        public static Task<LolLobbyTeamBuilderMatchmakingSearchResource> PostLolLobbyTeamBuilderV1MatchmakingSearch([Parameter("leaverBusterToken", "body")] string leaverBusterToken)
            => Sender.Request<LolLobbyTeamBuilderMatchmakingSearchResource>("post", $"/lol-lobby-team-builder/v1/matchmaking/search", leaverBusterToken);
        public static Task<object> PostLolLobbyTeamBuilderV1PositionPreferences([Parameter("positionPreferences", "body")] LolLobbyTeamBuilderLobbyPositionPreferences positionPreferences)
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/v1/position-preferences", positionPreferences);
        public static Task<object> PostLolLobbyTeamBuilderV1ReadyCheckAccept()
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/v1/ready-check/accept");
        public static Task<object> PostLolLobbyTeamBuilderV1ReadyCheckDecline()
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/v1/ready-check/decline");
        public static Task<LolLobbyTeamBuilderTbLobbyEnabledFeaturesResource> GetLolLobbyTeamBuilderV1TbEnabledFeatures()
            => Sender.Request<LolLobbyTeamBuilderTbLobbyEnabledFeaturesResource>("get", $"/lol-lobby-team-builder/v1/tb-enabled-features");
        public static Task<object> PostLolLobbyTeamBuilderV2PositionPreferences([Parameter("positionPreferences", "body")] LolLobbyTeamBuilderLobbyPositionPreferencesV2 positionPreferences)
            => Sender.Request<object>("post", $"/lol-lobby-team-builder/v2/position-preferences", positionPreferences);
    }
}
