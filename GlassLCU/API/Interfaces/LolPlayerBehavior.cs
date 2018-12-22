using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolPlayerBehavior
    {
        public static Task<LolPlayerBehaviorBanNotification> GetLolPlayerBehaviorV1Ban()
            => Sender.Request<LolPlayerBehaviorBanNotification>("get", $"/lol-player-behavior/v1/ban");
        public static Task<LolPlayerBehaviorRestrictionNotification> GetLolPlayerBehaviorV1ChatRestriction()
            => Sender.Request<LolPlayerBehaviorRestrictionNotification>("get", $"/lol-player-behavior/v1/chat-restriction");
        public static Task<LolPlayerBehaviorPlayerBehaviorConfig> GetLolPlayerBehaviorV1Config()
            => Sender.Request<LolPlayerBehaviorPlayerBehaviorConfig>("get", $"/lol-player-behavior/v1/config");
        public static Task<LolPlayerBehaviorRestrictionNotification> GetLolPlayerBehaviorV1RankedRestriction()
            => Sender.Request<LolPlayerBehaviorRestrictionNotification>("get", $"/lol-player-behavior/v1/ranked-restriction");
        public static Task<LolPlayerBehaviorReformCard> GetLolPlayerBehaviorV1ReformCard()
            => Sender.Request<LolPlayerBehaviorReformCard>("get", $"/lol-player-behavior/v1/reform-card");
        public static Task<LolPlayerBehaviorReporterFeedback[]> GetLolPlayerBehaviorV1ReporterFeedback()
            => Sender.Request<LolPlayerBehaviorReporterFeedback[]>("get", $"/lol-player-behavior/v1/reporter-feedback");
        public static Task<LolPlayerBehaviorReporterFeedback> DeleteLolPlayerBehaviorV1ReporterFeedbackById([Parameter("id", "path")] string id)
            => Sender.Request<LolPlayerBehaviorReporterFeedback>("delete", $"/lol-player-behavior/v1/reporter-feedback/{id}");
        public static Task<LolPlayerBehaviorReporterFeedback> GetLolPlayerBehaviorV1ReporterFeedbackById([Parameter("id", "path")] string id)
            => Sender.Request<LolPlayerBehaviorReporterFeedback>("get", $"/lol-player-behavior/v1/reporter-feedback/{id}");
        public static Task<LolPlayerBehaviorReformCardV2> GetLolPlayerBehaviorV2ReformCard()
            => Sender.Request<LolPlayerBehaviorReformCardV2>("get", $"/lol-player-behavior/v2/reform-card");
    }
}
