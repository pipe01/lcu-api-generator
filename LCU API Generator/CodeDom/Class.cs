namespace LCU_API_Generator.CodeDom
{
    public abstract class Class : CodeItem
    {
        internal Class(string name, Documentation documentation) : base(name, documentation)
        {
        }
    }

    public sealed class SchemaClass : Class
    {
        public Field[] Fields { get; }

        internal SchemaClass(string name, Documentation documentation, Field[] fields) : base(name, documentation)
        {
            this.Fields = fields;
        }
    }

    public sealed class EnumClass : Class
    {
        public VariableType ItemsType { get; }
        public string[] ItemNames { get; }

        internal EnumClass(string name, Documentation documentation, VariableType itemsType, string[] itemNames) : base(name, documentation)
        {
            this.ItemsType = itemsType;
            this.ItemNames = itemNames;
        }
    }
}
