using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es6_Pag142_Cervati_Michele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float spesa;
            float spesaOriginale;
            int primoSconto = 50;
            int secondoSconto = 65;
            int terzoSconto = 80;

            int percSconto1 = 5;
            int percSconto2 = 6;
            int percSconto3 = 7;
            int percSconto4 = 10;

            Console.Write("Inserire l importo totale della spesa: ");
            spesa = Convert.ToSingle(Console.ReadLine());
            spesaOriginale = spesa;

            if(spesa < primoSconto)
            {
                spesa = spesa - (spesa*percSconto1/100);
                Console.WriteLine($"Hai ottenuto uno sconto del {percSconto1}%");
            }
            else if(spesa < secondoSconto)
            {
                spesa = spesa - (spesa * percSconto2 / 100);
                Console.WriteLine($"Hai ottenuto uno sconto del {percSconto2}%");
            }
            else if(spesa < terzoSconto)
            {
                spesa = spesa - (spesa * percSconto3 / 100);
                Console.WriteLine($"Hai ottenuto uno sconto del {percSconto3}%");

            }
            else
            {
                spesa = spesa - (spesa * percSconto4 / 100);
                Console.WriteLine($"Hai ottenuto uno sconto del {percSconto4}%");

            }

            Console.Write("La spesa originale era di euro {0:n2}\n", spesaOriginale);
            Console.Write("La spesa scontata invece è di euro {0:n2}\n", spesa);
            Console.ReadLine();

        }
    }
}
