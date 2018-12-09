using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolPlayerLevelUp
    {
        public static Task<LolPlayerLevelUpPlayerLevelUpEvent> GetLolPlayerLevelUpV1LevelUp()
            => Sender.Request<LolPlayerLevelUpPlayerLevelUpEvent>("get", $"/lol-player-level-up/v1/level-up");
        public static Task<LolPlayerLevelUpPlayerLevelUpEventAck> GetLolPlayerLevelUpV1LevelUpNotificationsByPluginName([Parameter("pluginName", "path")] string pluginName)
            => Sender.Request<LolPlayerLevelUpPlayerLevelUpEventAck>("get", $"/lol-player-level-up/v1/level-up-notifications/{pluginName}");
        public static Task PostLolPlayerLevelUpV1LevelUpNotificationsByPluginName([Parameter("pluginName", "path")] string pluginName, [Parameter("levelUpEventAck", "body")] LolPlayerLevelUpPlayerLevelUpEventAck levelUpEventAck)
            => Sender.Request("post", $"/lol-player-level-up/v1/level-up-notifications/{pluginName}", levelUpEventAck);
    }
}
