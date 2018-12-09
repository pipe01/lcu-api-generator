using Newtonsoft.Json;

namespace LCU_API_Generator
{
    public enum PatcherComponentStateAction
    {
        Idle,
        CheckingForUpdates,
        Patching,
        Repairing,
    }
}
