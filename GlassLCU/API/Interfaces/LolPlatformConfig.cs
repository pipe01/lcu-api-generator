using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolPlatformConfig
    {
        public static Task<bool> GetLolPlatformConfigV1InitialConfigurationComplete()
            => Sender.Request<bool>("get", $"/lol-platform-config/v1/initial-configuration-complete");
        public static Task<object> GetLolPlatformConfigV1Namespaces()
            => Sender.Request<object>("get", $"/lol-platform-config/v1/namespaces");
        public static Task<object> GetLolPlatformConfigV1NamespacesByNs([Parameter("ns", "path")] string ns)
            => Sender.Request<object>("get", $"/lol-platform-config/v1/namespaces/{ns}");
        public static Task<object> GetLolPlatformConfigV1NamespacesByNsByKey([Parameter("ns", "path")] string ns, [Parameter("key", "path")] string key)
            => Sender.Request<object>("get", $"/lol-platform-config/v1/namespaces/{ns}/{key}");
    }
}
