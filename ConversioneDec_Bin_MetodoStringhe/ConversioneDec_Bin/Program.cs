using System;

namespace ConversioneDec_Bin
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numDec;
            int resto;
            string numBinContrario = "";
            string numBin = "";
            string numBinTotale = "";
            int f;


            do
            {
                Console.WriteLine("Inserisci un valore da convertire in binario");
                numDec = Convert.ToInt32(Console.ReadLine());
            } while (numDec > 255 || numDec <= 0);

            do
            {
                resto = numDec % 2;

                if (resto == 1)
                {
                    numBinContrario = numBinContrario + "0";

                }
                else
                {
                    numBinContrario = numBinContrario + "1";
                }


                numDec = numDec / 2;

            } while (numDec != 1);


            f = Convert.ToInt32(numBinContrario);

            for (int j = 0; j < numBinContrario.Length; j++)
            {
                if (f % 2 == 0)
                {
                    numBin = numBin + "1";
                }
                else
                {
                    numBin = numBin + "0";
                }

                f = f / 10;
            }

            numBin = "1" + numBin;
            numBinTotale = numBin;

            Console.WriteLine("IL VALORE IN BASE 2 è: " + numBin);


            for (int p = 0; p < (8 - numBin.Length); p++)
            {
                numBinTotale = "0" + numBinTotale;
            }

            Console.WriteLine("Quindi il byte è: " + numBinTotale);
            Console.ReadLine();
        }
    }
}


