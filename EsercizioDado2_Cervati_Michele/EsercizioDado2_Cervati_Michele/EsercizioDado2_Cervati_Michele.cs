using System;
using System.Threading;

namespace EsercizioDado2_Cervati_Michele
{
    internal class EsercizioDado2_Cervati_Michele
    {
        static void Main(string[] args)
        {
            int centerX = Console.WindowWidth / 2, centerY = Console.WindowHeight / 2;
            int ultimaFaccia;
            bool ultimaFacciaMostrata = false;
            Console.Write("Che faccia vuoi visulizzare come ultima? (inserisci un valore da 1 a 6) ");
            ultimaFaccia = Convert.ToInt32(Console.ReadLine());



            for (int i = 1; i < 8; i++)
            {
                Console.SetCursorPosition(centerX - 7, centerY);
                Console.WriteLine("======");
                Console.SetCursorPosition(centerX - 7, centerY + 1);

                if (i == 7) // quando i == 7 e quindi sono stati mandati a schermo tutte le faccie del dado
                {
                    i = ultimaFaccia;
                    ultimaFacciaMostrata = true;
                }
                if (i == 1)
                {
                    //dado 1
                    Console.WriteLine("=    =");
                    Console.SetCursorPosition(centerX - 7, centerY + 2);
                    Console.WriteLine("=  0 =");
                    Console.SetCursorPosition(centerX - 7, centerY + 3);
                    Console.WriteLine("=    =");
                }

                else if (i == 2)
                {

                    //dado 2

                    Console.WriteLine("= 0  =");
                    Console.SetCursorPosition(centerX - 7, centerY + 2);
                    Console.WriteLine("=    =");
                    Console.SetCursorPosition(centerX - 7, centerY + 3);
                    Console.WriteLine("=   0=");

                }

                else if (i == 3)
                {
                    //dado 3

                    Console.WriteLine("= 0  =");
                    Console.SetCursorPosition(centerX - 7, centerY + 2);
                    Console.WriteLine("=  0 =");
                    Console.SetCursorPosition(centerX - 7, centerY + 3);
                    Console.WriteLine("=   0=");

                }

                else if (i == 4)
                {
                    //dado 4

                    Console.WriteLine("= 0 0=");
                    Console.SetCursorPosition(centerX - 7, centerY + 2);
                    Console.WriteLine("=    =");
                    Console.SetCursorPosition(centerX - 7, centerY + 3);
                    Console.WriteLine("= 0 0=");

                }

                else if (i == 5)
                {
                    //dado 5
                    Console.WriteLine("= 0 0=");
                    Console.SetCursorPosition(centerX - 7, centerY + 2);
                    Console.WriteLine("=  0 =");
                    Console.SetCursorPosition(centerX - 7, centerY + 3);
                    Console.WriteLine("= 0 0=");
                }
                else
                {

                    //dado 6

                    Console.WriteLine("= 0 0=");
                    Console.SetCursorPosition(centerX - 7, centerY + 2);
                    Console.WriteLine("= 0 0=");
                    Console.SetCursorPosition(centerX - 7, centerY + 3);
                    Console.WriteLine("= 0 0=");

                }

                if (ultimaFacciaMostrata)
                {
                    i = 8;
                }

                Console.SetCursorPosition(centerX - 7, centerY + 4);
                Console.WriteLine("======");

                Thread.Sleep(1000);

            };

            Console.ReadLine();
        }
    }
}
