using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksPerkPageResource
    {
        [JsonProperty("autoModifiedSelections")]
        public int[] AutoModifiedSelections { get; set; }
        [JsonProperty("current")]
        public bool Current { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
        [JsonProperty("isDeletable")]
        public bool IsDeletable { get; set; }
        [JsonProperty("isEditable")]
        public bool IsEditable { get; set; }
        [JsonProperty("isValid")]
        public bool IsValid { get; set; }
        [JsonProperty("lastModified")]
        public long LastModified { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("order")]
        public int Order { get; set; }
        [JsonProperty("primaryStyleId")]
        public int PrimaryStyleId { get; set; }
        [JsonProperty("selectedPerkIds")]
        public int[] SelectedPerkIds { get; set; }
        [JsonProperty("subStyleId")]
        public int SubStyleId { get; set; }
    }
}