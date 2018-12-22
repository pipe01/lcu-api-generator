using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolHonorV2
    {
        public static Task<LolHonorV2Ballot> GetLolHonorV2V1Ballot()
            => Sender.Request<LolHonorV2Ballot>("get", $"/lol-honor-v2/v1/ballot");
        public static Task<LolHonorV2HonorConfig> GetLolHonorV2V1Config()
            => Sender.Request<LolHonorV2HonorConfig>("get", $"/lol-honor-v2/v1/config");
        public static Task<string> PostLolHonorV2V1HonorPlayer([Parameter("honorPlayerRequest", "body")] LolHonorV2ApiHonorPlayerServerRequest honorPlayerRequest)
            => Sender.Request<string>("post", $"/lol-honor-v2/v1/honor-player", honorPlayerRequest);
        public static Task<LolHonorV2Honor[]> GetLolHonorV2V1LateRecognition()
            => Sender.Request<LolHonorV2Honor[]>("get", $"/lol-honor-v2/v1/late-recognition");
        public static Task PostLolHonorV2V1LateRecognitionAck()
            => Sender.Request("post", $"/lol-honor-v2/v1/late-recognition/ack");
        public static Task<long> GetLolHonorV2V1LatestEligibleGame()
            => Sender.Request<long>("get", $"/lol-honor-v2/v1/latest-eligible-game");
        public static Task<LolHonorV2VendedHonorChange> GetLolHonorV2V1LevelChange()
            => Sender.Request<LolHonorV2VendedHonorChange>("get", $"/lol-honor-v2/v1/level-change");
        public static Task PostLolHonorV2V1LevelChangeAck()
            => Sender.Request("post", $"/lol-honor-v2/v1/level-change/ack");
        public static Task<LolHonorV2MutualHonor> GetLolHonorV2V1MutualHonor()
            => Sender.Request<LolHonorV2MutualHonor>("get", $"/lol-honor-v2/v1/mutual-honor");
        public static Task PostLolHonorV2V1MutualHonorAck()
            => Sender.Request("post", $"/lol-honor-v2/v1/mutual-honor/ack");
        public static Task<LolHonorV2ProfileInfo> GetLolHonorV2V1Profile()
            => Sender.Request<LolHonorV2ProfileInfo>("get", $"/lol-honor-v2/v1/profile");
        public static Task<LolHonorV2Honor[]> GetLolHonorV2V1Recognition()
            => Sender.Request<LolHonorV2Honor[]>("get", $"/lol-honor-v2/v1/recognition");
        public static Task<LolHonorV2VendedReward> GetLolHonorV2V1RewardGranted()
            => Sender.Request<LolHonorV2VendedReward>("get", $"/lol-honor-v2/v1/reward-granted");
        public static Task PostLolHonorV2V1RewardGrantedAck()
            => Sender.Request("post", $"/lol-honor-v2/v1/reward-granted/ack");
        public static Task<long[]> GetLolHonorV2V1TeamChoices()
            => Sender.Request<long[]>("get", $"/lol-honor-v2/v1/team-choices");
        public static Task<LolHonorV2VoteCompletion> GetLolHonorV2V1VoteCompletion()
            => Sender.Request<LolHonorV2VoteCompletion>("get", $"/lol-honor-v2/v1/vote-completion");
    }
}
