using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolActiveBoosts
    {
        public static Task<LolActiveBoostsActiveBoosts> GetLolActiveBoostsV1ActiveBoosts()
            => Sender.Request<LolActiveBoostsActiveBoosts>("get", $"/lol-active-boosts/v1/active-boosts");
    }
}
