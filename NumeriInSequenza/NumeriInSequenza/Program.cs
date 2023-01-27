using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeriInSequenza
{
    class Program
    {
        static void Main(string[] args)
        {
            int num; //il numero inserito dall'utente

            int numeri = 0; //contiene al suo interno la cifra più a destra di num 
            int i = 1;
            int contatore0 = 0; //inizializzo i contatori a 0
            int contatore1 = 0;
            int contatore2 = 0;
            int contatore3 = 0;
            int contatore4 = 0;
            int contatore5 = 0;
            int contatore6 = 0;
            int contatore7 = 0;
            int contatore8 = 0;
            int contatore9 = 0;

            Console.WriteLine("Inserisci una sequenza di numeri");
            do
            {
                 contatore1 = 0; //azzero i contatori
                 contatore2 = 0;
                 contatore3 = 0;
                 contatore4 = 0;
                 contatore5 = 0;
                 contatore6 = 0;
                 contatore7 = 0;
                 contatore8 = 0;
                 contatore9 = 0;
                Console.WriteLine("Numero: ");
                num = Convert.ToInt32(Console.ReadLine()); //input num

                // string cifre = "";
                if (num != 0) //se è 0 il programma termina subito
                {

                    while (num % 10 != 0)  //num viene diviso ad ogni ciclo per 10 fin quando non arriva a 0 e il ciclo termina
                    {
                        // cifre = "\n la " + i + " cifra è  " + num % 10;
                        numeri = num % 10; //a numeri viene assemgnata la cifra più a destra di num con %10
                        //Console.WriteLine(cifre);
                        num = num / 10;
                        switch (numeri) //in base al valore che ottiene numeri si incrementa il proprio contatori
                        {
                            case 1:
                                contatore1++;
                                break;
                            case 2:
                                contatore2++;
                                break;
                            case 3:
                                contatore3++;
                                break;
                            case 4:
                                contatore4++;
                                break;
                            case 5:
                                contatore5++;
                                break;
                            case 6:
                                contatore6++;
                                break;
                            case 7:
                                contatore7++;
                                break;
                            case 8:
                                contatore8++;
                                break;
                            case 9:
                                contatore9++;
                                break;
                            case 0:
                                
                                break;
                        }
                        i++;
                    }


                    if(contatore1 != 0) //output dei dati solo se il loro valore è diverso da 0
                    {
                        Console.WriteLine($"la cifra 1 compare {contatore1} volte\n");
                    }
                    if (contatore2 != 0)
                    {
                        Console.WriteLine($"la cifra 2 compare {contatore2} volte\n");
                    }
                    if (contatore3 != 0)
                    {
                        Console.WriteLine($"la cifra 3 compare {contatore3} volte\n");
                    }
                    if (contatore4 != 0)
                    {
                        Console.WriteLine($"la cifra 4 compare {contatore4} volte\n");
                    }
                    if (contatore5 != 0)
                    {
                        Console.WriteLine($"la cifra 5 compare {contatore5} volte\n");
                    }
                    if (contatore6 != 0)
                    {
                        Console.WriteLine($"la cifra 6 compare {contatore6} volte\n");
                    }
                    if (contatore7 != 0)
                    {
                        Console.WriteLine($"la cifra 7 compare {contatore7} volte\n");
                    }
                    if (contatore8 != 0)
                    {
                        Console.WriteLine($"la cifra 8 compare {contatore8} volte\n");
                    }
                    if (contatore9 != 0)
                    {
                        Console.WriteLine($"la cifra 9 compare {contatore9} volte\n");
                    }

                    /*
                                        Console.WriteLine($"la cifra 1 compare {contatore1} volte\n" +
                                            $"la cifra 2 compare {contatore2} volte\n" +
                                            $"la cifra 3 compare {contatore3} volte\n" +
                                            $"la cifra 4 compare {contatore4} volte\n" +
                                            $"la cifra 5 compare {contatore5} volte\n" +
                                            $"la cifra 6 compare {contatore6} volte\n" +
                                            $"la cifra 7 compare {contatore7} volte\n" +
                                            $"la cifra 8 compare {contatore8} volte\n" +
                                            $"la cifra 9 compare {contatore9} volte\n"); */
                }
                else {
                    contatore0 = 1; //se il numero inserito all'inizio è 0 il suo contatore viene messo a 1 e fa finire il ciclo
                }
            } while (contatore0 == 0);

            Console.WriteLine("Hai inserito uno 0 quindi il programma è finito"); //il programma termina solamente quando l input dell'utente è 0
            Console.ReadLine();
        }
    }
}
