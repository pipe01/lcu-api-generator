using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class GameflowLcdsPlayerCredentialsDto
    {
        [JsonProperty("encryptionKey")]
        public string EncryptionKey { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("observer")]
        public bool Observer { get; set; }
        [JsonProperty("observerEncryptionKey")]
        public string ObserverEncryptionKey { get; set; }
        [JsonProperty("observerServerIp")]
        public string ObserverServerIp { get; set; }
        [JsonProperty("observerServerPort")]
        public int ObserverServerPort { get; set; }
        [JsonProperty("serverIp")]
        public string ServerIp { get; set; }
        [JsonProperty("serverPort")]
        public int ServerPort { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
