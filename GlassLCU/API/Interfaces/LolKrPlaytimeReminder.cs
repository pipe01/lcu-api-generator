using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class LolKrPlaytimeReminder
    {
        public static Task<string> GetLolKrPlaytimeReminderV1Message()
            => Sender.Request<string>("get", $"/lol-kr-playtime-reminder/v1/message");
        public static Task<LolKrPlaytimeReminderPlaytimeReminder> GetLolKrPlaytimeReminderV1Playtime()
            => Sender.Request<LolKrPlaytimeReminderPlaytimeReminder>("get", $"/lol-kr-playtime-reminder/v1/playtime");
    }
}
