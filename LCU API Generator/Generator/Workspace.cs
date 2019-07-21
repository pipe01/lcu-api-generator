using System.IO;

namespace LCU_API_Generator.Generator
{
    public class Workspace
    {
        public GeneratorOptions Options { get; }

        private readonly string Root;

        internal Workspace(GeneratorOptions options, string root)
        {
            this.Options = options;
            this.Root = root;

            Directory.CreateDirectory(root);
        }

        public void WriteToFile(string fileName, string contents)
        {
            string path = Path.Combine(Root, fileName);

            Directory.CreateDirectory(Path.GetDirectoryName(path));
            File.WriteAllText(path, contents);
        }
    }
}
