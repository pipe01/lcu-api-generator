using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolChat
    {
        public static Task<LolChatBlockedPlayerResource[]> GetLolChatV1BlockedPlayers()
            => Sender.Request<LolChatBlockedPlayerResource[]>("get", $"/lol-chat/v1/blocked-players");
        public static Task<object> PostLolChatV1BlockedPlayers([Parameter("blocked", "body")] LolChatBlockedPlayerResource blocked)
            => Sender.Request<object>("post", $"/lol-chat/v1/blocked-players", blocked);
        public static Task<object> DeleteLolChatV1BlockedPlayersById([Parameter("id", "path")] long id)
            => Sender.Request<object>("delete", $"/lol-chat/v1/blocked-players/{id}");
        public static Task<LolChatBlockedPlayerResource> GetLolChatV1BlockedPlayersById([Parameter("id", "path")] long id)
            => Sender.Request<LolChatBlockedPlayerResource>("get", $"/lol-chat/v1/blocked-players/{id}");
        public static Task<LolChatChatServiceDynamicClientConfig> GetLolChatV1Config()
            => Sender.Request<LolChatChatServiceDynamicClientConfig>("get", $"/lol-chat/v1/config");
        public static Task<LolChatConversationResource[]> GetLolChatV1Conversations()
            => Sender.Request<LolChatConversationResource[]>("get", $"/lol-chat/v1/conversations");
        public static Task<LolChatConversationResource> PostLolChatV1Conversations([Parameter("conversation", "body")] LolChatConversationResource conversation)
            => Sender.Request<LolChatConversationResource>("post", $"/lol-chat/v1/conversations", conversation);
        public static Task<object> DeleteLolChatV1ConversationsActive()
            => Sender.Request<object>("delete", $"/lol-chat/v1/conversations/active");
        public static Task<LolChatActiveConversationResource> GetLolChatV1ConversationsActive()
            => Sender.Request<LolChatActiveConversationResource>("get", $"/lol-chat/v1/conversations/active");
        public static Task<object> PutLolChatV1ConversationsActive([Parameter("activeConversation", "body")] LolChatActiveConversationResource activeConversation)
            => Sender.Request<object>("put", $"/lol-chat/v1/conversations/active", activeConversation);
        public static Task<string> GetLolChatV1ConversationsNotify()
            => Sender.Request<string>("get", $"/lol-chat/v1/conversations/notify");
        public static Task<object> DeleteLolChatV1ConversationsById([Parameter("id", "path")] string id)
            => Sender.Request<object>("delete", $"/lol-chat/v1/conversations/{id}");
        public static Task<LolChatConversationResource> GetLolChatV1ConversationsById([Parameter("id", "path")] string id)
            => Sender.Request<LolChatConversationResource>("get", $"/lol-chat/v1/conversations/{id}");
        public static Task<LolChatConversationResource> PutLolChatV1ConversationsById([Parameter("id", "path")] string id, [Parameter("updatedConversation", "body")] LolChatConversationResource updatedConversation)
            => Sender.Request<LolChatConversationResource>("put", $"/lol-chat/v1/conversations/{id}", updatedConversation);
        public static Task<object> PostLolChatV1ConversationsByIdClosed([Parameter("id", "path")] string id)
            => Sender.Request<object>("post", $"/lol-chat/v1/conversations/{id}/closed");
        public static Task<object> PutLolChatV1ConversationsByIdClosed([Parameter("id", "path")] string id)
            => Sender.Request<object>("put", $"/lol-chat/v1/conversations/{id}/closed");
        public static Task<object> DeleteLolChatV1ConversationsByIdMessages([Parameter("id", "path")] string id)
            => Sender.Request<object>("delete", $"/lol-chat/v1/conversations/{id}/messages");
        public static Task<LolChatConversationMessageResource[]> GetLolChatV1ConversationsByIdMessages([Parameter("id", "path")] string id)
            => Sender.Request<LolChatConversationMessageResource[]>("get", $"/lol-chat/v1/conversations/{id}/messages");
        public static Task<LolChatConversationMessageResource> PostLolChatV1ConversationsByIdMessages([Parameter("id", "path")] string id, [Parameter("body", "body")] LolChatConversationMessageResource body)
            => Sender.Request<LolChatConversationMessageResource>("post", $"/lol-chat/v1/conversations/{id}/messages", body);
        public static Task<LolChatUserResource[]> GetLolChatV1ConversationsByIdParticipants([Parameter("id", "path")] string id)
            => Sender.Request<LolChatUserResource[]>("get", $"/lol-chat/v1/conversations/{id}/participants");
        public static Task<object> PostLolChatV1ConversationsByIdParticipants([Parameter("id", "path")] string id, [Parameter("invitee", "body")] LolChatUserResource invitee)
            => Sender.Request<object>("post", $"/lol-chat/v1/conversations/{id}/participants", invitee);
        public static Task<LolChatErrorResource[]> GetLolChatV1Errors()
            => Sender.Request<LolChatErrorResource[]>("get", $"/lol-chat/v1/errors");
        public static Task<object> DeleteLolChatV1ErrorsById([Parameter("id", "path")] long id)
            => Sender.Request<object>("delete", $"/lol-chat/v1/errors/{id}");
        public static Task<LolChatFriendCountsResource> GetLolChatV1FriendCounts()
            => Sender.Request<LolChatFriendCountsResource>("get", $"/lol-chat/v1/friend-counts");
        public static Task<LolChatGroupResource[]> GetLolChatV1FriendGroups()
            => Sender.Request<LolChatGroupResource[]>("get", $"/lol-chat/v1/friend-groups");
        public static Task<object> PostLolChatV1FriendGroups([Parameter("group", "body")] LolChatGroupResource group)
            => Sender.Request<object>("post", $"/lol-chat/v1/friend-groups", group);
        public static Task<object> DeleteLolChatV1FriendGroupsById([Parameter("id", "path")] int id)
            => Sender.Request<object>("delete", $"/lol-chat/v1/friend-groups/{id}");
        public static Task<LolChatGroupResource> GetLolChatV1FriendGroupsById([Parameter("id", "path")] int id)
            => Sender.Request<LolChatGroupResource>("get", $"/lol-chat/v1/friend-groups/{id}");
        public static Task<object> PutLolChatV1FriendGroupsById([Parameter("id", "path")] int id, [Parameter("group", "body")] LolChatGroupResource group)
            => Sender.Request<object>("put", $"/lol-chat/v1/friend-groups/{id}", group);
        public static Task<LolChatFriendResource[]> GetLolChatV1FriendGroupsByIdFriends([Parameter("id", "path")] int id)
            => Sender.Request<LolChatFriendResource[]>("get", $"/lol-chat/v1/friend-groups/{id}/friends");
        public static Task<LolChatFriendRequestResource[]> GetLolChatV1FriendRequests()
            => Sender.Request<LolChatFriendRequestResource[]>("get", $"/lol-chat/v1/friend-requests");
        public static Task<object> PostLolChatV1FriendRequests([Parameter("request", "body")] LolChatFriendRequestResource request)
            => Sender.Request<object>("post", $"/lol-chat/v1/friend-requests", request);
        public static Task<object> DeleteLolChatV1FriendRequestsById([Parameter("id", "path")] long id)
            => Sender.Request<object>("delete", $"/lol-chat/v1/friend-requests/{id}");
        public static Task<object> PutLolChatV1FriendRequestsById([Parameter("id", "path")] long id, [Parameter("request", "body")] LolChatFriendRequestResource request)
            => Sender.Request<object>("put", $"/lol-chat/v1/friend-requests/{id}", request);
        public static Task<LolChatFriendResource[]> GetLolChatV1Friends()
            => Sender.Request<LolChatFriendResource[]>("get", $"/lol-chat/v1/friends");
        public static Task<object> DeleteLolChatV1FriendsById([Parameter("id", "path")] long id)
            => Sender.Request<object>("delete", $"/lol-chat/v1/friends/{id}");
        public static Task<LolChatFriendResource> GetLolChatV1FriendsById([Parameter("id", "path")] long id)
            => Sender.Request<LolChatFriendResource>("get", $"/lol-chat/v1/friends/{id}");
        public static Task<object> PutLolChatV1FriendsById([Parameter("id", "path")] long id, [Parameter("contact", "body")] LolChatFriendResource contact)
            => Sender.Request<object>("put", $"/lol-chat/v1/friends/{id}", contact);
        public static Task<LolChatUserResource> GetLolChatV1Me()
            => Sender.Request<LolChatUserResource>("get", $"/lol-chat/v1/me");
        public static Task<LolChatUserResource> PutLolChatV1Me([Parameter("me", "body")] LolChatUserResource me)
            => Sender.Request<LolChatUserResource>("put", $"/lol-chat/v1/me", me);
        public static Task<object> DeleteLolChatV1Session()
            => Sender.Request<object>("delete", $"/lol-chat/v1/session");
        public static Task<LolChatSessionResource> GetLolChatV1Session()
            => Sender.Request<LolChatSessionResource>("get", $"/lol-chat/v1/session");
        public static Task<LolChatSessionResource> PostLolChatV1SessionPlain([Parameter("auth", "body")] LolChatAuthResourcePlain auth)
            => Sender.Request<LolChatSessionResource>("post", $"/lol-chat/v1/session/plain", auth);
        public static Task<LolChatSessionResource> PostLolChatV1SessionRso([Parameter("auth", "body")] LolChatAuthResourceRsoAccessToken auth)
            => Sender.Request<LolChatSessionResource>("post", $"/lol-chat/v1/session/rso", auth);
        public static Task<object> GetLolChatV1Settings()
            => Sender.Request<object>("get", $"/lol-chat/v1/settings");
        public static Task<object> PutLolChatV1Settings([Parameter("data", "body")] object data, [Parameter("doAsync", "query")] bool doAsync)
            => Sender.Request<object>("put", $"/lol-chat/v1/settings?doAsync={System.Net.WebUtility.UrlEncode(doAsync.ToString())}", data);
        public static Task<object> DeleteLolChatV1SettingsByKey([Parameter("key", "path")] string key, [Parameter("doAsync", "query")] bool doAsync)
            => Sender.Request<object>("delete", $"/lol-chat/v1/settings/{key}?doAsync={System.Net.WebUtility.UrlEncode(doAsync.ToString())}");
        public static Task<object> GetLolChatV1SettingsByKey([Parameter("key", "path")] string key)
            => Sender.Request<object>("get", $"/lol-chat/v1/settings/{key}");
        public static Task<object> PutLolChatV1SettingsByKey([Parameter("key", "path")] string key, [Parameter("value", "body")] object value, [Parameter("doAsync", "query")] bool doAsync)
            => Sender.Request<object>("put", $"/lol-chat/v1/settings/{key}?doAsync={System.Net.WebUtility.UrlEncode(doAsync.ToString())}", value);
    }
}
