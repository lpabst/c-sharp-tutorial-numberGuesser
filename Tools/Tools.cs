using System;

namespace NumberGuesser
{
    static class Tools
    {
        public static void ColorConsole(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
