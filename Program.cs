using System;
using System.Text;
using System.Threading;

namespace ConsoleBigLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            Symbols.Init ();

            string kasudText = "KASUD";

            char[, ] result = Symbols.ConvertToWordArray (kasudText);

            Symbols.MovementPrint(result, 50);

            #endregion
        }
    }
}
