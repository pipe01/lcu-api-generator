using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolCatalog
    {
        public static Task<LolCatalogCatalogPluginItem[]> GetLolCatalogV1ItemsByInventoryType([Parameter("inventoryType", "path")] string inventoryType)
            => Sender.Request<LolCatalogCatalogPluginItem[]>("get", $"/lol-catalog/v1/items/{inventoryType}");
    }
}
