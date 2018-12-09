using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolTokenUpsell
    {
        public static Task<LolWorldsTokenCardTokenUpsell[]> GetLolTokenUpsellV1All()
            => Sender.Request<LolWorldsTokenCardTokenUpsell[]>("get", $"/lol-token-upsell/v1/all");
    }
}
