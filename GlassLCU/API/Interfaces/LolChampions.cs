using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolChampions
    {
        public static Task<LolChampionsCollectionsChampion[]> GetLolChampionsV1InventoriesBySummonerIdChampions([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolChampionsCollectionsChampion[]>("get", $"/lol-champions/v1/inventories/{summonerId}/champions");
        public static Task<LolChampionsCollectionsChampionMinimal[]> GetLolChampionsV1InventoriesBySummonerIdChampionsMinimal([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolChampionsCollectionsChampionMinimal[]>("get", $"/lol-champions/v1/inventories/{summonerId}/champions-minimal");
        public static Task<LolChampionsCollectionsChampionPlayableCounts> GetLolChampionsV1InventoriesBySummonerIdChampionsPlayableCount([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolChampionsCollectionsChampionPlayableCounts>("get", $"/lol-champions/v1/inventories/{summonerId}/champions-playable-count");
        public static Task<LolChampionsCollectionsChampion> GetLolChampionsV1InventoriesBySummonerIdChampionsByChampionId([Parameter("summonerId", "path")] long summonerId, [Parameter("championId", "path")] int championId)
            => Sender.Request<LolChampionsCollectionsChampion>("get", $"/lol-champions/v1/inventories/{summonerId}/champions/{championId}");
        public static Task<LolChampionsCollectionsChampionSkin[]> GetLolChampionsV1InventoriesBySummonerIdChampionsByChampionIdSkins([Parameter("summonerId", "path")] long summonerId, [Parameter("championId", "path")] int championId)
            => Sender.Request<LolChampionsCollectionsChampionSkin[]>("get", $"/lol-champions/v1/inventories/{summonerId}/champions/{championId}/skins");
        public static Task<LolChampionsCollectionsChampionSkin> GetLolChampionsV1InventoriesBySummonerIdChampionsByChampionIdSkinsByChampionSkinId([Parameter("summonerId", "path")] long summonerId, [Parameter("championId", "path")] int championId, [Parameter("championSkinId", "path")] int championSkinId)
            => Sender.Request<LolChampionsCollectionsChampionSkin>("get", $"/lol-champions/v1/inventories/{summonerId}/champions/{championId}/skins/{championSkinId}");
        public static Task<LolChampionsCollectionsChampionChroma[]> GetLolChampionsV1InventoriesBySummonerIdChampionsByChampionIdSkinsBySkinIdChromas([Parameter("summonerId", "path")] long summonerId, [Parameter("championId", "path")] int championId, [Parameter("skinId", "path")] int skinId)
            => Sender.Request<LolChampionsCollectionsChampionChroma[]>("get", $"/lol-champions/v1/inventories/{summonerId}/champions/{championId}/skins/{skinId}/chromas");
        public static Task<LolChampionsCollectionsChampionSkinMinimal[]> GetLolChampionsV1InventoriesBySummonerIdSkinsMinimal([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolChampionsCollectionsChampionSkinMinimal[]>("get", $"/lol-champions/v1/inventories/{summonerId}/skins-minimal");
        public static Task<LolChampionsCollectionsChampionMinimal[]> GetLolChampionsV1OwnedChampionsMinimal()
            => Sender.Request<LolChampionsCollectionsChampionMinimal[]>("get", $"/lol-champions/v1/owned-champions-minimal");
    }
}
