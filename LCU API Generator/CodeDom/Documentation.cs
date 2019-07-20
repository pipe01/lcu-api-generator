using System.Collections.Generic;

namespace LCU_API_Generator.CodeDom
{
    public class Documentation
    {
        public string Summary { get; }

        internal Documentation(string summary)
        {
            this.Summary = summary;
        }
    }
}
