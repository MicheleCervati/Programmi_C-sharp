//Realizzare un'applicazione console che permetta, dato in input un valore in base 10 compreso nel range 0-255, di convertirlo in base 16.
//Ricorda: i valori 10,11,12,13,14,15 vengono convertiti in esadecimale con i caratteri A, B C, D, E, F.
//Se sei riuscito a risolvere l'esercizio prova a migliorarlo in modo tale che il valore in base 10 venga convertito in una qualsiasi base compresa
//tra 2 e 16.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversioneDiBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numInserito;
            int i = 0;
            int[] numTraformato = new int[8]; 
            string numTrasformatoFinito="";
            int resto;
            int baseNum;
            bool inizioNum = false;
            string[] cifre = new string[] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"};

            do
            {
                Console.WriteLine("Inserire un valore in base 10 compreso tra 0 e 255: ");
                numInserito = Convert.ToInt32(Console.ReadLine());
            }while(numInserito <= 0 || numInserito > 255);

            do
            {
                Console.WriteLine("Inserire la base in cui convertirlo (2-16): ");
                baseNum = Convert.ToInt32(Console.ReadLine());
            } while (baseNum <= 1 || baseNum > 16);


            do
            {
                resto = numInserito % baseNum;
                numInserito = numInserito / baseNum;
                numTraformato[i] = resto;
                i++;
            }while(numInserito != 0);

            for(int j= numTraformato.Length; j>0; j--)
            {
                if (numTraformato[j - 1] == 0 && inizioNum == false)
                {

                }
                else
                {
                    numTrasformatoFinito = numTrasformatoFinito + cifre[numTraformato[j - 1]];
                    inizioNum = true;
                }
            }



            //Console.WriteLine(numTraformato[0]);
            //Console.WriteLine(numTraformato[1]);
            Console.WriteLine($"Il risultato in base {baseNum} è {numTrasformatoFinito}");
            Console.ReadLine();
        }
    }
}
