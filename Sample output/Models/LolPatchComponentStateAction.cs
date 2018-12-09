using Newtonsoft.Json;

namespace LCU_API_Generator
{
    public enum LolPatchComponentStateAction
    {
        Idle,
        CheckingForUpdates,
        Patching,
        Repairing,
    }
}
