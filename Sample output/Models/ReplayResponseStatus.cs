using Newtonsoft.Json;

namespace LCU_API_Generator
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
