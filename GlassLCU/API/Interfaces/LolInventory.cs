using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolInventory
    {
        public static Task<string> GetLolInventoryV1ChampSelectInventory()
            => Sender.Request<string>("get", $"/lol-inventory/v1/champSelectInventory");
        public static Task<bool> GetLolInventoryV1InitialConfigurationComplete()
            => Sender.Request<bool>("get", $"/lol-inventory/v1/initial-configuration-complete");
        public static Task<LolInventoryInventoryItemWithPayload[]> GetLolInventoryV1Inventory([Parameter("inventoryTypes", "query")] string[] inventoryTypes)
            => Sender.Request<LolInventoryInventoryItemWithPayload[]>("get", $"/lol-inventory/v1/inventory?inventoryTypes={System.Net.WebUtility.UrlEncode(inventoryTypes.ToString())}");
        public static Task<LolInventoryInventoryItemWithPayload[]> GetLolInventoryV1InventoryEmotes()
            => Sender.Request<LolInventoryInventoryItemWithPayload[]>("get", $"/lol-inventory/v1/inventory/emotes");
        public static Task PostLolInventoryV1NotificationAcknowledge([Parameter("id", "body")] long id)
            => Sender.Request("post", $"/lol-inventory/v1/notification/acknowledge", id);
        public static Task<LolInventoryInventoryNotification[]> GetLolInventoryV1NotificationsByInventoryType([Parameter("inventoryType", "path")] string inventoryType)
            => Sender.Request<LolInventoryInventoryNotification[]>("get", $"/lol-inventory/v1/notifications/{inventoryType}");
        public static Task<LolInventoryInventoryItemWithPayload[]> GetLolInventoryV1PlayersByPuuidInventory([Parameter("puuid", "path")] string puuid, [Parameter("inventoryTypes", "query")] string[] inventoryTypes)
            => Sender.Request<LolInventoryInventoryItemWithPayload[]>("get", $"/lol-inventory/v1/players/{puuid}/inventory?inventoryTypes={System.Net.WebUtility.UrlEncode(inventoryTypes.ToString())}");
        public static Task<object> GetLolInventoryV1SignedInventory([Parameter("inventoryTypes", "query")] string[] inventoryTypes)
            => Sender.Request<object>("get", $"/lol-inventory/v1/signedInventory?inventoryTypes={System.Net.WebUtility.UrlEncode(inventoryTypes.ToString())}");
        public static Task<object> GetLolInventoryV1SignedInventoryTournamentlogos()
            => Sender.Request<object>("get", $"/lol-inventory/v1/signedInventory/tournamentlogos");
        public static Task<object> GetLolInventoryV1SignedInventoryCache()
            => Sender.Request<object>("get", $"/lol-inventory/v1/signedInventoryCache");
        public static Task<object> GetLolInventoryV1SignedWallet([Parameter("currencyTypes", "query")] string[] currencyTypes)
            => Sender.Request<object>("get", $"/lol-inventory/v1/signedWallet?currencyTypes={System.Net.WebUtility.UrlEncode(currencyTypes.ToString())}");
        public static Task<object> GetLolInventoryV1SignedWalletByCurrencyType([Parameter("currencyType", "path")] string currencyType)
            => Sender.Request<object>("get", $"/lol-inventory/v1/signedWallet/{currencyType}");
        public static Task<object> GetLolInventoryV1Wallet([Parameter("currencyTypes", "query")] string[] currencyTypes)
            => Sender.Request<object>("get", $"/lol-inventory/v1/wallet?currencyTypes={System.Net.WebUtility.UrlEncode(currencyTypes.ToString())}");
        public static Task<object> GetLolInventoryV1WalletByCurrencyType([Parameter("currencyType", "path")] string currencyType)
            => Sender.Request<object>("get", $"/lol-inventory/v1/wallet/{currencyType}");
        public static Task<LolInventoryInventoryItemWithPayload[]> GetLolInventoryV2InventoryByInventoryType([Parameter("inventoryType", "path")] string inventoryType)
            => Sender.Request<LolInventoryInventoryItemWithPayload[]>("get", $"/lol-inventory/v2/inventory/{inventoryType}");
    }
}
