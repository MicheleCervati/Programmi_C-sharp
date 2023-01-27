using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Conversione_DecBin_MetodoMatematico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numDec;
            double numBin=0; //numDec è il numero decimale inserito dall'utente e numBin il suo corrispondente calcolato in binario

            //int y = Console.WindowHeight/2, x = Console.WindowWidth/2;
            do
            {
                Console.WriteLine("Inserire Un valore decimale nel range di 1 byte");
                numDec = Convert.ToInt32(Console.ReadLine());
                if (numDec < 0 || numDec > 255)
                {
                    Console.WriteLine("valore non valido, inserire un altro valore (premi invio)"); //input numero con controllo dell'errore
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (numDec < 0 || numDec > 255);

            for(int i = 0; i < 8 ; i++)
            {
                if (numDec % 2 == 0)
                { //se il numero è pari non fa

                }
                else
                {
                    numBin = numBin + (numDec % 2) * Math.Pow(10, Convert.ToDouble(i));
                    numDec = numDec - 1; //se è dispari mette un1 in una posizione che si incrementa ad ogni ciclo
                }

                numDec = numDec / 2;
            }

            Console.WriteLine("Il numero binario ottenuto è: " + numBin);
            Console.ReadLine();
        }
    }
}
