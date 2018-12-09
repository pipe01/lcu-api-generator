using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolClash
    {
        public static Task<LolClashBracket> GetLolClashV1BracketByBracketId([Parameter("bracketId", "path")] long bracketId)
            => Sender.Request<LolClashBracket>("get", $"/lol-clash/v1/bracket/{bracketId}");
        public static Task<bool> GetLolClashV1CheckinAllowed()
            => Sender.Request<bool>("get", $"/lol-clash/v1/checkin-allowed");
        public static Task<bool> GetLolClashV1Enabled()
            => Sender.Request<bool>("get", $"/lol-clash/v1/enabled");
        public static Task<LolClashEogPlayerUpdateDTO> GetLolClashV1EogPlayerUpdate()
            => Sender.Request<LolClashEogPlayerUpdateDTO>("get", $"/lol-clash/v1/eogPlayerUpdate");
        public static Task<object> PostLolClashV1EogPlayerUpdateAcknowledge()
            => Sender.Request<object>("post", $"/lol-clash/v1/eogPlayerUpdate/acknowledge");
        public static Task<ClashEventData> GetLolClashV1EventByUuid([Parameter("uuid", "path")] string uuid)
            => Sender.Request<ClashEventData>("get", $"/lol-clash/v1/event/{uuid}");
        public static Task<object> PostLolClashV1Events([Parameter("uuids", "body")] string[] uuids)
            => Sender.Request<object>("post", $"/lol-clash/v1/events", uuids);
        public static Task<LolClashTournamentGameEnd> GetLolClashV1GameEnd()
            => Sender.Request<LolClashTournamentGameEnd>("get", $"/lol-clash/v1/gameEnd");
        public static Task<object> PostLolClashV1GameEndAcknowledge()
            => Sender.Request<object>("post", $"/lol-clash/v1/gameEnd/acknowledge");
        public static Task<LolClashTournamentHistoryAndWinners> GetLolClashV1Historyandwinners()
            => Sender.Request<LolClashTournamentHistoryAndWinners>("get", $"/lol-clash/v1/historyandwinners");
        public static Task<object> GetLolClashV1Iconconfig()
            => Sender.Request<object>("get", $"/lol-clash/v1/iconconfig");
        public static Task<string[]> GetLolClashV1InvitedRosterIds()
            => Sender.Request<string[]>("get", $"/lol-clash/v1/invited-roster-ids");
        public static Task<LolClashPlayerNotificationData> GetLolClashV1Notifications()
            => Sender.Request<LolClashPlayerNotificationData>("get", $"/lol-clash/v1/notifications");
        public static Task<object> PostLolClashV1NotificationsAcknowledge()
            => Sender.Request<object>("post", $"/lol-clash/v1/notifications/acknowledge");
        public static Task<object> GetLolClashV1Ping()
            => Sender.Request<object>("get", $"/lol-clash/v1/ping");
        public static Task<LolClashPlayerData> GetLolClashV1Player()
            => Sender.Request<LolClashPlayerData>("get", $"/lol-clash/v1/player");
        public static Task<LolClashPlayerChatRoster[]> GetLolClashV1PlayerChatRosters()
            => Sender.Request<LolClashPlayerChatRoster[]>("get", $"/lol-clash/v1/player/chat-rosters");
        public static Task<LolClashRosterStats[]> GetLolClashV1PlayerHistory()
            => Sender.Request<LolClashRosterStats[]>("get", $"/lol-clash/v1/player/history");
        public static Task<bool> GetLolClashV1PlaymodeRestricted()
            => Sender.Request<bool>("get", $"/lol-clash/v1/playmode-restricted");
        public static Task<bool> GetLolClashV1Ready()
            => Sender.Request<bool>("get", $"/lol-clash/v1/ready");
        public static Task<object> PostLolClashV1Refresh()
            => Sender.Request<object>("post", $"/lol-clash/v1/refresh");
        public static Task<LolClashPlayerRewards> GetLolClashV1Rewards()
            => Sender.Request<LolClashPlayerRewards>("get", $"/lol-clash/v1/rewards");
        public static Task<LolClashRoster> GetLolClashV1RosterByRosterId([Parameter("rosterId", "path")] string rosterId)
            => Sender.Request<LolClashRoster>("get", $"/lol-clash/v1/roster/{rosterId}");
        public static Task<object> PostLolClashV1RosterByRosterIdAccept([Parameter("rosterId", "path")] string rosterId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/accept");
        public static Task<object> PostLolClashV1RosterByRosterIdCancelWithdraw([Parameter("rosterId", "path")] string rosterId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/cancel-withdraw");
        public static Task<object> PostLolClashV1RosterByRosterIdChangeAllDetails([Parameter("rosterId", "path")] string rosterId, [Parameter("rosterDetails", "body")] LolClashRosterDetails rosterDetails)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/change-all-details", rosterDetails);
        public static Task<object> PostLolClashV1RosterByRosterIdChangeIcon([Parameter("rosterId", "path")] string rosterId, [Parameter("changeIconRequest", "body")] LolClashChangeIconRequest changeIconRequest)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/change-icon", changeIconRequest);
        public static Task<object> PostLolClashV1RosterByRosterIdChangeName([Parameter("rosterId", "path")] string rosterId, [Parameter("changeNameRequest", "body")] LolClashChangeNameRequest changeNameRequest)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/change-name", changeNameRequest);
        public static Task<object> PostLolClashV1RosterByRosterIdChangeShortName([Parameter("rosterId", "path")] string rosterId, [Parameter("changeNameRequest", "body")] LolClashChangeNameRequest changeNameRequest)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/change-short-name", changeNameRequest);
        public static Task<object> PostLolClashV1RosterByRosterIdDecline([Parameter("rosterId", "path")] string rosterId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/decline");
        public static Task<object> PostLolClashV1RosterByRosterIdDisband([Parameter("rosterId", "path")] string rosterId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/disband");
        public static Task<LolClashClientFailedInvite[]> PostLolClashV1RosterByRosterIdInvite([Parameter("rosterId", "path")] string rosterId, [Parameter("summonerIds", "body")] long[] summonerIds)
            => Sender.Request<LolClashClientFailedInvite[]>("post", $"/lol-clash/v1/roster/{rosterId}/invite", summonerIds);
        public static Task<object> PostLolClashV1RosterByRosterIdKick([Parameter("rosterId", "path")] string rosterId, [Parameter("kickRequest", "body")] LolClashKickRequest kickRequest)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/kick", kickRequest);
        public static Task<object> PostLolClashV1RosterByRosterIdLeave([Parameter("rosterId", "path")] string rosterId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/leave");
        public static Task<object> PostLolClashV1RosterByRosterIdLockin([Parameter("rosterId", "path")] string rosterId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/lockin");
        public static Task<object> PostLolClashV1RosterByRosterIdSetPosition([Parameter("rosterId", "path")] string rosterId, [Parameter("setPositionRequest", "body")] LolClashSetPositionRequest setPositionRequest)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/set-position", setPositionRequest);
        public static Task<object> PostLolClashV1RosterByRosterIdSetTicket([Parameter("rosterId", "path")] string rosterId, [Parameter("setTicketRequest", "body")] LolClashSetTicketRequest setTicketRequest)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/set-ticket", setTicketRequest);
        public static Task<LolClashRosterStats> GetLolClashV1RosterByRosterIdStats([Parameter("rosterId", "path")] long rosterId)
            => Sender.Request<LolClashRosterStats>("get", $"/lol-clash/v1/roster/{rosterId}/stats");
        public static Task<object> PostLolClashV1RosterByRosterIdSubstituteAccept([Parameter("rosterId", "path")] string rosterId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/substitute/accept");
        public static Task<object> PostLolClashV1RosterByRosterIdSubstituteDecline([Parameter("rosterId", "path")] string rosterId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/substitute/decline");
        public static Task<LolClashClientFailedInvite[]> PostLolClashV1RosterByRosterIdSubstituteInvite([Parameter("rosterId", "path")] string rosterId, [Parameter("inviteSubRequest", "body")] LolClashInviteSubRequest inviteSubRequest)
            => Sender.Request<LolClashClientFailedInvite[]>("post", $"/lol-clash/v1/roster/{rosterId}/substitute/invite", inviteSubRequest);
        public static Task<object> PostLolClashV1RosterByRosterIdSubstituteReclaim([Parameter("rosterId", "path")] string rosterId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/substitute/reclaim");
        public static Task<object> PostLolClashV1RosterByRosterIdSubstituteBySummonerIdRevoke([Parameter("rosterId", "path")] string rosterId, [Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/substitute/{summonerId}/revoke");
        public static Task<object> PostLolClashV1RosterByRosterIdTicketOfferBySummonerIdAccept([Parameter("rosterId", "path")] string rosterId, [Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/ticket-offer/{summonerId}/accept");
        public static Task<object> PostLolClashV1RosterByRosterIdTicketOfferBySummonerIdDecline([Parameter("rosterId", "path")] string rosterId, [Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/ticket-offer/{summonerId}/decline");
        public static Task<object> PostLolClashV1RosterByRosterIdTicketOfferBySummonerIdOffer([Parameter("rosterId", "path")] string rosterId, [Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/ticket-offer/{summonerId}/offer");
        public static Task<object> PostLolClashV1RosterByRosterIdTicketOfferBySummonerIdRevoke([Parameter("rosterId", "path")] string rosterId, [Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/ticket-offer/{summonerId}/revoke");
        public static Task<object> PostLolClashV1RosterByRosterIdTransferCaptain([Parameter("rosterId", "path")] string rosterId, [Parameter("newCaptainSummonerId", "body")] long newCaptainSummonerId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/transfer-captain", newCaptainSummonerId);
        public static Task<object> PostLolClashV1RosterByRosterIdUnlockin([Parameter("rosterId", "path")] string rosterId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/unlockin");
        public static Task<object> PostLolClashV1RosterByRosterIdUnwithdraw([Parameter("rosterId", "path")] string rosterId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/unwithdraw");
        public static Task<object> PostLolClashV1RosterByRosterIdUpdateLogos([Parameter("rosterId", "path")] string rosterId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/update-logos");
        public static Task<object> PostLolClashV1RosterByRosterIdWithdraw([Parameter("rosterId", "path")] string rosterId)
            => Sender.Request<object>("post", $"/lol-clash/v1/roster/{rosterId}/withdraw");
        public static Task<LolClashScoutingChampions[]> GetLolClashV1ScoutingChampions([Parameter("summonerIds", "query")] long[] summonerIds)
            => Sender.Request<LolClashScoutingChampions[]>("get", $"/lol-clash/v1/scouting/champions?summonerIds={System.Net.WebUtility.UrlEncode(summonerIds.ToString())}");
        public static Task<object> GetLolClashV1ScoutingMatchhistory([Parameter("summonerIds", "query")] long[] summonerIds)
            => Sender.Request<object>("get", $"/lol-clash/v1/scouting/matchhistory?summonerIds={System.Net.WebUtility.UrlEncode(summonerIds.ToString())}");
        public static Task<object> PostLolClashV1SimpleStateFlagsByIdAcknowledge([Parameter("id", "path")] string id)
            => Sender.Request<object>("post", $"/lol-clash/v1/simple-state-flags/{id}/acknowledge");
        public static Task<LolClashThirdPartyApiRoster> GetLolClashV1ThirdpartyTeamData()
            => Sender.Request<LolClashThirdPartyApiRoster>("get", $"/lol-clash/v1/thirdparty/team-data");
        public static Task<long> GetLolClashV1Time()
            => Sender.Request<long>("get", $"/lol-clash/v1/time");
        public static Task<LolClashTournamentStateInfo[]> GetLolClashV1TournamentStateInfo()
            => Sender.Request<LolClashTournamentStateInfo[]>("get", $"/lol-clash/v1/tournament-state-info");
        public static Task<LolClashTournamentSummary[]> GetLolClashV1TournamentSummary()
            => Sender.Request<LolClashTournamentSummary[]>("get", $"/lol-clash/v1/tournament-summary");
        public static Task<long[]> GetLolClashV1TournamentCancelled()
            => Sender.Request<long[]>("get", $"/lol-clash/v1/tournament/cancelled");
        public static Task<LolClashTournament> GetLolClashV1TournamentByTournamentId([Parameter("tournamentId", "path")] long tournamentId)
            => Sender.Request<LolClashTournament>("get", $"/lol-clash/v1/tournament/{tournamentId}");
        public static Task<object> PostLolClashV1TournamentByTournamentIdCreateRoster([Parameter("tournamentId", "path")] long tournamentId, [Parameter("rosterDetails", "body")] LolClashRosterDetails rosterDetails)
            => Sender.Request<object>("post", $"/lol-clash/v1/tournament/{tournamentId}/create-roster", rosterDetails);
        public static Task<LolClashPlayerTournamentData> GetLolClashV1TournamentByTournamentIdPlayer([Parameter("tournamentId", "path")] long tournamentId)
            => Sender.Request<LolClashPlayerTournamentData>("get", $"/lol-clash/v1/tournament/{tournamentId}/player");
        public static Task<bool> GetLolClashV1TournamentByTournamentIdPlayerHonorRestricted([Parameter("tournamentId", "path")] long tournamentId)
            => Sender.Request<bool>("get", $"/lol-clash/v1/tournament/{tournamentId}/player-honor-restricted");
        public static Task<LolClashTournamentStateInfo> GetLolClashV1TournamentByTournamentIdStateInfo([Parameter("tournamentId", "path")] long tournamentId)
            => Sender.Request<LolClashTournamentStateInfo>("get", $"/lol-clash/v1/tournament/{tournamentId}/stateInfo");
        public static Task<LolClashTournamentWinnerHistory> GetLolClashV1TournamentByTournamentIdWinners([Parameter("tournamentId", "path")] long tournamentId)
            => Sender.Request<LolClashTournamentWinnerHistory>("get", $"/lol-clash/v1/tournament/{tournamentId}/winners");
        public static Task<long[]> GetLolClashV1TournamentIds()
            => Sender.Request<long[]>("get", $"/lol-clash/v1/tournamentIds");
        public static Task<object> PostLolClashV1UpdateLogos()
            => Sender.Request<object>("post", $"/lol-clash/v1/update-logos");
        public static Task<bool> GetLolClashV1Visible()
            => Sender.Request<bool>("get", $"/lol-clash/v1/visible");
        public static Task<object> DeleteLolClashV1Voice()
            => Sender.Request<object>("delete", $"/lol-clash/v1/voice");
        public static Task<object> PostLolClashV1Voice()
            => Sender.Request<object>("post", $"/lol-clash/v1/voice");
        public static Task<object> DeleteLolClashV1VoiceDelayByDelaySeconds([Parameter("delaySeconds", "path")] float delaySeconds)
            => Sender.Request<object>("delete", $"/lol-clash/v1/voice-delay/{delaySeconds}");
        public static Task<object> PostLolClashV1VoiceDelayByDelaySeconds([Parameter("delaySeconds", "path")] float delaySeconds)
            => Sender.Request<object>("post", $"/lol-clash/v1/voice-delay/{delaySeconds}");
        public static Task<bool> GetLolClashV1VoiceEnabled()
            => Sender.Request<bool>("get", $"/lol-clash/v1/voice-enabled");
        public static Task<LolClashPlaymodeRestrictedInfo> GetLolClashV2PlaymodeRestricted()
            => Sender.Request<LolClashPlaymodeRestrictedInfo>("get", $"/lol-clash/v2/playmode-restricted");
    }
}
