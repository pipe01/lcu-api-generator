using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolKrPlaytimeReminder
    {
        public static Task<string> GetLolKrPlaytimeReminderV1Message()
            => Sender.Request<string>("get", $"/lol-kr-playtime-reminder/v1/message");
        public static Task<LolKrPlaytimeReminderPlaytimeReminder> GetLolKrPlaytimeReminderV1Playtime()
            => Sender.Request<LolKrPlaytimeReminderPlaytimeReminder>("get", $"/lol-kr-playtime-reminder/v1/playtime");
    }
}
