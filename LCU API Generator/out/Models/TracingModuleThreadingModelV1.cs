using Newtonsoft.Json;

namespace LCU_API_Generator
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
