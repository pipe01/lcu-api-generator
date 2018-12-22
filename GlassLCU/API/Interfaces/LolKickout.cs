using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolKickout
    {
        public static Task<LolKickoutKickoutMessage> GetLolKickoutV1Notification()
            => Sender.Request<LolKickoutKickoutMessage>("get", $"/lol-kickout/v1/notification");
    }
}
