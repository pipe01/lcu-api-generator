using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolRankedStats
    {
        public static Task<LolRankedStatsRankedData> GetLolRankedStatsV1StatsBySummonerId([Parameter("summonerId", "path")] long summonerId)
            => Sender.Request<LolRankedStatsRankedData>("get", $"/lol-ranked-stats/v1/stats/{summonerId}");
        public static Task<LolRankedStatsPluginStatus> GetLolRankedStatsV1Status()
            => Sender.Request<LolRankedStatsPluginStatus>("get", $"/lol-ranked-stats/v1/status");
    }
}
