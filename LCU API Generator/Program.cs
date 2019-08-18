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

        static int Main(string[] args)
        {
            Args = args;
            string configPath = args.FirstOrDefault(o => !o.StartsWith('-')) ?? "config.json";

            var config = Config.Load(configPath);
            config.Save(configPath);

            if (config.IncludeEndpoints?.Length > 0 && config.ExcludeEndpoints?.Length > 0)
            {
                using (SimpleConsoleColors.Red)
                    Console.WriteLine("You can't specify IncludeEndpoints and ExcludeEndpoints");
                PauseIfNotCli();

                return -1;
            }
            
            if (config.IncludePlugins?.Length > 0 && config.ExcludePlugins?.Length > 0)
            {
                using (SimpleConsoleColors.Red)
                    Console.WriteLine("You can't specify IncludePlugins and ExcludePlugins");
                PauseIfNotCli();

                return -1;
            }

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
                    using (SimpleConsoleColors.DarkGray)
                        Console.WriteLine("Reading file at " + config.SwaggerFile);

                    swagger = File.ReadAllText(config.SwaggerFile);
                }
                else
                {
                    using (SimpleConsoleColors.Red)
                        Console.WriteLine("Swagger file at '{0}' not found", IOPath.GetFullPath(config.SwaggerFile));
                    PauseIfNotCli();
                    return -1;
                }
            }
            
            var json = JObject.Parse(swagger);
            var conv = new OpenApiToDom(json);

            var allClasses = conv.ParseAllSchemas();
            var allPaths = conv.ParseAllTags().ToArray();
            var usedClasses = new HashSet<Class>(new ClassEqualityComparer());
            var pathsToGenerate = new List<PathsClass>();

            if (!AddPaths(config, allPaths, pathsToGenerate))
                return -1;

            IGenerator gen = new CSharpGenerator(new CSharpOptions
            {
                SchemaNamespace = "My.Namespace"
            });
            var workspace = new Workspace(new GeneratorOptions(), "gen/");

            gen.Setup(workspace);


            Console.Write("Generating interfaces: ");
            ConsoleWriter.SetInitial();

            foreach (var cls in pathsToGenerate)
            {
                ConsoleWriter.Write(cls.Name);
                usedClasses.AddRange(((ITypeContainer)cls).GetTypes().OfType<ClassVariableType>().Select(o => o.Class));

                gen.GenerateInterface(cls, workspace);
            }

            using (SimpleConsoleColors.Green)
                ConsoleWriter.Write("Done!");
            Console.WriteLine();


            Console.Write("Generating models: ");
            ConsoleWriter.SetInitial();

            foreach (var cls in usedClasses)
            {
                ConsoleWriter.Write(cls.Name);

                gen.GenerateSchema(cls, workspace);
            }

            using (SimpleConsoleColors.Green)
                ConsoleWriter.Write("Done!");


            gen.Finish(workspace);

            Console.WriteLine();
            Console.WriteLine();
            using (SimpleConsoleColors.Green)
                Console.WriteLine($"Successfully generated {pathsToGenerate.Count} interfaces and {usedClasses.Count} classes");
            PauseIfNotCli();

            return 0;
        }

        private static bool AddPaths(Config config, IEnumerable<PathsClass> allPaths, List<PathsClass> list)
        {
            if (config.IncludePlugins != null)
            {
                foreach (var item in config.IncludePlugins)
                {
                    list.AddRange(allPaths.Where(o => o.Name.Equals(item, StringComparison.OrdinalIgnoreCase)));
                }
            }
            else if (config.ExcludePlugins != null)
            {
                list.AddRange(allPaths.Where(o => !Array.Exists(config.ExcludePlugins, i => i == o.Name)));
            }

            if (config.IncludeEndpoints != null)
            {
                var allMethods = new List<(PathsClass, Method[])>();

                foreach (var item in allPaths)
                {
                    var methodsToInclude = item.Methods.Where(o => config.IncludeEndpoints.Contains(o.Path)).ToArray();

                    if (methodsToInclude.Length > 0)
                        list.Add(item.Copy(methodsToInclude));
                }
            }
            else if (config.ExcludeEndpoints != null)
            {
                int i = 0;

                foreach (var cls in list)
                {
                    var methodsToRemove = new List<Method>();

                    foreach (var method in cls.Methods)
                    {
                        if (config.ExcludeEndpoints.Contains(method.Path))
                            methodsToRemove.Add(method);
                    }

                    if (methodsToRemove.Count > 0)
                        list[i] = cls.Copy(cls.Methods.Except(methodsToRemove).ToArray());

                    i++;
                }
            }

            return true;
        }

        private static void PauseIfNotCli()
        {
            if (!Args.Contains("--cli"))
                Console.ReadKey(true);
        }

        private static Task<string> GetSwaggerFromClient()
        {
            Console.WriteLine("Trying to connect to client");

            if (!LCU.Connect())
            {
                Console.WriteLine("Make sure the client is running!");
                PauseIfNotCli();
                return Task.FromResult<string>(null);
            }

            return LCU.GetOpenAPI();
        }
    }

    public class ClassEqualityComparer : IEqualityComparer<Class>
    {
        public bool Equals(Class x, Class y) => x.Name == y.Name;

        public int GetHashCode(Class obj) => obj.Name.GetHashCode();
    }
}
