using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolPreEndOfGame
    {
        public static Task PostLolPreEndOfGameV1CompleteBySequenceEventName([Parameter("sequenceEventName", "path")] string sequenceEventName)
            => Sender.Request("post", $"/lol-pre-end-of-game/v1/complete/{sequenceEventName}");
        public static Task<LolPreEndOfGameSequenceEvent> GetLolPreEndOfGameV1CurrentSequenceEvent()
            => Sender.Request<LolPreEndOfGameSequenceEvent>("get", $"/lol-pre-end-of-game/v1/currentSequenceEvent");
        public static Task DeleteLolPreEndOfGameV1RegistrationBySequenceEventName([Parameter("sequenceEventName", "path")] string sequenceEventName)
            => Sender.Request("delete", $"/lol-pre-end-of-game/v1/registration/{sequenceEventName}");
        public static Task PostLolPreEndOfGameV1RegistrationBySequenceEventNameByPriority([Parameter("sequenceEventName", "path")] string sequenceEventName, [Parameter("priority", "path")] int priority)
            => Sender.Request("post", $"/lol-pre-end-of-game/v1/registration/{sequenceEventName}/{priority}");
    }
}
