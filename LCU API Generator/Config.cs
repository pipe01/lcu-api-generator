using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCU_API_Generator
{
    public class Config
    {
        [JsonProperty("modelNamespace")]
        public string ModelNamespace { get; set; }

        [JsonProperty("interfaceNamespace")]
        public string InterfaceNamespace { get; set; }

        [JsonProperty("outFolder")]
        public string OutFolder { get; set; }

        [JsonProperty("classVisibility")]
        public string ClassVisibility { get; set; }
    }
}
