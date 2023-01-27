using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Pag181_Cervati_Michele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num; //numero di cui fare la tabellina

            Console.Write("Inserisci il numero: ");
            num = Convert.ToInt32(Console.ReadLine()); //input numero

            for (int i = 1; i < 11; i++) //ciclo che si ripete 10 volte e manda in output la tabellina del numero scelto
            { //il ciclo parte da 1 perchè così la tabellina parte da uno altrimenti num * 0 fa sempre 0
                Console.WriteLine(num + " * " + i + " = " + num*i); 
            }
            Console.ReadLine();
        }
    }
}
