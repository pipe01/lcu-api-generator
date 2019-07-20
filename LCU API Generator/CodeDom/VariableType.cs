using Newtonsoft.Json.Linq;

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

    public sealed class PrimitiveVariableType : VariableType
    {
        public PrimitiveTypes Type { get; }

        internal PrimitiveVariableType(PrimitiveTypes type)
        {
            this.Type = type;
        }
    }

    public sealed class ClassVariableType : VariableType
    {
        public Class Class { get; }

        internal ClassVariableType(Class @class)
        {
            this.Class = @class;
        }
    }

    public sealed class ArrayVariableType : VariableType
    {
        public VariableType ItemsType { get; }

        internal ArrayVariableType(VariableType itemsType)
        {
            this.ItemsType = itemsType;
        }
    }
}
