using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum ReplayResponseStatus
    {
        OK,
        NOT_FOUND,
        EXPIRED,
        BAD_REQUEST,
        INTERNAL_SERVER_ERROR,
    }
}
