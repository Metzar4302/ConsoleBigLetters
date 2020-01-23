using System;

namespace ConsoleBigLetters {
    public class Tools {
        public static void StartExecMsg () {
            WriteLineColorized ($"--=| START |=----------------------------------\n", ConsoleColor.DarkMagenta);
        }

        public static void EndExecMsg () {
            WriteLineColorized ($"\n----------------------------------=|  END  |=--", ConsoleColor.DarkMagenta);
        }

        public static void WriteColorized (string message, ConsoleColor color) {

            Console.ForegroundColor = color;
            Console.Write (message);
            Console.ResetColor ();
        }
        public static void WriteLineColorized (string message, ConsoleColor color) {

            Console.ForegroundColor = color;
            Console.WriteLine (message);
            Console.ResetColor ();
        }
    }
}