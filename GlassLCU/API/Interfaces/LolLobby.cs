using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolLobby
    {
        public static Task<bool> GetLolLobbyV1AutofillDisplayed()
            => Sender.Request<bool>("get", $"/lol-lobby/v1/autofill-displayed");
        public static Task<bool> PutLolLobbyV1AutofillDisplayed()
            => Sender.Request<bool>("put", $"/lol-lobby/v1/autofill-displayed");
        public static Task<object> DeleteLolLobbyV1Clash()
            => Sender.Request<object>("delete", $"/lol-lobby/v1/clash");
        public static Task<object> PostLolLobbyV1Clash([Parameter("token", "body")] string token)
            => Sender.Request<object>("post", $"/lol-lobby/v1/clash", token);
        public static Task<LolLobbyLobbyCustomGame[]> GetLolLobbyV1CustomGames()
            => Sender.Request<LolLobbyLobbyCustomGame[]>("get", $"/lol-lobby/v1/custom-games");
        public static Task<object> PostLolLobbyV1CustomGamesRefresh()
            => Sender.Request<object>("post", $"/lol-lobby/v1/custom-games/refresh");
        public static Task<LolLobbyLobbyCustomGame> GetLolLobbyV1CustomGamesById([Parameter("id", "path")] int id)
            => Sender.Request<LolLobbyLobbyCustomGame>("get", $"/lol-lobby/v1/custom-games/{id}");
        public static Task<object> PostLolLobbyV1CustomGamesByIdJoin([Parameter("id", "path")] long id, [Parameter("parameters", "body")] LolLobbyLobbyCustomJoinParameters parameters)
            => Sender.Request<object>("post", $"/lol-lobby/v1/custom-games/{id}/join", parameters);
        public static Task<LolLobbyQueueAvailability> GetLolLobbyV1LobbyAvailability()
            => Sender.Request<LolLobbyQueueAvailability>("get", $"/lol-lobby/v1/lobby/availability");
        public static Task<long> GetLolLobbyV1LobbyCountdown()
            => Sender.Request<long>("get", $"/lol-lobby/v1/lobby/countdown");
        public static Task<object> PostLolLobbyV1LobbyCustomBots([Parameter("parameters", "body")] LolLobbyLobbyBotParams parameters)
            => Sender.Request<object>("post", $"/lol-lobby/v1/lobby/custom/bots", parameters);
        public static Task<object> DeleteLolLobbyV1LobbyCustomBotsBySummonerInternalName([Parameter("summonerInternalName", "path")] string summonerInternalName)
            => Sender.Request<object>("delete", $"/lol-lobby/v1/lobby/custom/bots/{summonerInternalName}");
        public static Task<object> PostLolLobbyV1LobbyCustomBotsBySummonerInternalName([Parameter("summonerInternalName", "path")] string summonerInternalName, [Parameter("parameters", "body")] LolLobbyLobbyBotParams parameters)
            => Sender.Request<object>("post", $"/lol-lobby/v1/lobby/custom/bots/{summonerInternalName}", parameters);
        public static Task<object> PostLolLobbyV1LobbyCustomCancelChampSelect()
            => Sender.Request<object>("post", $"/lol-lobby/v1/lobby/custom/cancel-champ-select");
        public static Task<LolLobbyLobbyCustomChampSelectStartResponse> PostLolLobbyV1LobbyCustomStartChampSelect()
            => Sender.Request<LolLobbyLobbyCustomChampSelectStartResponse>("post", $"/lol-lobby/v1/lobby/custom/start-champ-select");
        public static Task<object> PostLolLobbyV1LobbyCustomSwitchTeams([Parameter("team", "query")] string team = default)
            => Sender.Request<object>("post", $"/lol-lobby/v1/lobby/custom/switch-teams?{(team != default ? $"team={System.Net.WebUtility.UrlEncode(team.ToString())}" : null)}");
        public static Task<LolLobbyLobbyInvitation[]> GetLolLobbyV1LobbyInvitations()
            => Sender.Request<LolLobbyLobbyInvitation[]>("get", $"/lol-lobby/v1/lobby/invitations");
        public static Task<LolLobbyLobbyInvitation> PostLolLobbyV1LobbyInvitations([Parameter("invitation", "body")] LolLobbyLobbyInvitation invitation)
            => Sender.Request<LolLobbyLobbyInvitation>("post", $"/lol-lobby/v1/lobby/invitations", invitation);
        public static Task<LolLobbyLobbyInvitation> GetLolLobbyV1LobbyInvitationsById([Parameter("id", "path")] string id)
            => Sender.Request<LolLobbyLobbyInvitation>("get", $"/lol-lobby/v1/lobby/invitations/{id}");
        public static Task<object> PutLolLobbyV1LobbyMembersLocalMemberPositionPreferences([Parameter("positionPreferences", "body")] LolLobbyLobbyPositionPreferences positionPreferences)
            => Sender.Request<object>("put", $"/lol-lobby/v1/lobby/members/localMember/position-preferences", positionPreferences);
        public static Task PutLolLobbyV1PartiesActive([Parameter("active", "body")] int active)
            => Sender.Request("put", $"/lol-lobby/v1/parties/active", active);
        public static Task<string> GetLolLobbyV1PartiesHealth()
            => Sender.Request<string>("get", $"/lol-lobby/v1/parties/health");
        public static Task PutLolLobbyV1PartiesMetadata([Parameter("metadata", "body")] LolLobbyPartyMemberMetadataDto metadata)
            => Sender.Request("put", $"/lol-lobby/v1/parties/metadata", metadata);
        public static Task<LolLobbyPlayerDto> GetLolLobbyV1PartiesPlayer()
            => Sender.Request<LolLobbyPlayerDto>("get", $"/lol-lobby/v1/parties/player");
        public static Task PutLolLobbyV1PartiesQueue([Parameter("queueId", "body")] int queueId)
            => Sender.Request("put", $"/lol-lobby/v1/parties/queue", queueId);
        public static Task PutLolLobbyV1PartiesReady([Parameter("ready", "body")] int ready)
            => Sender.Request("put", $"/lol-lobby/v1/parties/ready", ready);
        public static Task PutLolLobbyV1PartiesByPartyIdMembersByPuuidRole([Parameter("partyId", "path")] string partyId, [Parameter("puuid", "path")] string puuid, [Parameter("role", "body")] string role)
            => Sender.Request("put", $"/lol-lobby/v1/parties/{partyId}/members/{puuid}/role", role);
        public static Task<LolLobbyLobbyPartyRewards> GetLolLobbyV1PartyRewards()
            => Sender.Request<LolLobbyLobbyPartyRewards>("get", $"/lol-lobby/v1/party-rewards");
        public static Task<object> PostLolLobbyV1TournamentsByIdJoin([Parameter("id", "path")] string id)
            => Sender.Request<object>("post", $"/lol-lobby/v1/tournaments/{id}/join");
        public static Task<LolLobbyPremadePartyDto> GetLolLobbyV2CommsMembers()
            => Sender.Request<LolLobbyPremadePartyDto>("get", $"/lol-lobby/v2/comms/members");
        public static Task<string> GetLolLobbyV2CommsToken()
            => Sender.Request<string>("get", $"/lol-lobby/v2/comms/token");
        public static Task<long> GetLolLobbyV2EligibilityGameSelectEligibilityHash()
            => Sender.Request<long>("get", $"/lol-lobby/v2/eligibility/game-select-eligibility-hash");
        public static Task<bool> GetLolLobbyV2EligibilityInitialConfigurationComplete()
            => Sender.Request<bool>("get", $"/lol-lobby/v2/eligibility/initial-configuration-complete");
        public static Task<LolLobbyEligibility[]> PostLolLobbyV2EligibilityParty()
            => Sender.Request<LolLobbyEligibility[]>("post", $"/lol-lobby/v2/eligibility/party");
        public static Task<LolLobbyEligibility[]> PostLolLobbyV2EligibilitySelf()
            => Sender.Request<LolLobbyEligibility[]>("post", $"/lol-lobby/v2/eligibility/self");
        public static Task<LolLobbyLobbyInvitationDto[]> PostLolLobbyV2EogInvitations([Parameter("invitations", "body")] LolLobbyLobbyInvitationDto[] invitations)
            => Sender.Request<LolLobbyLobbyInvitationDto[]>("post", $"/lol-lobby/v2/eog-invitations", invitations);
        public static Task DeleteLolLobbyV2Lobby()
            => Sender.Request("delete", $"/lol-lobby/v2/lobby");
        public static Task<LolLobbyLobbyDto> GetLolLobbyV2Lobby()
            => Sender.Request<LolLobbyLobbyDto>("get", $"/lol-lobby/v2/lobby");
        public static Task<LolLobbyLobbyDto> PostLolLobbyV2Lobby([Parameter("lobbyChange", "body")] LolLobbyLobbyChangeGameDto lobbyChange)
            => Sender.Request<LolLobbyLobbyDto>("post", $"/lol-lobby/v2/lobby", lobbyChange);
        public static Task<LolLobbyLobbyBotChampion[]> GetLolLobbyV2LobbyCustomAvailableBots()
            => Sender.Request<LolLobbyLobbyBotChampion[]>("get", $"/lol-lobby/v2/lobby/custom/available-bots");
        public static Task<bool> GetLolLobbyV2LobbyCustomBotsEnabled()
            => Sender.Request<bool>("get", $"/lol-lobby/v2/lobby/custom/bots-enabled");
        public static Task<LolLobbyLobbyInvitationDto[]> GetLolLobbyV2LobbyInvitations()
            => Sender.Request<LolLobbyLobbyInvitationDto[]>("get", $"/lol-lobby/v2/lobby/invitations");
        public static Task<LolLobbyLobbyInvitationDto[]> PostLolLobbyV2LobbyInvitations([Parameter("invitations", "body")] LolLobbyLobbyInvitationDto[] invitations)
            => Sender.Request<LolLobbyLobbyInvitationDto[]>("post", $"/lol-lobby/v2/lobby/invitations", invitations);
        public static Task<object> DeleteLolLobbyV2LobbyMatchmakingSearch()
            => Sender.Request<object>("delete", $"/lol-lobby/v2/lobby/matchmaking/search");
        public static Task<object> PostLolLobbyV2LobbyMatchmakingSearch()
            => Sender.Request<object>("post", $"/lol-lobby/v2/lobby/matchmaking/search");
        public static Task<LolLobbyLobbyMatchmakingSearchResource> GetLolLobbyV2LobbyMatchmakingSearchState()
            => Sender.Request<LolLobbyLobbyMatchmakingSearchResource>("get", $"/lol-lobby/v2/lobby/matchmaking/search-state");
        public static Task<LolLobbyLobbyParticipantDto[]> GetLolLobbyV2LobbyMembers()
            => Sender.Request<LolLobbyLobbyParticipantDto[]>("get", $"/lol-lobby/v2/lobby/members");
        public static Task<object> PutLolLobbyV2LobbyMembersLocalMemberPositionPreferences([Parameter("positionPreferences", "body")] LolLobbyLobbyPositionPreferences positionPreferences)
            => Sender.Request<object>("put", $"/lol-lobby/v2/lobby/members/localMember/position-preferences", positionPreferences);
        public static Task<long> PostLolLobbyV2LobbyMembersBySummonerIdGrantInvite([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<long>("post", $"/lol-lobby/v2/lobby/members/{summonerId}/grant-invite");
        public static Task<long> PostLolLobbyV2LobbyMembersBySummonerIdKick([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<long>("post", $"/lol-lobby/v2/lobby/members/{summonerId}/kick");
        public static Task<long> PostLolLobbyV2LobbyMembersBySummonerIdPromote([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<long>("post", $"/lol-lobby/v2/lobby/members/{summonerId}/promote");
        public static Task<long> PostLolLobbyV2LobbyMembersBySummonerIdRevokeInvite([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<long>("post", $"/lol-lobby/v2/lobby/members/{summonerId}/revoke-invite");
        public static Task<object> PutLolLobbyV2LobbyPartyType([Parameter("partyType", "body")] string partyType)
            => Sender.Request<object>("put", $"/lol-lobby/v2/lobby/partyType", partyType);
        public static Task<object> PostLolLobbyV2MatchmakingQuickSearch([Parameter("lobbyChange", "body")] LolLobbyLobbyChangeGameDto lobbyChange)
            => Sender.Request<object>("post", $"/lol-lobby/v2/matchmaking/quick-search", lobbyChange);
        public static Task<LolLobbyLobbyNotification[]> GetLolLobbyV2Notifications()
            => Sender.Request<LolLobbyLobbyNotification[]>("get", $"/lol-lobby/v2/notifications");
        public static Task PostLolLobbyV2Notifications([Parameter("notification", "body")] LolLobbyLobbyNotification notification)
            => Sender.Request("post", $"/lol-lobby/v2/notifications", notification);
        public static Task<object> DeleteLolLobbyV2NotificationsByNotificationId([Parameter("notificationId", "path")] string notificationId)
            => Sender.Request<object>("delete", $"/lol-lobby/v2/notifications/{notificationId}");
        public static Task PostLolLobbyV2PartiesOverridesEnabled([Parameter("enabled", "query")] bool enabled)
            => Sender.Request("post", $"/lol-lobby/v2/parties/overrides/Enabled?enabled={System.Net.WebUtility.UrlEncode(enabled.ToString())}");
        public static Task PostLolLobbyV2PartiesOverridesEnabledForTeamBuilderQueues([Parameter("enabledForTeambuilderQueues", "query")] bool enabledForTeambuilderQueues)
            => Sender.Request("post", $"/lol-lobby/v2/parties/overrides/EnabledForTeamBuilderQueues?enabledForTeambuilderQueues={System.Net.WebUtility.UrlEncode(enabledForTeambuilderQueues.ToString())}");
        public static Task<bool> GetLolLobbyV2PartyActive()
            => Sender.Request<bool>("get", $"/lol-lobby/v2/party-active");
        public static Task<LolLobbyPartyStatusDto> GetLolLobbyV2PartyEogStatus()
            => Sender.Request<LolLobbyPartyStatusDto>("get", $"/lol-lobby/v2/party/eog-status");
        public static Task<object> PostLolLobbyV2PartyByPartyIdJoin([Parameter("partyId", "path")] string partyId)
            => Sender.Request<object>("post", $"/lol-lobby/v2/party/{partyId}/join");
        public static Task<object> PostLolLobbyV2PlayAgain()
            => Sender.Request<object>("post", $"/lol-lobby/v2/play-again");
        public static Task<object> PostLolLobbyV2PlayAgainDecline()
            => Sender.Request<object>("post", $"/lol-lobby/v2/play-again-decline");
        public static Task<LolLobbyReceivedInvitationDto[]> GetLolLobbyV2ReceivedInvitations()
            => Sender.Request<LolLobbyReceivedInvitationDto[]>("get", $"/lol-lobby/v2/received-invitations");
        public static Task PostLolLobbyV2ReceivedInvitationsByInvitationIdAccept([Parameter("invitationId", "path")] string invitationId)
            => Sender.Request("post", $"/lol-lobby/v2/received-invitations/{invitationId}/accept");
        public static Task PostLolLobbyV2ReceivedInvitationsByInvitationIdDecline([Parameter("invitationId", "path")] string invitationId)
            => Sender.Request("post", $"/lol-lobby/v2/received-invitations/{invitationId}/decline");
    }
}
