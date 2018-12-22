using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
