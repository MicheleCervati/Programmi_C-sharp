using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prendiParola
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxParole = 3;
            char tasto;
            int contParole = 0;
            string numeri = "", parola = "";
            bool trovato = false;
            string[] dizionario = new string[maxParole];
            Console.WriteLine("inserire sequenza di caratteri");
            do
            {
                tasto = Convert.ToChar(Console.Read());
                if (Char.IsLetter(tasto))
                {
                    parola = parola + Convert.ToChar(tasto);
                }
                else if (tasto == ' ' || tasto == 13)
                // prendo una parola quando trovo uno spazio o cr
                {
                    if (contParole == maxParole)
                    {
                        Console.WriteLine("Dizionario pieno");
                    }
                    else
                    {
                        trovato = false;
                        for (int i = 0; i < contParole && !trovato; i++)
                        {
                            trovato = parola == dizionario[i];
                        }
                        if (!trovato)
                        {
                            dizionario[contParole] = parola;
                            contParole++;
                        }

                    }
                    parola = "";
                }

            } while (tasto != 13);

            for (int i = 0; i < contParole; i++)
            {
                Console.WriteLine(dizionario[i]);
            }
            Console.ReadLine(); // salta line feed
            Console.ReadLine(); // serve per bloccare programma

        }
    }
}   // la mamma va al mercato
    // la 
    // mamma
    // va
    // al
    // mercato