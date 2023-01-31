using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rettangoloDinamico
{
    class Program
    {
        static void Main(string[] args)
        {
            int Base, Altezza;
            bool nuovoRettangolo = false, rispostaAccettabile = true;  //per determinare se l'utente vuole inserire un altro numero oppure no
            string risposta = ""; //la risposta dell'utente che è una stringa che può essere si oppure no
            string simbolo = "*";
            int[] metaSchermo = new int[2];

            metaSchermo[0] = Console.WindowWidth / 2;
            metaSchermo[1] = Console.WindowHeight / 2;
            do
            {
                Console.Clear();
                do
                {
                Console.WriteLine("Inserisci la base: ");
                    Base = Convert.ToInt32(Console.ReadLine());
                } while (Base < 3 || Base >= 30);

                do
                {
                    Console.WriteLine("Inserisci l' altezza: ");
                    Altezza = Convert.ToInt32(Console.ReadLine());
                } while (Altezza < 3 || Altezza >= 30);

                Console.SetCursorPosition(metaSchermo[0] - (Base / 2), metaSchermo[1] - (Altezza / 2));
                for (int j = 0; j <= Altezza; j++)
                {
                    for (int i = 0; i < Base; i++)
                    {
                        Console.Write(simbolo);
                    }
                    Console.SetCursorPosition(metaSchermo[0] - (Base / 2), metaSchermo[1] - (Altezza / 2) + j);
                }

                Console.SetCursorPosition(0, Console.WindowHeight -2);

                Console.WriteLine("Vuoi inserire un nuovo numero? (Si/No) "); //chiede se vuole inserire un altro numero 

                do //lo ripete fin quando l'utente vuole
                {
                    risposta = Console.ReadLine().ToLower(); //trasforma la risposta in una stringa di minuscole
                    switch (risposta) //switch per determinare la risposta dell'utente
                    {
                        case "si":
                            nuovoRettangolo = true;
                            rispostaAccettabile = true;
                            break;
                        case "no":
                            nuovoRettangolo = false;
                            rispostaAccettabile = true;
                            break;
                        default:
                            Console.WriteLine("Inserisci si oppure no: ");
                            rispostaAccettabile = false;
                            break;
                    }
                } while (rispostaAccettabile == false);



            } while (nuovoRettangolo == true);
            Console.ReadLine();
        }
    }
}
