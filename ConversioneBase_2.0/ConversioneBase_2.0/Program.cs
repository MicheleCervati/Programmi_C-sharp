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
            int numInserito; //input dell'utente
            int i = 0; //contatore
            int[] numTraformato = new int[8]; //dove viene salvato il numero traformato con gli 0 inutili
            string numTrasformatoFinito = "";
            int resto;
            int baseNum;
            bool inizioNum = false;
            string cifre = "0123456789ABCDEF";

            do //input numero da converitre con controllo dell'errore
            {
                Console.WriteLine("Inserire un valore in base 10 compreso tra 0 e 255: ");
                numInserito = Convert.ToInt32(Console.ReadLine());
            } while (numInserito <= 0 || numInserito > 255);

            do //input base in cui convertire il numero con controllo dell'errore
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
            } while (numInserito != 0); //salva nell'array numTrasformato il resto della divisione tra il num in base 10 e la base in cui bisogna convertirlo
                                        //che corrisponde al numero stesso traformato nella base scelta

            for (int j = numTraformato.Length; j > 0; j--) //rimuove gli 0 inutili prima del numero es. 00010101 ==> 10101
            {
                if (numTraformato[j - 1] == 0 && inizioNum == false)  //scorre tutto l'array e se trova degli 0 passa avanti e se trova un numero lo scrive 
                {                                                     //nell'array numTrasformatoFinito e da li savla tutte le cifre succesive

                }
                else
                {
                    numTrasformatoFinito = numTrasformatoFinito + cifre[numTraformato[j - 1]];
                    inizioNum = true;//serve a dire quando inizia il numero e dunque finiscono gli 0 inutili
                }
            }



            //Console.WriteLine(numTraformato[0]);
            //Console.WriteLine(numTraformato[1]);
            Console.WriteLine($"Il risultato in base {baseNum} è {numTrasformatoFinito}"); //output risultati
            Console.ReadLine();
        }
    }
}