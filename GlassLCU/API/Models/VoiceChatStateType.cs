using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum VoiceChatStateType
    {
        Disconnected,
        Connecting,
        Connected,
        Disconnecting,
        Initialized,
        Shuttingdown,
    }
}
