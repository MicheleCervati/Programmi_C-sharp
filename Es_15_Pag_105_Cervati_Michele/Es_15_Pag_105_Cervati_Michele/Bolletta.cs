using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_15_Pag_105_Cervati_Michele
{
    internal class Bolletta
    {
        static void Main(string[] args)
        {
            int scattiLetti;
            int scattiPrecedenti;
            float costoPerScatto;
            float canoneFisso; //valore che va aggiunto al totale della bolletta
            float bolletta;

            //inserimento dati
            Console.Write("Inserisci il numero di scatti letti sul contatore: ");
            scattiLetti =  Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserisci il numero di scatti presenti nella bolletta precedente: ");
            scattiPrecedenti = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserisci il costo per scatto: ");
            costoPerScatto = Convert.ToSingle(Console.ReadLine());
            Console.Write("Inserisci il costo del canone: ");
            canoneFisso = Convert.ToSingle(Console.ReadLine());
            //calcolo bolletta
            bolletta = ((scattiLetti - scattiPrecedenti) * costoPerScatto) + canoneFisso;
            //output bolletta
            Console.WriteLine("La bolletta finale ammonta a {0:#.##} euro e il canone fisso è {1}", bolletta, canoneFisso);
            Console.WriteLine("La bolletta finale ammonta a {0, 10} euro e il canone fisso è {1, -10}", bolletta, canoneFisso);
            Console.ReadLine();


        }
    }
}
