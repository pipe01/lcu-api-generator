using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolChatSessionState
    {
        Initializing,
        Connected,
        Loaded,
        Disconnected,
        Shuttingdown,
    }
}
