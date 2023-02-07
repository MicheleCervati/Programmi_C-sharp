using System;

namespace cifreRandom_2._0
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int[] numeri = new int[10];
            Random causale = new Random();
            int numEstratto;

            for (int i = 0; i < 10; i++)
            {
                numEstratto = causale.Next(0, 10);
                numeri[numEstratto] = -1;
                Console.WriteLine("Il numero estratto è " + numEstratto);
            }

            for (int j = 0; j < 10; j++)
            {
                if (numeri[j] == -1)
                {
                    Console.WriteLine("Non è uscito il numero: " + j);
                }
            }
            Console.ReadLine();
        }
    }
}
