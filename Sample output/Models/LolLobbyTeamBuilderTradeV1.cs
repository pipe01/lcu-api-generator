using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderTradeV1
    {
        [JsonProperty("cellId")]
        public int CellId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
    }
}