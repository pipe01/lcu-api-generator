using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolAccountVerificationLoginSessionState
    {
        IN_PROGRESS,
        SUCCEEDED,
        LOGGING_OUT,
        ERROR,
    }
}
