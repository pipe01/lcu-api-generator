using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolLoot
    {
        public static Task GetLolLootV1CurrencyConfiguration()
            => Sender.Request("get", $"/lol-loot/v1/currency-configuration");
        public static Task<bool> GetLolLootV1Enabled()
            => Sender.Request<bool>("get", $"/lol-loot/v1/enabled");
        public static Task<LolLootLootGrantNotification[]> GetLolLootV1LootGrants()
            => Sender.Request<LolLootLootGrantNotification[]>("get", $"/lol-loot/v1/loot-grants");
        public static Task<object> DeleteLolLootV1LootGrantsById([Parameter("id", "path")] long id)
            => Sender.Request<object>("delete", $"/lol-loot/v1/loot-grants/{id}");
        public static Task<LolLootLootItem[]> GetLolLootV1LootItems()
            => Sender.Request<LolLootLootItem[]>("get", $"/lol-loot/v1/loot-items");
        public static Task<bool> GetLolLootV1NewPlayerCheckDone()
            => Sender.Request<bool>("get", $"/lol-loot/v1/new-player-check-done");
        public static Task<string> PostLolLootV1NewPlayerCheckDoneByNewValue([Parameter("newValue", "path")] bool newValue)
            => Sender.Request<string>("post", $"/lol-loot/v1/new-player-check-done/{newValue}");
        public static Task<string[]> GetLolLootV1PlayerDisplayCategories()
            => Sender.Request<string[]>("get", $"/lol-loot/v1/player-display-categories");
        public static Task<LolLootPlayerLoot[]> GetLolLootV1PlayerLoot()
            => Sender.Request<LolLootPlayerLoot[]>("get", $"/lol-loot/v1/player-loot");
        public static Task<object> GetLolLootV1PlayerLootMap()
            => Sender.Request<object>("get", $"/lol-loot/v1/player-loot-map");
        public static Task<LolLootPlayerLootNotification[]> GetLolLootV1PlayerLootNotifications()
            => Sender.Request<LolLootPlayerLootNotification[]>("get", $"/lol-loot/v1/player-loot-notifications");
        public static Task<string> PostLolLootV1PlayerLootNotificationsByIdAcknowledge([Parameter("id", "path")] string id)
            => Sender.Request<string>("post", $"/lol-loot/v1/player-loot-notifications/{id}/acknowledge");
        public static Task<LolLootPlayerLoot> GetLolLootV1PlayerLootByLootId([Parameter("lootId", "path")] string lootId)
            => Sender.Request<LolLootPlayerLoot>("get", $"/lol-loot/v1/player-loot/{lootId}");
        public static Task<LolLootContextMenu[]> GetLolLootV1PlayerLootByLootIdContextMenu([Parameter("lootId", "path")] string lootId)
            => Sender.Request<LolLootContextMenu[]>("get", $"/lol-loot/v1/player-loot/{lootId}/context-menu");
        public static Task<LolLootContextMenu[]> PostLolLootV1PlayerLootByLootIdContextMenu([Parameter("lootId", "path")] string lootId)
            => Sender.Request<LolLootContextMenu[]>("post", $"/lol-loot/v1/player-loot/{lootId}/context-menu");
        public static Task<object> DeleteLolLootV1PlayerLootByLootIdNewNotification([Parameter("lootId", "path")] string lootId)
            => Sender.Request<object>("delete", $"/lol-loot/v1/player-loot/{lootId}/new-notification");
        public static Task<LolLootPlayerLootUpdate> PostLolLootV1PlayerLootByLootNameRedeem([Parameter("lootName", "path")] string lootName)
            => Sender.Request<LolLootPlayerLootUpdate>("post", $"/lol-loot/v1/player-loot/{lootName}/redeem");
        public static Task<bool> GetLolLootV1Ready()
            => Sender.Request<bool>("get", $"/lol-loot/v1/ready");
        public static Task GetLolLootV1RecipesConfiguration()
            => Sender.Request("get", $"/lol-loot/v1/recipes/configuration");
        public static Task<LolLootRecipe[]> GetLolLootV1RecipesInitialItemByLootId([Parameter("lootId", "path")] string lootId)
            => Sender.Request<LolLootRecipe[]>("get", $"/lol-loot/v1/recipes/initial-item/{lootId}");
        public static Task<LolLootRecipe[]> PostLolLootV1RecipesInitialItemByLootId([Parameter("lootId", "path")] string lootId)
            => Sender.Request<LolLootRecipe[]>("post", $"/lol-loot/v1/recipes/initial-item/{lootId}");
        public static Task<LolLootPlayerLootUpdate> PostLolLootV1RecipesByRecipeNameCraft([Parameter("recipeName", "path")] string recipeName, [Parameter("playerLootList", "body")] string[] playerLootList, [Parameter("repeat", "query")] int repeat)
            => Sender.Request<LolLootPlayerLootUpdate>("post", $"/lol-loot/v1/recipes/{recipeName}/craft?repeat={System.Net.WebUtility.UrlEncode(repeat.ToString())}", playerLootList);
        public static Task<string> PostLolLootV1Refresh([Parameter("force", "query")] bool force)
            => Sender.Request<string>("post", $"/lol-loot/v1/refresh?force={System.Net.WebUtility.UrlEncode(force.ToString())}");
        public static Task<LolLootPlayerLootMap> GetLolLootV2PlayerLootMap()
            => Sender.Request<LolLootPlayerLootMap>("get", $"/lol-loot/v2/player-loot-map");
    }
}
