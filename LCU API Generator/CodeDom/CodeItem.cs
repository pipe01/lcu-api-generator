using System.Diagnostics;

namespace LCU_API_Generator.CodeDom
{
    [DebuggerDisplay("{Name}")]
    public abstract class CodeItem
    {
        public string Name { get; }
        public Documentation Documentation { get; }

        internal CodeItem(string name, Documentation documentation)
        {
            this.Name = name;
            this.Documentation = documentation;
        }
    }
}
