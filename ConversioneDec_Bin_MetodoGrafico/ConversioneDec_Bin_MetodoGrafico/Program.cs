using System;

namespace ConversioneDec_Bin_MetodoGrafico
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numDec, resto, contBit = 0;
            int x, y;
            //y = Console.WindowHeight / 2;
            //x = Console.WindowWidth / 2;
            do
            {
                Console.WriteLine("Inserisci un numero decimale");
                numDec = Convert.ToInt32(Console.ReadLine());
            } while (numDec > 255 && numDec <= 0);
            Console.Write("Valore in base due:");
            x = Console.CursorLeft + 8;
            y = Console.CursorTop;
            //Console.Write($"coordiata {x}");
            //Console.WriteLine($"coordinata {y}");

            // conversione da base 10 a base 2
            do
            {
                resto = numDec % 2;
                numDec = numDec / 2;
                contBit++;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(x--, y);
                Console.Write(resto);
            } while (numDec != 0);
            for (int i = 0; i < 8 - contBit; i++)
            {
                Console.SetCursorPosition(x--, y);
                Console.Write("0");
            }

            Console.ReadLine();

        }
    }
}
