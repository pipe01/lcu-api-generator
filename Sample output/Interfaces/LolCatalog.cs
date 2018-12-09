using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolCatalog
    {
        public static Task<LolCatalogCatalogPluginItem[]> GetLolCatalogV1ItemsByInventoryType([Parameter("inventoryType", "path")] string inventoryType)
            => Sender.Request<LolCatalogCatalogPluginItem[]>("get", $"/lol-catalog/v1/items/{inventoryType}");
    }
}
