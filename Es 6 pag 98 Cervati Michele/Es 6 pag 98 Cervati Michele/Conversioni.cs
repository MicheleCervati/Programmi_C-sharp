using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_6_pag_98_Cervati_Michele
{
    internal class Conversioni
    {
        static void Main(string[] args)
        {
            double saldo; //saldo input utente in euro
            const double cambioLiraEuro = 19.26;
            const double cambioDollaroEuro = 1.03;
            double lire;
            double dollari;

            Console.Write("Inserisci saldo in euro: ");
            saldo = Convert.ToDouble(Console.ReadLine()); //input saldo in euro

            lire = saldo * cambioLiraEuro; //calcolo lire e dollari corrispondenti
            dollari = saldo * cambioDollaroEuro;
            Console.WriteLine("I tuoi {0} euro valgono L.:{1:00000.00}", saldo, saldo * cambioDollaroEuro); //ogni cancelletto corrisponde ad una cifra
                                                                                                            // Console.Write($"{saldo} euro in lire sono £{lire} ed in dollari corrispondono a ${(saldo * cambioDollaroEuro).ToString("")}"); //output conversioni
            Console.ReadLine();
        }
    }
}








