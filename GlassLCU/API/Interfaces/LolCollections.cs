using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolCollections
    {
        public static Task<LolCollectionsCollectionsChestEligibility> GetLolCollectionsV1InventoriesChestEligibility()
            => Sender.Request<LolCollectionsCollectionsChestEligibility>("get", $"/lol-collections/v1/inventories/chest-eligibility");
        public static Task<LolCollectionsCollectionsSummonerBackdrop> GetLolCollectionsV1InventoriesBySummonerIdBackdrop([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolCollectionsCollectionsSummonerBackdrop>("get", $"/lol-collections/v1/inventories/{summonerId}/backdrop");
        public static Task<LolCollectionsCollectionsChampionMastery[]> GetLolCollectionsV1InventoriesBySummonerIdChampionMastery([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolCollectionsCollectionsChampionMastery[]>("get", $"/lol-collections/v1/inventories/{summonerId}/champion-mastery");
        public static Task<LolCollectionsCollectionsTopChampionMasteries> GetLolCollectionsV1InventoriesBySummonerIdChampionMasteryTop([Parameter("summonerId", "path")] long summonerId, [Parameter("limit", "query")] long limit, [Parameter("sortRule", "query")] string sortRule = default)
            => Sender.Request<LolCollectionsCollectionsTopChampionMasteries>("get", $"/lol-collections/v1/inventories/{summonerId}/champion-mastery/top?limit={System.Net.WebUtility.UrlEncode(limit.ToString())}&{(sortRule != default ? $"sortRule={System.Net.WebUtility.UrlEncode(sortRule.ToString())}" : null)}");
        public static Task<LolCollectionsCollectionsRuneBook> GetLolCollectionsV1InventoriesBySummonerIdRuneBook([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolCollectionsCollectionsRuneBook>("get", $"/lol-collections/v1/inventories/{summonerId}/rune-book");
        public static Task<LolCollectionsCollectionsRuneBook> PutLolCollectionsV1InventoriesBySummonerIdRuneBook([Parameter("summonerId", "path")] long summonerId, [Parameter("resource", "body")] LolCollectionsCollectionsRuneBook resource)
            => Sender.Request<LolCollectionsCollectionsRuneBook>("put", $"/lol-collections/v1/inventories/{summonerId}/rune-book", resource);
        public static Task<LolCollectionsCollectionsRunePage> PutLolCollectionsV1InventoriesBySummonerIdRuneBookPagesByPageId([Parameter("summonerId", "path")] long summonerId, [Parameter("pageId", "path")] int pageId, [Parameter("resource", "body")] LolCollectionsCollectionsRunePage resource)
            => Sender.Request<LolCollectionsCollectionsRunePage>("put", $"/lol-collections/v1/inventories/{summonerId}/rune-book/pages/{pageId}", resource);
        public static Task<LolCollectionsCollectionsRunePage> PutLolCollectionsV1InventoriesBySummonerIdRuneBookSelectPageByPageId([Parameter("summonerId", "path")] long summonerId, [Parameter("pageId", "path")] int pageId)
            => Sender.Request<LolCollectionsCollectionsRunePage>("put", $"/lol-collections/v1/inventories/{summonerId}/rune-book/select-page/{pageId}");
        public static Task<LolCollectionsCollectionsRuneQuantities> GetLolCollectionsV1InventoriesBySummonerIdRunes([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolCollectionsCollectionsRuneQuantities>("get", $"/lol-collections/v1/inventories/{summonerId}/runes");
        public static Task<LolCollectionsCollectionsSummonerSpells> GetLolCollectionsV1InventoriesBySummonerIdSpells([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolCollectionsCollectionsSummonerSpells>("get", $"/lol-collections/v1/inventories/{summonerId}/spells");
        public static Task<LolCollectionsCollectionsSummonerIcons> GetLolCollectionsV1InventoriesBySummonerIdSummonerIcons([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolCollectionsCollectionsSummonerIcons>("get", $"/lol-collections/v1/inventories/{summonerId}/summoner-icons");
        public static Task<string> PutLolCollectionsV1InventoriesBySummonerIdVerification([Parameter("summonerId", "path")] long summonerId, [Parameter("verificationCode", "body")] string verificationCode)
            => Sender.Request<string>("put", $"/lol-collections/v1/inventories/{summonerId}/verification", verificationCode);
        public static Task<LolCollectionsCollectionsWardSkin[]> GetLolCollectionsV1InventoriesBySummonerIdWardSkins([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolCollectionsCollectionsWardSkin[]>("get", $"/lol-collections/v1/inventories/{summonerId}/ward-skins");
        public static Task<LolCollectionsCollectionsWardSkin> GetLolCollectionsV1InventoriesBySummonerIdWardSkinsByWardSkinId([Parameter("summonerId", "path")] long summonerId, [Parameter("wardSkinId", "path")] long wardSkinId)
            => Sender.Request<LolCollectionsCollectionsWardSkin>("get", $"/lol-collections/v1/inventories/{summonerId}/ward-skins/{wardSkinId}");
        public static Task<LolCollectionsCollectionsSummonerIcons> GetLolCollectionsV2InventoriesBySummonerIdSummonerIcons([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolCollectionsCollectionsSummonerIcons>("get", $"/lol-collections/v2/inventories/{summonerId}/summoner-icons");
        public static Task<LolCollectionsCollectionsSummonerIcon> GetLolCollectionsV2InventoriesBySummonerIdSummonerIconsBySummonerIconId([Parameter("summonerId", "path")] long summonerId, [Parameter("summonerIconId", "path")] int summonerIconId)
            => Sender.Request<LolCollectionsCollectionsSummonerIcon>("get", $"/lol-collections/v2/inventories/{summonerId}/summoner-icons/{summonerIconId}");
    }
}
