using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using IOPath = System.IO.Path;

namespace LCU_API_Generator
{
    class Program
    {
        private static string[] Args;

        static void Main(string[] args)
        {
            Args = args;
            string configPath = args.FirstOrDefault(o => !o.StartsWith('-')) ?? "config.json";

            var config = Config.Load(configPath);
            config.Save(configPath);

            if (args.Contains("-client"))
                config.GetSwaggerFromClient = true;

            string swagger = null;

            if (config.GetSwaggerFromClient)
            {
                //try
                //{
                //    swagger = await GetSwaggerFromClient();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Failed to get swagger file:");
                //    Console.WriteLine(ex);
                //    ReadIfNotCli();
                //    return;
                //}

                //if (swagger == null)
                //    return;
            }
            else
            {
                if (File.Exists(config.SwaggerFile))
                {
                    Console.WriteLine("Reading file at " + config.SwaggerFile);

                    swagger = File.ReadAllText(config.SwaggerFile);
                }
                else
                {
                    Console.WriteLine("Swagger file at '{0}' not found", IOPath.GetFullPath(config.SwaggerFile));
                    ReadIfNotCli();
                    return;
                }
            }
            
            var json = JObject.Parse(swagger);
            var conv = new OpenApiToDom(json);

            var classes = conv.ParseAllSchemas();
            var paths = conv.ParsePathsUnderTag("Plugins");


            Console.WriteLine();
            Console.WriteLine("Done!");
            ReadIfNotCli();
        }

        private static void ReadIfNotCli()
        {
            if (!Args.Contains("-cli"))
                Console.ReadKey(true);
        }

        private static Task<string> GetSwaggerFromClient()
        {
            Console.WriteLine("Trying to connect to client");

            if (!LCU.Connect())
            {
                Console.WriteLine("Make sure the client is running!");
                ReadIfNotCli();
                return null;
            }

            return LCU.GetOpenAPI();
        }
    }
}
