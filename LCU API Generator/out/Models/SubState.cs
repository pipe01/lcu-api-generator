using Newtonsoft.Json;

namespace LCU_API_Generator
{
    public enum SubState
    {
        SUGGESTED,
        PENDING,
        DECLINED,
        REVOKED,
        NOT_READY,
        FORCED_NOT_READY,
        READY,
    }
}
