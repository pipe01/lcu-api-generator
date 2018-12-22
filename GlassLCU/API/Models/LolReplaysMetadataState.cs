using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolReplaysMetadataState
    {
        Checking,
        Found,
        Watch,
        Download,
        Downloading,
        Incompatible,
        MissingOrExpired,
        RetryDownload,
        Lost,
        Unsupported,
        Error,
    }
}
