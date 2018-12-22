using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolStore
    {
        public static Task<LolStoreCatalogItem[]> GetLolStoreV1Catalog([Parameter("inventoryType", "query")] string[] inventoryType = default, [Parameter("itemId", "query")] int[] itemId = default)
            => Sender.Request<LolStoreCatalogItem[]>("get", $"/lol-store/v1/catalog?{(inventoryType != default ? $"inventoryType={System.Net.WebUtility.UrlEncode(inventoryType.ToString())}" : null)}&{(itemId != default ? $"itemId={System.Net.WebUtility.UrlEncode(itemId.ToString())}" : null)}");
        public static Task<string> GetLolStoreV1GetStoreUrl()
            => Sender.Request<string>("get", $"/lol-store/v1/getStoreUrl");
        public static Task<LolStoreGiftingFriend[]> GetLolStoreV1Giftablefriends()
            => Sender.Request<LolStoreGiftingFriend[]>("get", $"/lol-store/v1/giftablefriends");
        public static Task<string> GetLolStoreV1LastPage()
            => Sender.Request<string>("get", $"/lol-store/v1/lastPage");
        public static Task PostLolStoreV1LastPage([Parameter("pageType", "body")] string pageType)
            => Sender.Request("post", $"/lol-store/v1/lastPage", pageType);
        public static Task<object> GetLolStoreV1Login()
            => Sender.Request<object>("get", $"/lol-store/v1/login");
        public static Task<object> PostLolStoreV1NotificationsAcknowledge([Parameter("id", "body")] string id)
            => Sender.Request<object>("post", $"/lol-store/v1/notifications/acknowledge", id);
        public static Task<LolStoreOrderNotificationResource[]> GetLolStoreV1OrderNotifications()
            => Sender.Request<LolStoreOrderNotificationResource[]>("get", $"/lol-store/v1/order-notifications");
        public static Task<object> DeleteLolStoreV1OrderNotificationsById([Parameter("id", "path")] long id)
            => Sender.Request<object>("delete", $"/lol-store/v1/order-notifications/{id}");
        public static Task<LolStoreOrderNotificationResource> GetLolStoreV1OrderNotificationsById([Parameter("id", "path")] long id)
            => Sender.Request<LolStoreOrderNotificationResource>("get", $"/lol-store/v1/order-notifications/{id}");
        public static Task<object> GetLolStoreV1PaymentDetails([Parameter("action", "query")] string action, [Parameter("giftRecipientAccountId", "query")] long giftRecipientAccountId = default, [Parameter("giftMessage", "query")] string giftMessage = default)
            => Sender.Request<object>("get", $"/lol-store/v1/paymentDetails?action={System.Net.WebUtility.UrlEncode(action.ToString())}&{(giftRecipientAccountId != default ? $"giftRecipientAccountId={System.Net.WebUtility.UrlEncode(giftRecipientAccountId.ToString())}" : null)}&{(giftMessage != default ? $"giftMessage={System.Net.WebUtility.UrlEncode(giftMessage.ToString())}" : null)}");
        public static Task<LolStoreCatalogItem> GetLolStoreV1SkinsBySkinId([Parameter("skinId", "path")] int skinId)
            => Sender.Request<LolStoreCatalogItem>("get", $"/lol-store/v1/skins/{skinId}");
        public static Task<object> PostLolStoreV1SkinsBySkinIdPurchase([Parameter("skinId", "path")] int skinId, [Parameter("cost", "body")] LolStoreItemCost cost)
            => Sender.Request<object>("post", $"/lol-store/v1/skins/{skinId}/purchase", cost);
        public static Task<LolStoreStoreStatus> GetLolStoreV1Status()
            => Sender.Request<LolStoreStoreStatus>("get", $"/lol-store/v1/status");
        public static Task<LolStoreWallet> GetLolStoreV1Wallet()
            => Sender.Request<LolStoreWallet>("get", $"/lol-store/v1/wallet");
        public static Task<object> GetLolStoreV1ByPageType([Parameter("pageType", "path")] string pageType)
            => Sender.Request<object>("get", $"/lol-store/v1/{pageType}");
    }
}
