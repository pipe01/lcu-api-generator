using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyRegistrationCredentials
    {
        [JsonProperty("inventoryToken")]
        public string InventoryToken { get; set; }
        [JsonProperty("inventoryTokens")]
        public string[] InventoryTokens { get; set; }
        [JsonProperty("rankedOverviewToken")]
        public string RankedOverviewToken { get; set; }
        [JsonProperty("simpleInventoryToken")]
        public string SimpleInventoryToken { get; set; }
        [JsonProperty("summonerToken")]
        public string SummonerToken { get; set; }
        [JsonProperty("userInfoToken")]
        public string UserInfoToken { get; set; }
    }
}
