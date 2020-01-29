using System;
using System.Text;
using System.Threading;

namespace ConsoleBigLetters {
    public static class LEDDisplay {
        public static void MovementPrint (char[, ] arr, int velocity = 100, char symbol = '@', ConsoleColor color = ConsoleColor.DarkBlue) {
            
            char[, ] display = new char[arr.GetLength (0), (int) (arr.GetLength (1) * 1.5)];
            int displayRows = display.GetLength (0);
            int displayCols = display.GetLength (1);
            int shift = 0;
            int cycle = 0;
            StringBuilder strbResult = null;

            while (true)
            {
                cycle = cycle > displayCols ? 0 : ++cycle ;
                if (cycle == 0) {
                    shift = 0;
                }

                Console.Clear();
                
                display = MoveInfoOnDisplay(display);
                display = AddInfoToLastCol(display, arr, shift);
                shift++;
                
                strbResult = Symbols.ToOneLineArrayConvert (display);
                strbResult.Replace('#', symbol);

                Tools.WriteLineColorized($"{strbResult.ToString()}", color);
                
                Thread.Sleep(velocity);
            }
        }

        private static char[, ] MoveInfoOnDisplay(char[, ] arr){
            
            arr = Symbols.MoveArray(arr);

            return arr;
        }

        private static char[, ] AddInfoToLastCol(char[, ] display, char[,] arr, int shift){

            for (int i = 0; i < display.GetLength(0); i++) {
                display[i, display.GetLength(1)-1] = shift < arr.GetLength(1) ? arr[i, shift] : ' ';
            }

            return display;
        }
    }
}