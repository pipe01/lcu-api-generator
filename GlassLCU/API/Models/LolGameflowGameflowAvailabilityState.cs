using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolGameflowGameflowAvailabilityState
    {
        Available,
        Initializing,
        Patching,
        PlayerBanned,
        InGameFlow,
        Configuration,
        EligibilityInfoMissing,
    }
}
