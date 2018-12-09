using Newtonsoft.Json;

namespace LCU_API_Generator
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
