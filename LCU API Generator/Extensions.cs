using System;
using System.Collections.Generic;
using System.Text;

namespace LCU_API_Generator
{
    internal static class Extensions
    {
        public static StringBuilder AppendLine(this StringBuilder builder, string str, int level)
            => builder.AppendLine($"{new string(' ', level * 4)}{str}");

        public static StringBuilder Append(this StringBuilder builder, string str, int level)
            => builder.Append($"{new string(' ', level * 4)}{str}");

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            var knownKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (knownKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}
