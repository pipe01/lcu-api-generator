using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolSettings
    {
        public static Task<bool> GetLolSettingsV1AccountDidreset()
            => Sender.Request<bool>("get", $"/lol-settings/v1/account/didreset");
        public static Task PostLolSettingsV1AccountSave()
            => Sender.Request("post", $"/lol-settings/v1/account/save");
        public static Task<object> GetLolSettingsV1AccountByCategory([Parameter("category", "path")] string category)
            => Sender.Request<object>("get", $"/lol-settings/v1/account/{category}");
        public static Task<object> PatchLolSettingsV1AccountByCategory([Parameter("category", "path")] string category, [Parameter("settingsResource", "body")] LolSettingsSettingCategory settingsResource)
            => Sender.Request<object>("patch", $"/lol-settings/v1/account/{category}", settingsResource);
        public static Task<object> PutLolSettingsV1AccountByCategory([Parameter("category", "path")] string category, [Parameter("settingsResource", "body")] LolSettingsSettingCategory settingsResource)
            => Sender.Request<object>("put", $"/lol-settings/v1/account/{category}", settingsResource);
        public static Task<object> GetLolSettingsV1LocalByCategory([Parameter("category", "path")] string category)
            => Sender.Request<object>("get", $"/lol-settings/v1/local/{category}");
        public static Task<object> PatchLolSettingsV1LocalByCategory([Parameter("category", "path")] string category, [Parameter("settingsResource", "body")] LolSettingsSettingCategory settingsResource)
            => Sender.Request<object>("patch", $"/lol-settings/v1/local/{category}", settingsResource);
        public static Task<object> GetLolSettingsV2AccountByPpTypeByCategory([Parameter("ppType", "path")] string ppType, [Parameter("category", "path")] string category)
            => Sender.Request<object>("get", $"/lol-settings/v2/account/{ppType}/{category}");
        public static Task<object> PatchLolSettingsV2AccountByPpTypeByCategory([Parameter("ppType", "path")] string ppType, [Parameter("category", "path")] string category, [Parameter("settingsResource", "body")] LolSettingsSettingCategory settingsResource)
            => Sender.Request<object>("patch", $"/lol-settings/v2/account/{ppType}/{category}", settingsResource);
        public static Task<object> PutLolSettingsV2AccountByPpTypeByCategory([Parameter("ppType", "path")] string ppType, [Parameter("category", "path")] string category, [Parameter("settingsResource", "body")] LolSettingsSettingCategory settingsResource)
            => Sender.Request<object>("put", $"/lol-settings/v2/account/{ppType}/{category}", settingsResource);
        public static Task<bool> GetLolSettingsV2DidresetByPpType([Parameter("ppType", "path")] string ppType)
            => Sender.Request<bool>("get", $"/lol-settings/v2/didreset/{ppType}");
        public static Task<object> GetLolSettingsV2LocalByCategory([Parameter("category", "path")] string category)
            => Sender.Request<object>("get", $"/lol-settings/v2/local/{category}");
        public static Task<object> PatchLolSettingsV2LocalByCategory([Parameter("category", "path")] string category, [Parameter("settingsResource", "body")] LolSettingsSettingCategory settingsResource)
            => Sender.Request<object>("patch", $"/lol-settings/v2/local/{category}", settingsResource);
        public static Task<bool> GetLolSettingsV2Ready()
            => Sender.Request<bool>("get", $"/lol-settings/v2/ready");
    }
}
