using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolActiveBoosts
    {
        public static Task<LolActiveBoostsActiveBoosts> GetLolActiveBoostsV1ActiveBoosts()
            => Sender.Request<LolActiveBoostsActiveBoosts>("get", $"/lol-active-boosts/v1/active-boosts");
    }
}
