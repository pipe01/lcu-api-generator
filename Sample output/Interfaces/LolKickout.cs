using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolKickout
    {
        public static Task<LolKickoutKickoutMessage> GetLolKickoutV1Notification()
            => Sender.Request<LolKickoutKickoutMessage>("get", $"/lol-kickout/v1/notification");
    }
}
