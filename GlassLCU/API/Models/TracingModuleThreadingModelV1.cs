using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum TracingModuleThreadingModelV1
    {
        KNone,
        KMainThread,
        KDedicated,
        KSequential,
        KConcurrent,
        KParallel,
    }
}