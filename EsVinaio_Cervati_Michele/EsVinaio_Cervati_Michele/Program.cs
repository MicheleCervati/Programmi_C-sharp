using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsVinaio_Cervati_Michele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double costoL = 2, capacitaBottiglione = 1.5, litriPerSconto = 45, sconto = 0.1, prezzoDomicilio = 3;
            string domicilio = "N", fineGiornata = "N";
            int nBottiglioni = 0, i=0;
            double totaleParziale = 0, totaleParzialeScontato = 0, LFineGiornata = 0, valoreSconto = 0, costoDomicilio = 0, totaleDomicili = 0, totaleSconti = 0, totaleIncassi = 0, totaleTrasporti = 0, totaleLitri = 0, totaleBottiglioni = 0;
            //costoL è il costo per litro, litriPerSconto sono i litri necessaari per ottenere lo sconto del 10%, prezzoDomicilio è quanto costa la consegna a domicilio
            //Domicilio indica se il cliente ha richiesto o meno l'opzione, fineGiornata indica se dobbiamo fare altri scontrini o no
            //nBottiglioni è il numero di bottiglioni ordinati dal cliente
            //i è il contatore degli scontrini che si incrementa ad ogni ciclo
            //TotaleParziale è il costo dei litri * il loro prezzo. TotaleParziale scontato è il totale parziale - lo sconto. Totale trasporti è il totaleParziale + i trasporti
            //valoreSconto indica quanto vale lo sconto assoluto rispetto al totaleParziale
            //le altre varibili servnon per il resoconto finale a finegiornata 
            do
            {
                i++; //numero scontrino
                Console.WriteLine("Benvenuto alla tana dei goti!");//listino del vino con quanto costa e come si ottiene lo sconto
                Console.WriteLine($"Un litro di Barbera costa {costoL} euro e viene venduto in bottiglioni da {capacitaBottiglione} litri l'uno, se però si acquistano più di {litriPerSconto} litri si ottiene uno sconto del {sconto * 100}%");
                Console.Write("Quanti bottiglioni di Barbera vuoi acquistare? ");
                do //controllo per verificare che non vengano immessi nBottigioni negativi, in caso si entra in un ciclo finche non si mette un valore >0
                {
                    nBottiglioni = Convert.ToInt32(Console.ReadLine());
                    if (nBottiglioni <= 0)
                    {
                        Console.Write("Inserire un'importo valido di bottiglioni: ");
                    }
                } while (nBottiglioni <= 0);
                Console.Write("Desidera la consegna a domicilio? (S/N)");
                do
                {
                    domicilio = Console.ReadLine(); //controllo perchè venga inserito solo N o S nella consegna a domicilio
                    if (domicilio != "S" && domicilio != "N")
                    {
                        Console.Write("Rispondere con S oppure N: ");
                    }
                } while (domicilio != "S" && domicilio != "N");

                totaleLitri = nBottiglioni * capacitaBottiglione;
                totaleParziale = totaleLitri * costoL;
                if(domicilio == "S")
                {
                    costoDomicilio = prezzoDomicilio; //se viene scelto domicilio si allora il costo del domicilio è uguale al prezzo altrimenti è 0
                }
                else
                {
                    costoDomicilio = 0;
                }
                totaleTrasporti = totaleParzialeScontato + costoDomicilio;
                if (totaleLitri > litriPerSconto) //se si ottiene lo sconto viene stampato uno scontrino con lo sconto altrimenti uno senza quella voce
                {
                    valoreSconto = totaleParziale * sconto;
                    totaleParzialeScontato = totaleParziale - valoreSconto;
                    totaleTrasporti = totaleParzialeScontato + costoDomicilio;
                    Console.WriteLine("Questo è il suo scontrino: ");
                    Console.Write($"(========= Tana dei Goti =========== )\r\n(Barbera {nBottiglioni} bottiglioni ({totaleLitri} litri) importo Totale {totaleParziale} Euro )\r\n(Sconto 10% {valoreSconto} euro)\r\n(=======================================)\r\n(Totale parziale {totaleParzialeScontato} euro)\r\n( Spese di trasporto {costoDomicilio} )\r\n( =======================================)\r\n(Importo Totale {totaleTrasporti} euro )\r\n( n° {i} scontrino)\r\n(========= Arrivederci =========)");

                }
                else
                {
                    totaleTrasporti = totaleParziale + costoDomicilio;
                    Console.WriteLine("Questo è il suo scontrino: ");
                    Console.Write($"(========= Tana dei Goti =========== )\r\n(Barbera {nBottiglioni} bottiglioni ({totaleLitri} litri) importo Totale {totaleParziale} Euro )\r\n(=======================================)\r\n( Spese di trasporto {costoDomicilio} euro)\r\n( =======================================)\r\n(Importo Totale {totaleTrasporti} euro )\r\n( n° {i} scontrino)\r\n(========= Arrivederci =========)");
                }

                totaleBottiglioni = totaleBottiglioni + nBottiglioni;
                LFineGiornata = LFineGiornata + totaleLitri;
                totaleIncassi = totaleIncassi + totaleTrasporti;
                totaleSconti = totaleSconti + valoreSconto;//calcolo totali per resoconto finale dopo la fine della giornata
                totaleDomicili = totaleDomicili + costoDomicilio;
                
                Console.WriteLine("\nSiamo a fine giornata? (S/N) ");
                do
                { //controllo per verificare che venga inserito solo S o N nel siamo a fine giornata
                    fineGiornata = Console.ReadLine();
                    if (fineGiornata != "S" && fineGiornata != "N")
                    {
                        Console.Write("Rispondere con S oppure N: ");
                    }
                } while (fineGiornata != "S" && fineGiornata != "N");


            } while (fineGiornata == "N"); //finche la gironata non è finita vengono stampati altri scontrini
            Console.WriteLine("La giornata è finta, ecco il resoconto: "); //resoconto finale con tutte le statistiche
            Console.Write($"(========= Tana dei Goti =========== )\r\n(========= Chiusura Cassa =========== )\r\n(Barbera Totale: n° bottiglioni {totaleBottiglioni}, n° litri {LFineGiornata})\r\n(=======================================)\r\n(Totale Sconto {totaleSconti} euro)\r\n(Totale Incasso {totaleIncassi} euro)\r\n( Totale Spese di trasporto {totaleDomicili} euro)\r\n( n° scontrini emessi {i})\r\n(========= Arrivederci =========)");
            Console.ReadLine();
        }
    }
}
