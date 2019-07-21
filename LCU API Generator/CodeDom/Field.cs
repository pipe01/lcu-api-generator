using System.Collections.Generic;

namespace LCU_API_Generator.CodeDom
{
    public class Field : CodeItem, ITypeContainer
    {
        public VariableType Type { get; }

        public Field(string name, Documentation documentation, VariableType type) : base(name, documentation)
        {
            this.Type = type;
        }

        IEnumerable<VariableType> ITypeContainer.GetTypes() => new[] { Type };
    }
}
