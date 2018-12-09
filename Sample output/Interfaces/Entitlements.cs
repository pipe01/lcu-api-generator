using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class Entitlements
    {
        public static Task<EntitlementsToken> GetEntitlementsV1Token()
            => Sender.Request<EntitlementsToken>("get", $"/entitlements/v1/token");
    }
}
