namespace LCU_API_Generator.CodeDom
{
    public class Field : CodeItem
    {
        public VariableType Type { get; }

        public Field(string name, Documentation documentation, VariableType type) : base(name, documentation)
        {
            this.Type = type;
        }
    }
}
