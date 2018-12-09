using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolPerks
    {
        public static Task<LolPerksPerkPageResource> GetLolPerksV1Currentpage()
            => Sender.Request<LolPerksPerkPageResource>("get", $"/lol-perks/v1/currentpage");
        public static Task<object> PutLolPerksV1Currentpage([Parameter("id", "body")] int id)
            => Sender.Request<object>("put", $"/lol-perks/v1/currentpage", id);
        public static Task<LolPerksCustomizationLimits> GetLolPerksV1Customizationlimits()
            => Sender.Request<LolPerksCustomizationLimits>("get", $"/lol-perks/v1/customizationlimits");
        public static Task<LolPerksPlayerInventory> GetLolPerksV1Inventory()
            => Sender.Request<LolPerksPlayerInventory>("get", $"/lol-perks/v1/inventory");
        public static Task<object> DeleteLolPerksV1Pages()
            => Sender.Request<object>("delete", $"/lol-perks/v1/pages");
        public static Task<LolPerksPerkPageResource[]> GetLolPerksV1Pages()
            => Sender.Request<LolPerksPerkPageResource[]>("get", $"/lol-perks/v1/pages");
        public static Task<LolPerksPerkPageResource> PostLolPerksV1Pages([Parameter("page", "body")] LolPerksPerkPageResource page)
            => Sender.Request<LolPerksPerkPageResource>("post", $"/lol-perks/v1/pages", page);
        public static Task<object> DeleteLolPerksV1PagesById([Parameter("id", "path")] int id)
            => Sender.Request<object>("delete", $"/lol-perks/v1/pages/{id}");
        public static Task<LolPerksPerkPageResource> GetLolPerksV1PagesById([Parameter("id", "path")] int id)
            => Sender.Request<LolPerksPerkPageResource>("get", $"/lol-perks/v1/pages/{id}");
        public static Task<object> PutLolPerksV1PagesById([Parameter("id", "path")] int id, [Parameter("page", "body")] LolPerksPerkPageResource page)
            => Sender.Request<object>("put", $"/lol-perks/v1/pages/{id}", page);
        public static Task<object> DeleteLolPerksV1PagesByIdAutoModifiedSelections([Parameter("id", "path")] int id)
            => Sender.Request<object>("delete", $"/lol-perks/v1/pages/{id}/auto-modified-selections");
        public static Task<LolPerksPerkUIPerk[]> GetLolPerksV1Perks()
            => Sender.Request<LolPerksPerkUIPerk[]>("get", $"/lol-perks/v1/perks");
        public static Task<object> PutLolPerksV1PerksAckGameplayUpdated([Parameter("ids", "body")] int[] ids)
            => Sender.Request<object>("put", $"/lol-perks/v1/perks/ack-gameplay-updated", ids);
        public static Task<int[]> GetLolPerksV1PerksDisabled()
            => Sender.Request<int[]>("get", $"/lol-perks/v1/perks/disabled");
        public static Task<int[]> GetLolPerksV1PerksGameplayUpdated()
            => Sender.Request<int[]>("get", $"/lol-perks/v1/perks/gameplay-updated");
        public static Task<int> GetLolPerksV1SchemaVersion()
            => Sender.Request<int>("get", $"/lol-perks/v1/schema-version");
        public static Task<LolPerksServiceSettings> GetLolPerksV1Servicesettings()
            => Sender.Request<LolPerksServiceSettings>("get", $"/lol-perks/v1/servicesettings");
        public static Task<LolPerksUISettings> GetLolPerksV1Settings()
            => Sender.Request<LolPerksUISettings>("get", $"/lol-perks/v1/settings");
        public static Task<object> PutLolPerksV1Settings([Parameter("showLongDescriptions", "body")] LolPerksUISettings showLongDescriptions)
            => Sender.Request<object>("put", $"/lol-perks/v1/settings", showLongDescriptions);
        public static Task<bool> GetLolPerksV1ShowAutoModifiedPagesNotification()
            => Sender.Request<bool>("get", $"/lol-perks/v1/show-auto-modified-pages-notification");
        public static Task<object> PostLolPerksV1ShowAutoModifiedPagesNotification()
            => Sender.Request<object>("post", $"/lol-perks/v1/show-auto-modified-pages-notification");
        public static Task<LolPerksPerkUIStyle[]> GetLolPerksV1Styles()
            => Sender.Request<LolPerksPerkUIStyle[]>("get", $"/lol-perks/v1/styles");
        public static Task<object> PostLolPerksV1UpdatePageOrder([Parameter("request", "body")] LolPerksUpdatePageOrderRequest request)
            => Sender.Request<object>("post", $"/lol-perks/v1/update-page-order", request);
    }
}
