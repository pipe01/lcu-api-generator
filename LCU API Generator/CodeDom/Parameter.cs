using System.Collections.Generic;
using System.Diagnostics;

namespace LCU_API_Generator.CodeDom
{
    public enum ParameterPosition
    {
        Header,
        Path,
        Query
    }

    [DebuggerDisplay("{Name} of type {Type} in {Position}")]
    public class Parameter : CodeItem, ITypeContainer
    {
        public VariableType Type { get; }
        public ParameterPosition Position { get; }
        public bool Required { get; }

        public Parameter(string name, Documentation documentation, VariableType type, ParameterPosition position, bool required)
            : base(name, documentation)
        {
            this.Type = type;
            this.Position = position;
            this.Required = required;
        }

        IEnumerable<VariableType> ITypeContainer.GetTypes() => new[] { Type };
    }
}
