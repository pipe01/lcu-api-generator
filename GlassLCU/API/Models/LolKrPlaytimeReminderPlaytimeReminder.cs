using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolKrPlaytimeReminderPlaytimeReminder
    {
        [JsonProperty("hours")]
        public int Hours { get; set; }
    }
}
