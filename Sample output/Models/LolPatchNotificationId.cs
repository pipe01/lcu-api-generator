using Newtonsoft.Json;

namespace LCU_API_Generator
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
