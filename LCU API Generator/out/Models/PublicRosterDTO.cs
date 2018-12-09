using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PublicRosterDTO
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("logo")]
        public int Logo { get; set; }
        [JsonProperty("logoColor")]
        public int LogoColor { get; set; }
        [JsonProperty("memberIds")]
        public long[] MemberIds { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("phasesSubs")]
        public PublicPhaseSubsDTO[] PhasesSubs { get; set; }
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
    }
}
