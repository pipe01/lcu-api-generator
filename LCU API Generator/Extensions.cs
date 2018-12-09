﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCU_API_Generator
{
    internal static class Extensions
    {
        private static string[] Keywords = new[]
           {
            "bool", "byte", "sbyte", "short", "ushort", "int", "uint", "long", "ulong", "double", "float", "decimal",
            "string", "char", "void", "object", "typeof", "sizeof", "null", "true", "false", "if", "else", "while", "for", "foreach", "do", "switch",
            "case", "default", "lock", "try", "throw", "catch", "finally", "goto", "break", "continue", "return", "public", "private", "internal",
            "protected", "static", "readonly", "sealed", "const", "fixed", "stackalloc", "volatile", "new", "override", "abstract", "virtual",
            "event", "extern", "ref", "out", "in", "is", "as", "params", "__arglist", "__makeref", "__reftype", "__refvalue", "this", "base",
            "namespace", "using", "class", "struct", "interface", "enum", "delegate", "checked", "unchecked", "unsafe", "operator", "implicit", "explicit"
        };


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
        
        public static string Prettify(this string str, bool firstUpper = false)
        {
            var name = "";

            bool upper = firstUpper;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (upper)
                {
                    upper = false;
                    c = char.ToUpper(c);
                }

                if (c == '-')
                {
                    upper = true;
                    continue;
                }

                name += c;
            }

            if (Keywords.Contains(name))
                name = "@" + name;

            return name;
        }

    }
}
