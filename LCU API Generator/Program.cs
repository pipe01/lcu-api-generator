using LCU_API_Generator.CodeDom;
using LCU_API_Generator.Generator;
using LCU_API_Generator.Generator.CSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimpleConsoleColor;
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

            if (args.Contains("--client"))
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

            var allClasses = conv.ParseAllSchemas();
            var allPaths = conv.ParseAllTags().Take(4).ToArray();
            var usedClasses = new List<Class>();

            IGenerator gen = new CSharpGenerator();
            var workspace = new Workspace(new GeneratorOptions
            {
                SchemaNamespace = "My.Namespace"
            }, "gen/");

            gen.Setup(workspace);

            Console.Write("Generating interfaces: ");
            ConsoleWriter.SetInitial();
            foreach (var cls in allPaths)
            {
                ConsoleWriter.Write(cls.Name);
                usedClasses.AddRange(((ITypeContainer)cls).GetTypes().OfType<ClassVariableType>().Select(o => o.Class));

                gen.GenerateInterface(cls, workspace);
            }
            ConsoleWriter.Write("Done!");
            Console.WriteLine();

            Console.Write("Generating models: ");
            ConsoleWriter.SetInitial();
            foreach (var cls in usedClasses)
            {
                ConsoleWriter.Write(cls.Name);

                gen.GenerateSchema(cls, workspace);
            }
            ConsoleWriter.Write("Done!");

            gen.Finish(workspace);

            Console.WriteLine();
            Console.WriteLine("All done!");
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
