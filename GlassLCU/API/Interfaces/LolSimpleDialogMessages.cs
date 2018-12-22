using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolSimpleDialogMessages
    {
        public static Task<LolSimpleDialogMessagesMessage[]> GetLolSimpleDialogMessagesV1Messages()
            => Sender.Request<LolSimpleDialogMessagesMessage[]>("get", $"/lol-simple-dialog-messages/v1/messages");
        public static Task<object> PostLolSimpleDialogMessagesV1Messages([Parameter("messageRequest", "body")] LolSimpleDialogMessagesLocalMessageRequest messageRequest)
            => Sender.Request<object>("post", $"/lol-simple-dialog-messages/v1/messages", messageRequest);
        public static Task<object> DeleteLolSimpleDialogMessagesV1MessagesByMessageId([Parameter("messageId", "path")] long messageId)
            => Sender.Request<object>("delete", $"/lol-simple-dialog-messages/v1/messages/{messageId}");
    }
}
