using System.Collections.Generic;

namespace LCU_API_Generator.CodeDom
{
    public class Method : CodeItem
    {
        public IDictionary<string, Parameter> Parameters { get; }

        internal Method(string name, Documentation documentation, IDictionary<string, Parameter> parameters) : base(name, documentation)
        {
            this.Parameters = parameters;
        }
    }
}
