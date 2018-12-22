using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolLoginAccountStateType
    {
        CREATING,
        ENABLED,
        TRANSFERRING_OUT,
        TRANSFERRING_IN,
        TRANSFERRED_OUT,
        GENERATING,
    }
}
