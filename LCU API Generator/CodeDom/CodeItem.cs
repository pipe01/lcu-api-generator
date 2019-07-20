namespace LCU_API_Generator.CodeDom
{
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
