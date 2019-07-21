using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace LCU_API_Generator.CodeDom
{
    public enum PrimitiveTypes
    {
        Int32,
        Int64,
        Boolean,
        String,
        Float,
        Double,
        UnknownObject
    }

    public abstract class VariableType
    {
    }

    [DebuggerDisplay("{Type}")]
    public sealed class PrimitiveVariableType : VariableType
    {
        public PrimitiveTypes Type { get; }

        internal PrimitiveVariableType(PrimitiveTypes type)
        {
            this.Type = type;
        }
    }

    [DebuggerDisplay("{Class.Name}")]
    public sealed class ClassVariableType : VariableType
    {
        public Class Class { get; }

        internal ClassVariableType(Class @class)
        {
            this.Class = @class;
        }
    }

    [DebuggerDisplay("{ItemsType}[]")]
    public sealed class ArrayVariableType : VariableType
    {
        public VariableType ItemsType { get; }

        internal ArrayVariableType(VariableType itemsType)
        {
            this.ItemsType = itemsType;
        }
    }
}
