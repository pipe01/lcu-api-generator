using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class Entitlements
    {
        public static Task<EntitlementsToken> GetEntitlementsV1Token()
            => Sender.Request<EntitlementsToken>("get", $"/entitlements/v1/token");
    }
}
