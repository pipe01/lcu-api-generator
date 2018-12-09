using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolTencentQt
    {
        public static Task<object> GetLolTencentQtV1UiStates()
            => Sender.Request<object>("get", $"/lol-tencent-qt/v1/ui-states");
        public static Task<LolTencentQtTencentQTNotification> GetLolTencentQtV1UiStatesByFeature([Parameter("feature", "path")] string feature)
            => Sender.Request<LolTencentQtTencentQTNotification>("get", $"/lol-tencent-qt/v1/ui-states/{feature}");
        public static Task<object> PostLolTencentQtV1UiStatesByFeature([Parameter("feature", "path")] string feature, [Parameter("state", "body")] LolTencentQtTencentQTNotification state)
            => Sender.Request<object>("post", $"/lol-tencent-qt/v1/ui-states/{feature}", state);
    }
}