using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_Cilindro_Cervati_Michele
{
    internal class VCilindro
    {
        static void Main(string[] args)
        {
            double vCilindro; // dichiaro 3 variabili di tipo double per fare le operazioni con numeri più precisi
            double altezza;
            double raggio;

            do //controllo con un do while che i valori di raggio e altezza siano maggiori di 0 
            {
                Console.Write("Inserisci raggio cilindro: ");
                raggio = Convert.ToDouble(Console.ReadLine());
            } while (raggio <= 0);

            do {
                Console.Write("Inserisci altezza cilindro: ");
                altezza = Convert.ToDouble(Console.ReadLine());
            } while (altezza <= 0); 

            vCilindro = raggio * raggio * Math.PI * altezza; //calcolo il volume del cilindro (Math.PI è il PI greco in una varibile double)

            Console.Write("Volume cilindro: "); //mando in output il volume approssimato alla terza cifra decimale tramite la funzione Math.round()
            Console.Write(Math.Round(vCilindro, 3));
            Console.ReadLine();
        }
    }
}
