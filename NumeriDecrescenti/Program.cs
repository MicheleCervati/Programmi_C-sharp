using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeriDecrescenti
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrivere un programma in C# per
visualizzare in ordine decrescente i numeri divisibili per 5 partendo da un
numero inserito dall’utente che deve essere maggiore di 5 e minore o uguale a 200;
se l’utente inserisce un numero al di fuori di questo intervallo, il programma
deve chiedere nuovamente il numero. Al termine della visualizzazione il programma
deve chiedere all’utente se vuole inserire un nuovo numero o se il programma
deve terminare. Con risposta SI il programma chiede un nuovo numero con
risposta NO il programma termina (SI e NO possono essere scritti in maiuscolo,
minuscolo, o misto; il programma deve capire comunque)*/


            int num;
            string multipli = "";
            bool NuovoNumero = false, rispostaAccettabile = true;  //per determinare se l'utente vuole inserire un altro numero oppure no
            string risposta = ""; //la risposta dell'utente che è una stringa che può essere si oppure no
            do
            {
                do
                {
                    Console.WriteLine("Inserisci un numeroi da 5 a 200"); //input numero dell'utente con controllo dell'errore ( il numero deve essere compreso tra 5 e 200)
                    num = Convert.ToInt32(Console.ReadLine());
                    if(num > 200 || num < 5)
                    {
                        Console.WriteLine("Numero non valido");
                    }
                } while (num > 200 || num < 5);


                num = num - (num % 5); //il numero viene decrementato fino al multiplo di 5 più vicino

                for(int i = num; i > 5; i = i - 5) //output dei numeri 
                {
                    multipli = multipli + i + "  ";
                }
                Console.WriteLine(multipli);

                Console.WriteLine("Vuoi inserire un nuovo numero? (Si/No) "); //chiede se vuole inserire un altro numero 

                do //lo ripete fin quando l'utente vuole
                {
                    risposta = Console.ReadLine().ToLower(); //trasforma la risposta in una stringa di minuscole
                    switch (risposta) //switch per determinare la risposta dell'utente
                    {
                        case "si":
                            NuovoNumero = true;
                            rispostaAccettabile = true;
                            break;
                        case "no":
                            NuovoNumero = false;
                            rispostaAccettabile = true;
                            break;
                        default:
                            Console.WriteLine("Inserisci si oppure no: ");
                            rispostaAccettabile = false;
                            break;
                    }
                } while (rispostaAccettabile == false);
            } while (NuovoNumero == true);
            Console.ReadLine();
        }
    }
}
