using Newtonsoft.Json;

namespace LCU_API_Generator
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
