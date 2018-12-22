using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum PluginThreadingModel
    {
        Dedicated,
        Sequential,
        Concurrent,
        Parallel,
    }
}
