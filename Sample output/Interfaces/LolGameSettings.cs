using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolGameSettings
    {
        public static Task<bool> GetLolGameSettingsV1Didreset()
            => Sender.Request<bool>("get", $"/lol-game-settings/v1/didreset");
        public static Task<object> GetLolGameSettingsV1GameSettings()
            => Sender.Request<object>("get", $"/lol-game-settings/v1/game-settings");
        public static Task<object> PatchLolGameSettingsV1GameSettings([Parameter("settingsResource", "body")] object settingsResource)
            => Sender.Request<object>("patch", $"/lol-game-settings/v1/game-settings", settingsResource);
        public static Task<object> GetLolGameSettingsV1GameSettingsSchema()
            => Sender.Request<object>("get", $"/lol-game-settings/v1/game-settings-schema");
        public static Task<object> GetLolGameSettingsV1InputSettings()
            => Sender.Request<object>("get", $"/lol-game-settings/v1/input-settings");
        public static Task<object> PatchLolGameSettingsV1InputSettings([Parameter("settingsResource", "body")] object settingsResource)
            => Sender.Request<object>("patch", $"/lol-game-settings/v1/input-settings", settingsResource);
        public static Task<object> GetLolGameSettingsV1InputSettingsSchema()
            => Sender.Request<object>("get", $"/lol-game-settings/v1/input-settings-schema");
        public static Task<bool> GetLolGameSettingsV1Ready()
            => Sender.Request<bool>("get", $"/lol-game-settings/v1/ready");
        public static Task PostLolGameSettingsV1ReloadPostGame()
            => Sender.Request("post", $"/lol-game-settings/v1/reload-post-game");
        public static Task<bool> PostLolGameSettingsV1Save()
            => Sender.Request<bool>("post", $"/lol-game-settings/v1/save");
    }
}
