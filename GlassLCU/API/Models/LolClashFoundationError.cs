using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolClashFoundationError
    {
        CLASH_NOT_INITIALIZED,
        CLASH_DISABLED,
        DESERIALIZATION_FAILED,
        GAMEFLOW_UNAVAILABLE,
        LOL_INVENTORY_NOT_READY,
        INVALID_SIMPLE_STATE_FLAG,
    }
}
