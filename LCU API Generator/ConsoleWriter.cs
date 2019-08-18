using System;

namespace LCU_API_Generator
{
    public static class ConsoleWriter
    {
        private static int InitialLeft, InitialTop, LastLength;

        public static void SetInitial()
        {
            InitialLeft = Console.CursorLeft;
            InitialTop = Console.CursorTop;
            LastLength = 0;
        }

        public static void Write(string str)
        {
            Console.SetCursorPosition(InitialLeft, InitialTop);

            Console.Write(str);
            if (str.Length < LastLength)
                Console.Write(new string(' ', LastLength - str.Length));
            LastLength = str.Length;
        }
    }
}
