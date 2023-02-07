using System;

namespace cifreRandom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random casuale = new Random();
            int[] numeri = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int numCasuale;
            string numNonUsciti = "";

            for (int i = 0; i < 10; i++)
            {
                numCasuale = casuale.Next(0, 10);
                Console.WriteLine(numCasuale);
                for (int j = 0; j < numeri.Length; j++)
                {
                    if (numCasuale == numeri[j])
                    {
                        numeri[j] = -1;
                    }
                }
            }

            for (int p = 0; p < numeri.Length; p++)
            {
                Console.WriteLine("ciao " + numeri[p]);
                if (numeri[p] != -1)
                {
                    numNonUsciti = numNonUsciti + numeri[p];
                }
            }

            Console.WriteLine("I numeri non usciti sono: ");
            Console.WriteLine(numNonUsciti);
            Console.ReadLine();
        }
    }
}
