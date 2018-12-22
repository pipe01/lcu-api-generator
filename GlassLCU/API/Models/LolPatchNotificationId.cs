using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    public enum LolPatchNotificationId
    {
        UnspecifiedError,
        ConnectionError,
        MissingFilesError,
        FailedToWriteError,
        WillRestoreClientBackupOnRestart,
        DidRestoreClientBackup,
    }
}
