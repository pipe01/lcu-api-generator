using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolKrPlaytimeReminderPlaytimeReminder
    {
        [JsonProperty("hours")]
        public int Hours { get; set; }
    }
}
