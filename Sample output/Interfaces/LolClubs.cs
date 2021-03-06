//Auto-generated by https://github.com/pipe01/lcu-api-generator
using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;
using System.Reflection;

namespace GlassLCU.API.Interfaces
{
    public static class LolClubs
    {
        /// <summary>
        /// <para>GET /lol-clubs/v1/clubs</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs")]
        public static Task<LolClubsPlayerClub[]> GetLolClubsV1Clubs()
            => Sender.Request<LolClubsPlayerClub[]>("get", $"/lol-clubs/v1/clubs");
        /// <summary>
        /// <para>GET /lol-clubs/v1/clubs/invitations</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/invitations")]
        public static Task<LolClubsClubInvite[]> GetLolClubsV1ClubsInvitations()
            => Sender.Request<LolClubsClubInvite[]>("get", $"/lol-clubs/v1/clubs/invitations");
        /// <summary>
        /// <para>PATCH /lol-clubs/v1/clubs/invitations</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/invitations")]
        public static Task<LolClubsPlayerClubMembership> PatchLolClubsV1ClubsInvitations([Parameter("invitation", "body")] LolClubsClubInvite invitation)
            => Sender.Request<LolClubsPlayerClubMembership>("patch", $"/lol-clubs/v1/clubs/invitations", invitation);
        /// <summary>
        /// <para>GET /lol-clubs/v1/clubs/membership</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/membership")]
        public static Task<LolClubsPlayerClubMembership> GetLolClubsV1ClubsMembership()
            => Sender.Request<LolClubsPlayerClubMembership>("get", $"/lol-clubs/v1/clubs/membership");
        /// <summary>
        /// <para>POST /lol-clubs/v1/clubs/membership</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/membership")]
        public static Task<LolClubsPlayerClub> PostLolClubsV1ClubsMembership([Parameter("name", "body")] LolClubsClubName name)
            => Sender.Request<LolClubsPlayerClub>("post", $"/lol-clubs/v1/clubs/membership", name);
        /// <summary>
        /// <para>GET /lol-clubs/v1/clubs/membership/preferences</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/membership/preferences")]
        public static Task<LolClubsClubPreferences> GetLolClubsV1ClubsMembershipPreferences()
            => Sender.Request<LolClubsClubPreferences>("get", $"/lol-clubs/v1/clubs/membership/preferences");
        /// <summary>
        /// <para>PATCH /lol-clubs/v1/clubs/membership/preferences</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/membership/preferences")]
        public static Task<LolClubsClubPreferences> PatchLolClubsV1ClubsMembershipPreferences([Parameter("preferences", "body")] LolClubsClubPreferences preferences)
            => Sender.Request<LolClubsClubPreferences>("patch", $"/lol-clubs/v1/clubs/membership/preferences", preferences);
        /// <summary>
        /// <para>DELETE /lol-clubs/v1/clubs/{clubKey}</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}")]
        public static Task<LolClubsPlayerClubMembership> DeleteLolClubsV1ClubsByClubKey([Parameter("clubKey", "path")] string clubKey)
            => Sender.Request<LolClubsPlayerClubMembership>("delete", $"/lol-clubs/v1/clubs/{clubKey}");
        /// <summary>
        /// <para>GET /lol-clubs/v1/clubs/{clubKey}</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}")]
        public static Task<LolClubsPlayerClub> GetLolClubsV1ClubsByClubKey([Parameter("clubKey", "path")] string clubKey)
            => Sender.Request<LolClubsPlayerClub>("get", $"/lol-clubs/v1/clubs/{clubKey}");
        /// <summary>
        /// <para>PATCH /lol-clubs/v1/clubs/{clubKey}</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}")]
        public static Task<LolClubsPlayerClub> PatchLolClubsV1ClubsByClubKey([Parameter("clubKey", "path")] string clubKey, [Parameter("tag", "body")] LolClubsClubTag tag)
            => Sender.Request<LolClubsPlayerClub>("patch", $"/lol-clubs/v1/clubs/{clubKey}", tag);
        /// <summary>
        /// <para>GET /lol-clubs/v1/clubs/{clubKey}/invitations</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}/invitations")]
        public static Task<LolClubsClubMember[]> GetLolClubsV1ClubsByClubKeyInvitations([Parameter("clubKey", "path")] string clubKey)
            => Sender.Request<LolClubsClubMember[]>("get", $"/lol-clubs/v1/clubs/{clubKey}/invitations");
        /// <summary>
        /// <para>DELETE /lol-clubs/v1/clubs/{clubKey}/invitations/{summonerId}</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}/invitations/{summonerId}")]
        public static Task<LolClubsClubMemberLists> DeleteLolClubsV1ClubsByClubKeyInvitationsBySummonerId([Parameter("clubKey", "path")] string clubKey, [Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolClubsClubMemberLists>("delete", $"/lol-clubs/v1/clubs/{clubKey}/invitations/{summonerId}");
        /// <summary>
        /// <para>POST /lol-clubs/v1/clubs/{clubKey}/invitations/{summonerId}</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}/invitations/{summonerId}")]
        public static Task<LolClubsClubMemberLists> PostLolClubsV1ClubsByClubKeyInvitationsBySummonerId([Parameter("clubKey", "path")] string clubKey, [Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolClubsClubMemberLists>("post", $"/lol-clubs/v1/clubs/{clubKey}/invitations/{summonerId}");
        /// <summary>
        /// <para>GET /lol-clubs/v1/clubs/{clubKey}/members</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}/members")]
        public static Task<LolClubsClubMember[]> GetLolClubsV1ClubsByClubKeyMembers([Parameter("clubKey", "path")] string clubKey)
            => Sender.Request<LolClubsClubMember[]>("get", $"/lol-clubs/v1/clubs/{clubKey}/members");
        /// <summary>
        /// <para>DELETE /lol-clubs/v1/clubs/{clubKey}/members/{summonerId}</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}/members/{summonerId}")]
        public static Task<LolClubsClubMemberLists> DeleteLolClubsV1ClubsByClubKeyMembersBySummonerId([Parameter("clubKey", "path")] string clubKey, [Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolClubsClubMemberLists>("delete", $"/lol-clubs/v1/clubs/{clubKey}/members/{summonerId}");
        /// <summary>
        /// <para>POST /lol-clubs/v1/clubs/{clubKey}/members/{summonerId}</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}/members/{summonerId}")]
        public static Task<LolClubsPlayerClub> PostLolClubsV1ClubsByClubKeyMembersBySummonerId([Parameter("clubKey", "path")] string clubKey, [Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolClubsPlayerClub>("post", $"/lol-clubs/v1/clubs/{clubKey}/members/{summonerId}");
        /// <summary>
        /// <para>GET /lol-clubs/v1/clubs/{clubKey}/motd</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}/motd")]
        public static Task<string> GetLolClubsV1ClubsByClubKeyMotd([Parameter("clubKey", "path")] string clubKey)
            => Sender.Request<string>("get", $"/lol-clubs/v1/clubs/{clubKey}/motd");
        /// <summary>
        /// <para>PATCH /lol-clubs/v1/clubs/{clubKey}/motd</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}/motd")]
        public static Task<LolClubsPlayerClub> PatchLolClubsV1ClubsByClubKeyMotd([Parameter("clubKey", "path")] string clubKey, [Parameter("motd", "body")] LolClubsClubMOTD motd)
            => Sender.Request<LolClubsPlayerClub>("patch", $"/lol-clubs/v1/clubs/{clubKey}/motd", motd);
        /// <summary>
        /// <para>GET /lol-clubs/v1/clubs/{clubKey}/nominations</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}/nominations")]
        public static Task<LolClubsClubMember[]> GetLolClubsV1ClubsByClubKeyNominations([Parameter("clubKey", "path")] string clubKey)
            => Sender.Request<LolClubsClubMember[]>("get", $"/lol-clubs/v1/clubs/{clubKey}/nominations");
        /// <summary>
        /// <para>DELETE /lol-clubs/v1/clubs/{clubKey}/nominations/{summonerId}</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}/nominations/{summonerId}")]
        public static Task<LolClubsClubMemberLists> DeleteLolClubsV1ClubsByClubKeyNominationsBySummonerId([Parameter("clubKey", "path")] string clubKey, [Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolClubsClubMemberLists>("delete", $"/lol-clubs/v1/clubs/{clubKey}/nominations/{summonerId}");
        /// <summary>
        /// <para>POST /lol-clubs/v1/clubs/{clubKey}/nominations/{summonerId}</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}/nominations/{summonerId}")]
        public static Task<LolClubsClubMemberLists> PostLolClubsV1ClubsByClubKeyNominationsBySummonerId([Parameter("clubKey", "path")] string clubKey, [Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolClubsClubMemberLists>("post", $"/lol-clubs/v1/clubs/{clubKey}/nominations/{summonerId}");
        /// <summary>
        /// <para>DELETE /lol-clubs/v1/clubs/{clubKey}/promotions/{summonerId}</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}/promotions/{summonerId}")]
        public static Task<LolClubsClubMemberLists> DeleteLolClubsV1ClubsByClubKeyPromotionsBySummonerId([Parameter("clubKey", "path")] string clubKey, [Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolClubsClubMemberLists>("delete", $"/lol-clubs/v1/clubs/{clubKey}/promotions/{summonerId}");
        /// <summary>
        /// <para>POST /lol-clubs/v1/clubs/{clubKey}/promotions/{summonerId}</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}/promotions/{summonerId}")]
        public static Task<LolClubsClubMemberLists> PostLolClubsV1ClubsByClubKeyPromotionsBySummonerId([Parameter("clubKey", "path")] string clubKey, [Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolClubsClubMemberLists>("post", $"/lol-clubs/v1/clubs/{clubKey}/promotions/{summonerId}");
        /// <summary>
        /// <para>POST /lol-clubs/v1/clubs/{clubKey}/view</para>
        /// </summary>
        [Endpoint("/lol-clubs/v1/clubs/{clubKey}/view")]
        public static Task<object> PostLolClubsV1ClubsByClubKeyView([Parameter("clubKey", "path")] string clubKey)
            => Sender.Request<object>("post", $"/lol-clubs/v1/clubs/{clubKey}/view");

        public static string GetURL(string methodName)
        {
            return typeof(LolClubs).GetMethod(methodName).GetCustomAttribute<EndpointAttribute>().URL;
        }
    }
}
