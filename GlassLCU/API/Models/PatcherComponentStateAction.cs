using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum PatcherComponentStateAction
    {
        Idle,
        CheckingForUpdates,
        Patching,
        Repairing,
    }
}
