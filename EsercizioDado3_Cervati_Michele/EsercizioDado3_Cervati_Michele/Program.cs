using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;

namespace lancioDado
{
    class Program
    {
        static void Main(string[] args)
        {
            int centerx;
            int centery;


            centery = Console.WindowHeight / 2;
            centerx = Console.WindowWidth / 2;

            string giocatore1, giocatore2;
            Random casuale = new Random();
            int faccia = 0;
            int punteggioG1 = 0, punteggioG2 = 0;

            Console.Write("Giocatore1 inserisci il nome: ");
            giocatore1 = Console.ReadLine();
            Console.Write("Giocatore2 inserisci il nome: ");
            giocatore2 = Console.ReadLine();

            Console.Write(giocatore1 + " premi invio per far girare il dado \n");
            Console.ReadLine();


            punteggioG1 = casuale.Next(1, 7);




            for (int j = 0; j < 2; j++)
            {
                Console.SetCursorPosition(centerx - 7, centery);
                Console.WriteLine("=======");
                Console.SetCursorPosition(centerx - 7, centery + 4);
                Console.WriteLine("=======");

                for (int i = 1; i <= 7; i++)
                {
                    faccia = i;
                    if (faccia == 7)
                    {
                        if (j == 0)
                        {
                            faccia = punteggioG1;
                        }
                        else //j == 1 quindi è il turno di giocatore 2
                        {
                            faccia = punteggioG2;
                            Console.SetCursorPosition(0, centery + 10);
                            Console.WriteLine($"a {giocatore2} è uscito {punteggioG2}");
                        }
                    }

                    if (faccia == 1)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=     =");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=  0  =");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=     =");
                        Console.SetCursorPosition(centerx - 7, centery + 4);
                    }

                    else if (faccia == 2)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=0    =");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=     =");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=    0=");
                    }

                    else if (faccia == 3)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=0    =");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=  0  =");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=    0=");
                    }

                    else if (faccia == 4)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=0   0=");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=     =");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=0   0=");
                    }

                    else if (faccia == 5)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=0   0=");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=  0  =");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=0   0=");
                    }

                    else if (faccia == 6)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=0   0=");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=0   0=");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=0   0=");
                    }
                    Thread.Sleep(500);
                }
                if (j == 0)
                {
                    Console.SetCursorPosition(0, centery + 8);
                    Console.WriteLine($"a {giocatore1} è uscito {punteggioG1}");
                    Console.WriteLine($"{giocatore2} premi invio per far girare il dado");
                    Console.ReadLine();

                    punteggioG2 = casuale.Next(1, 7);
                }
            }
            Console.SetCursorPosition(0, centery + 11);
            if (punteggioG1 == punteggioG2) //pareggio
            {
                Console.WriteLine($"{giocatore1} e {giocatore2} avete ottenuto lo stesso punteggio. quindi PAREGGIO");
            }
            else if (punteggioG1 > punteggioG2)
            {
                Console.WriteLine($"HA VINTO {giocatore1}");
            }
            else { Console.WriteLine($"HA VINTO {giocatore2}"); }
            Console.ReadLine();
        }
    }
}
