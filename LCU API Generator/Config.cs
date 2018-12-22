using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LCU_API_Generator
{
    public class Config
    {
        [JsonProperty("swaggerFile")]
        public string SwaggerFile { get; set; } = "./swagger.json";

        [JsonProperty("getSwaggerFromClient")]
        public bool GetSwaggerFromClient { get; set; }

        [JsonProperty("modelNamespace")]
        public string ModelNamespace { get; set; } = "MyNamespace.Models";

        [JsonProperty("interfaceNamespace")]
        public string InterfaceNamespace { get; set; } = "MyNamespace.Interfaces";

        [JsonProperty("generationUtilsFullName")]
        public string GenerationUtilsFullName { get; set; } = "MyNamespace.GenerationUtils";

        [JsonProperty("interfaceOutFolder")]
        public string InterfaceOutFolder { get; set; } = "./out/Interfaces";

        [JsonProperty("modelOutFolder")]
        public string ModelOutFolder { get; set; } = "./out/Models";

        [JsonProperty("classVisibility")]
        public string ClassVisibility { get; set; } = "public";

        [JsonProperty("useProperties")]
        public bool UseProperties { get; set; } = true;

        private Config()
        {
        }

        public void Save(string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(this, Formatting.Indented));
        }

        public static Config Load(string path, bool create = true)
        {
            if (!File.Exists(path))
            {
                if (!create)
                    return null;

                var cfg = new Config();
                cfg.Save(path);

                return cfg;
            }

            return JsonConvert.DeserializeObject<Config>(File.ReadAllText(path));
        }
    }
}
