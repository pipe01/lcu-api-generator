using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolFeaturedModes
    {
        public static Task<bool> GetLolFeaturedModesV1LockedEventActive()
            => Sender.Request<bool>("get", $"/lol-featured-modes/v1/locked-event/active");
        public static Task<long> GetLolFeaturedModesV1LockedEventIndex()
            => Sender.Request<long>("get", $"/lol-featured-modes/v1/locked-event/index");
    }
}
