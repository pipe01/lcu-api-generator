using System.Collections.Generic;
using System.Linq;

namespace LCU_API_Generator.CodeDom
{
    public abstract class Class : CodeItem
    {
        internal Class(string name, Documentation documentation) : base(name, documentation)
        {
        }
    }

    public sealed class SchemaClass : Class, ITypeContainer
    {
        public Field[] Fields { get; }

        internal SchemaClass(string name, Documentation documentation, Field[] fields) : base(name, documentation)
        {
            this.Fields = fields;
        }

        IEnumerable<VariableType> ITypeContainer.GetTypes() => Fields.OfType<ITypeContainer>().SelectMany(o => o.GetTypes());
    }

    public sealed class PathsClass : Class, ITypeContainer
    {
        public Method[] Methods { get; }

        public PathsClass(string name, Documentation documentation, Method[] methods) : base(name, documentation)
        {
            this.Methods = methods;
        }

        IEnumerable<VariableType> ITypeContainer.GetTypes() => Methods.SelectMany(o => (o as ITypeContainer).GetTypes());
    }

    public sealed class EnumClass : Class, ITypeContainer
    {
        public VariableType ItemsType { get; }
        public string[] ItemNames { get; }

        internal EnumClass(string name, Documentation documentation, VariableType itemsType, string[] itemNames) : base(name, documentation)
        {
            this.ItemsType = itemsType;
            this.ItemNames = itemNames;
        }

        IEnumerable<VariableType> ITypeContainer.GetTypes() => ItemsType.Yield();
    }

    public sealed class SelfClass : Class
    {
        internal SelfClass(string name, Documentation documentation) : base(name, documentation)
        {
        }
    }
}
