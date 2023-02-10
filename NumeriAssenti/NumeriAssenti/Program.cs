using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeriAssenti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Estrarre 10 numeri casuali nel range 0 - 9 e
            //1 - stampare i valori che non sono usciti.
            //2 - stampare i valori usciti e non usciti(in modo che l'utente capisca quali sono le due tipologia)




            int quantiN = 10; //quanti numeri devono essere estratti
            int[] numeri = new int[quantiN]; //l'array contenente i numeri estratti

            Random casuale = new Random();
            int numEstratto; //il numero che viene estratto
            string numeriUsciti = ""; //una stringa che contiene i numeri usciti e non usciti
            string numeriNonUsciti = "";

            Console.WriteLine("Sono stati estratti i seguenti numeri: ");
            for (int i = 0; i < quantiN; i++)
            {
                numEstratto = casuale.Next(0,10); //estrae un numero casuale da 1 a 10 (non compreso)
                Console.WriteLine(numEstratto);
                numeri[numEstratto] = 1; //viene messo a 1 il numero nell indice estratto
            }

            for(int j=0; j<numeri.Length; j++)
            {
                if(numeri[j] == 1)
                {
                    numeriUsciti = numeriUsciti + j + "\n"; //se il numero nell indice è 1 viene inserito l'indice tra i numeri usciti, altrimenti tra quelli non usciti
                }
                else
                {
                    numeriNonUsciti = numeriNonUsciti + j + "\n";
                }
            }


            Console.WriteLine("\nI numeri usciti sono: \n" + numeriUsciti); //output risultati
            Console.WriteLine("I numeri NON usciti sono: \n" + numeriNonUsciti);

            Console.ReadLine();
        }
    }
}
