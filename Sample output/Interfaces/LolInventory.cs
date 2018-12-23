//Auto-generated by https://github.com/pipe01/lcu-api-generator
using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;
using System.Reflection;

namespace GlassLCU.API.Interfaces
{
    public static class LolInventory
    {
        /// <summary>
        /// <para>GET /lol-inventory/v1/champSelectInventory</para>
        /// </summary>
        [Endpoint("/lol-inventory/v1/champSelectInventory")]
        public static Task<string> GetLolInventoryV1ChampSelectInventory()
            => Sender.Request<string>("get", $"/lol-inventory/v1/champSelectInventory");
        /// <summary>
        /// <para>GET /lol-inventory/v1/initial-configuration-complete</para>
        /// </summary>
        [Endpoint("/lol-inventory/v1/initial-configuration-complete")]
        public static Task<bool> GetLolInventoryV1InitialConfigurationComplete()
            => Sender.Request<bool>("get", $"/lol-inventory/v1/initial-configuration-complete");
        /// <summary>
        /// <para>GET /lol-inventory/v1/inventory</para>
        /// </summary>
        [Endpoint("/lol-inventory/v1/inventory")]
        public static Task<LolInventoryInventoryItemWithPayload[]> GetLolInventoryV1Inventory([Parameter("inventoryTypes", "query")] string[] inventoryTypes)
            => Sender.Request<LolInventoryInventoryItemWithPayload[]>("get", $"/lol-inventory/v1/inventory?inventoryTypes={System.Net.WebUtility.UrlEncode(inventoryTypes.ToString())}");
        /// <summary>
        /// <para>GET /lol-inventory/v1/inventory/emotes</para>
        /// </summary>
        [Endpoint("/lol-inventory/v1/inventory/emotes")]
        public static Task<LolInventoryInventoryItemWithPayload[]> GetLolInventoryV1InventoryEmotes()
            => Sender.Request<LolInventoryInventoryItemWithPayload[]>("get", $"/lol-inventory/v1/inventory/emotes");
        /// <summary>
        /// <para>POST /lol-inventory/v1/notification/acknowledge</para>
        /// </summary>
        [Endpoint("/lol-inventory/v1/notification/acknowledge")]
        public static Task PostLolInventoryV1NotificationAcknowledge([Parameter("id", "body")] long id)
            => Sender.Request("post", $"/lol-inventory/v1/notification/acknowledge", id);
        /// <summary>
        /// <para>GET /lol-inventory/v1/notifications/{inventoryType}</para>
        /// </summary>
        [Endpoint("/lol-inventory/v1/notifications/{inventoryType}")]
        public static Task<LolInventoryInventoryNotification[]> GetLolInventoryV1NotificationsByInventoryType([Parameter("inventoryType", "path")] string inventoryType)
            => Sender.Request<LolInventoryInventoryNotification[]>("get", $"/lol-inventory/v1/notifications/{inventoryType}");
        /// <summary>
        /// <para>GET /lol-inventory/v1/players/{puuid}/inventory</para>
        /// </summary>
        [Endpoint("/lol-inventory/v1/players/{puuid}/inventory")]
        public static Task<LolInventoryInventoryItemWithPayload[]> GetLolInventoryV1PlayersByPuuidInventory([Parameter("puuid", "path")] string puuid, [Parameter("inventoryTypes", "query")] string[] inventoryTypes)
            => Sender.Request<LolInventoryInventoryItemWithPayload[]>("get", $"/lol-inventory/v1/players/{puuid}/inventory?inventoryTypes={System.Net.WebUtility.UrlEncode(inventoryTypes.ToString())}");
        /// <summary>
        /// <para>GET /lol-inventory/v1/signedInventory</para>
        /// </summary>
        [Endpoint("/lol-inventory/v1/signedInventory")]
        public static Task<object> GetLolInventoryV1SignedInventory([Parameter("inventoryTypes", "query")] string[] inventoryTypes)
            => Sender.Request<object>("get", $"/lol-inventory/v1/signedInventory?inventoryTypes={System.Net.WebUtility.UrlEncode(inventoryTypes.ToString())}");
        /// <summary>
        /// <para>GET /lol-inventory/v1/signedInventory/tournamentlogos</para>
        /// </summary>
        [Endpoint("/lol-inventory/v1/signedInventory/tournamentlogos")]
        public static Task<object> GetLolInventoryV1SignedInventoryTournamentlogos()
            => Sender.Request<object>("get", $"/lol-inventory/v1/signedInventory/tournamentlogos");
        /// <summary>
        /// <para>GET /lol-inventory/v1/signedInventoryCache</para>
        /// </summary>
        [Endpoint("/lol-inventory/v1/signedInventoryCache")]
        public static Task<object> GetLolInventoryV1SignedInventoryCache()
            => Sender.Request<object>("get", $"/lol-inventory/v1/signedInventoryCache");
        /// <summary>
        /// <para>GET /lol-inventory/v1/signedWallet</para>
        /// </summary>
        [Endpoint("/lol-inventory/v1/signedWallet")]
        public static Task<object> GetLolInventoryV1SignedWallet([Parameter("currencyTypes", "query")] string[] currencyTypes)
            => Sender.Request<object>("get", $"/lol-inventory/v1/signedWallet?currencyTypes={System.Net.WebUtility.UrlEncode(currencyTypes.ToString())}");
        /// <summary>
        /// <para>GET /lol-inventory/v1/signedWallet/{currencyType}</para>
        /// </summary>
        [Endpoint("/lol-inventory/v1/signedWallet/{currencyType}")]
        public static Task<object> GetLolInventoryV1SignedWalletByCurrencyType([Parameter("currencyType", "path")] string currencyType)
            => Sender.Request<object>("get", $"/lol-inventory/v1/signedWallet/{currencyType}");
        /// <summary>
        /// <para>GET /lol-inventory/v1/wallet</para>
        /// </summary>
        [Endpoint("/lol-inventory/v1/wallet")]
        public static Task<object> GetLolInventoryV1Wallet([Parameter("currencyTypes", "query")] string[] currencyTypes)
            => Sender.Request<object>("get", $"/lol-inventory/v1/wallet?currencyTypes={System.Net.WebUtility.UrlEncode(currencyTypes.ToString())}");
        /// <summary>
        /// <para>GET /lol-inventory/v1/wallet/{currencyType}</para>
        /// </summary>
        [Endpoint("/lol-inventory/v1/wallet/{currencyType}")]
        public static Task<object> GetLolInventoryV1WalletByCurrencyType([Parameter("currencyType", "path")] string currencyType)
            => Sender.Request<object>("get", $"/lol-inventory/v1/wallet/{currencyType}");
        /// <summary>
        /// <para>GET /lol-inventory/v2/inventory/{inventoryType}</para>
        /// </summary>
        [Endpoint("/lol-inventory/v2/inventory/{inventoryType}")]
        public static Task<LolInventoryInventoryItemWithPayload[]> GetLolInventoryV2InventoryByInventoryType([Parameter("inventoryType", "path")] string inventoryType)
            => Sender.Request<LolInventoryInventoryItemWithPayload[]>("get", $"/lol-inventory/v2/inventory/{inventoryType}");

        public static string GetURL(string methodName)
        {
            return typeof(LolInventory).GetMethod(methodName).GetCustomAttribute<EndpointAttribute>().URL;
        }
    }
}
