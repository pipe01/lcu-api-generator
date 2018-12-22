using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum PatcherNotificationId
    {
        UnspecifiedError,
        ConnectionError,
        MissingFilesError,
        FailedToWriteError,
        WillRestoreClientBackupOnRestart,
        DidRestoreClientBackup,
    }
}
