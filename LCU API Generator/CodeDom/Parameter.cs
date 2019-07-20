namespace LCU_API_Generator.CodeDom
{
    public class Parameter : CodeItem
    {
        public VariableType Type { get; set; }

        public Parameter(string name, Documentation documentation, VariableType type) : base(name, documentation)
        {
            this.Type = type;
        }
    }
}
