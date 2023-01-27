using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es1_Pag190_Cervati_Michele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num; //num è la varoble di input dell'utente
            int numCopia; //numCopia è una copia del valore di num per i calcoli e l'output
            int j = 0; //j è una varbile per contenere il risultato finale dei calcoli

            Console.Write("Inserisci il numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            numCopia = num; //input num e assegnazione numCopia al valore di num
            for(int i = 0; i < numCopia; i++) // ciclo che si ripete num volte
            {
                num = numCopia - i; // ad ogni ciclo num diminuisce di 1 e a j viene aggiunto il valore corrente di num
                j = j + num; 
            }
            Console.WriteLine($"La somma dei numeri interi minori di {numCopia} e {j}");//output valore
            Console.ReadLine();
        }
    }
}
