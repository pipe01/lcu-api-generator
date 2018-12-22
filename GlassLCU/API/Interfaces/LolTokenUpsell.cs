using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolTokenUpsell
    {
        public static Task<LolWorldsTokenCardTokenUpsell[]> GetLolTokenUpsellV1All()
            => Sender.Request<LolWorldsTokenCardTokenUpsell[]>("get", $"/lol-token-upsell/v1/all");
    }
}
