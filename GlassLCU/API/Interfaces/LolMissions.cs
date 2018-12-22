using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolMissions
    {
        public static Task<PlayerMissionEligibilityData> GetLolMissionsV1Data()
            => Sender.Request<PlayerMissionEligibilityData>("get", $"/lol-missions/v1/data");
        public static Task PostLolMissionsV1Force()
            => Sender.Request("post", $"/lol-missions/v1/force");
        public static Task<PlayerMissionDTO[]> GetLolMissionsV1Missions()
            => Sender.Request<PlayerMissionDTO[]>("get", $"/lol-missions/v1/missions");
        public static Task PatchLolMissionsV1Player([Parameter("seriesOpt", "body")] LolMissionsSeriesOpt seriesOpt)
            => Sender.Request("patch", $"/lol-missions/v1/player", seriesOpt);
        public static Task PutLolMissionsV1Player([Parameter("ids", "body")] IdsDTO ids)
            => Sender.Request("put", $"/lol-missions/v1/player", ids);
        public static Task PutLolMissionsV1PlayerOpt([Parameter("seriesOpts", "body")] object seriesOpts)
            => Sender.Request("put", $"/lol-missions/v1/player/opt", seriesOpts);
        public static Task PutLolMissionsV1PlayerByMissionId([Parameter("missionId", "path")] string missionId, [Parameter("rewardGroups", "body")] LolMissionsRewardGroupsSelection rewardGroups)
            => Sender.Request("put", $"/lol-missions/v1/player/{missionId}", rewardGroups);
        public static Task<SeriesDTO[]> GetLolMissionsV1Series()
            => Sender.Request<SeriesDTO[]>("get", $"/lol-missions/v1/series");
    }
}
