using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FrequenzaCaratteriInUnaFrase_CervatiMichele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizzare un programma che legga una frase con Console.Read() e che permetta(utilizzando un vettore)
            //di determinare la frequenza dei caratteri alfabetici, il conteggio totale delle cifre e il conteggio totale
            //di tutti gli altri caratteri.
            //NOTA: ipotizzare che l'utente inserisca solo caratteri alfabetici maiuscoli.
            
            char carattere;
            int[] frequenza = new int[94]; //94 è il numero dei caratteri stampabili più comuni che vanno da ASCII 32 a 126 
            string [] tabellaAscii = new string[] {" " , "!" , "'" , "#" , "$" , "%" , "&" , "'" , "(" , ")" , "*" , "+" , "," , "-" , "." , "/" , "0" , "1" , "2" , "3" , "4" , "5" , "6" , "7" , "8" , "9" , ":" , "," , "" , "=" , ">" , "?" , "@" , "A" , "B" , "C" , "D" , "E" , "F" , "G" , "H" , "I" , "J" , "K" , "L" , "M" , "N" , "O" , "P" , "Q" , "R" , "S" , "T" , "U" , "V" , "W" , "X" , "Y" , "Z" , "[" , "/" , "]" , "^" , "_" , "`" , "a" , "b" , "c" , "d" , "e" , "f" , "g" , "h" , "i" , "j" , "k" , "l" , "m" , "n" , "o" , "p" , "q" , "r" , "s" , "t" , "u" , "v" , "w" , "x" , "y" , "z" , "{" , "|" , "}" , "~"} ;



            Console.WriteLine("Inserisci una frase: ");
            do
            {
                carattere = Convert.ToChar(Console.Read()); 
                if (carattere >= 32 && carattere <= 126) //controllo se il carattere è nell'internavllo gestito dal programma
                {
                    frequenza[carattere - 32] = frequenza[carattere - 32] + 1; //se si aumento la frequenza di 1
                }
            } while (carattere != 13); //ripeto fin quando l'utente non preme invio (cr)

           // Console.WriteLine("Hai premuto invio.");
            Console.WriteLine("\nQuesta è la frequenza dei caratteri: ");

            for(int i=0; i < frequenza.Length; i++) //ciclo for per stampare i caratteri con la loro frequenza
            {
                if(frequenza[i] != 0) //li stampo solo se l'utente li ha inseriti almeno 1 volta
                {
                    Console.WriteLine($"{tabellaAscii[i]} : {frequenza[i]} volte");
                }
            }
            Console.ReadLine(); //per resettare line feed
            Console.ReadLine();

        }
    }
}
