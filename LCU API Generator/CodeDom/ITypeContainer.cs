using System.Collections.Generic;

namespace LCU_API_Generator.CodeDom
{
    internal interface ITypeContainer
    {
        IEnumerable<VariableType> GetTypes();
    }
}
