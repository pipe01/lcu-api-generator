using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolPatchComponentStateAction
    {
        Idle,
        CheckingForUpdates,
        Patching,
        Repairing,
    }
}
