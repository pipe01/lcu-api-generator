using System.Runtime.CompilerServices;
using System.Text;

namespace LCU_API_Generator.Generator
{
    public static class StringBuilderExtensions
    {
        private class StringBuilderData
        {
            public int Indentation;
        }

        private static ConditionalWeakTable<StringBuilder, StringBuilderData> DataTable = new ConditionalWeakTable<StringBuilder, StringBuilderData>();

        public static StringBuilder AppendIndentation(this StringBuilder builder)
        {
            return builder.Append(new string(' ', DataTable.GetOrCreateValue(builder).Indentation * 4));
        }

        public static StringBuilder Indent(this StringBuilder builder)
        {
            DataTable.GetOrCreateValue(builder).Indentation++;
            return builder;
        }

        public static StringBuilder Unindent(this StringBuilder builder)
        {
            DataTable.GetOrCreateValue(builder).Indentation--;
            return builder;
        }
    }
}
