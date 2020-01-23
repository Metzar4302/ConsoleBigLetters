using System;

namespace ConsoleBigLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            Symbols.Init ();

            string numTest = "0123456789 ?!";
            string abcTest = "KASUD ы";

            Symbols.PrintThisShit (numTest, '@');
            // Console.WriteLine("");
            Symbols.PrintThisShit (abcTest, '@', ConsoleColor.DarkCyan);

            #endregion
        }
    }
}
