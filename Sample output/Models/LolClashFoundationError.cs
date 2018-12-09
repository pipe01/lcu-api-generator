using Newtonsoft.Json;

namespace LCU_API_Generator
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
