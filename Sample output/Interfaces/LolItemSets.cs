using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolItemSets
    {
        public static Task<LolItemSetsItemSets> GetLolItemSetsV1ItemSetsBySummonerIdSets([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolItemSetsItemSets>("get", $"/lol-item-sets/v1/item-sets/{summonerId}/sets");
        public static Task PostLolItemSetsV1ItemSetsBySummonerIdSets([Parameter("summonerId", "path")] long summonerId, [Parameter("itemSet", "body")] LolItemSetsItemSet itemSet)
            => Sender.Request("post", $"/lol-item-sets/v1/item-sets/{summonerId}/sets", itemSet);
        public static Task PutLolItemSetsV1ItemSetsBySummonerIdSets([Parameter("summonerId", "path")] long summonerId, [Parameter("itemSets", "body")] LolItemSetsItemSets itemSets)
            => Sender.Request("put", $"/lol-item-sets/v1/item-sets/{summonerId}/sets", itemSets);
    }
}
