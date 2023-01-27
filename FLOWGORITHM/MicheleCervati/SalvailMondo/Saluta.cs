using System; //libreira di sistema
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalvailMondo
{
    class Saluta //classe principale variabile e metodi 
                 //relativi all'applicazione da realizzare
    {
        static void Main(string[] args) //main = metodo principale
                                        //punto d'ingresso del programma
        {
           Console.BackgroundColor = ConsoleColor.Magenta;
           Console.WriteLine("Salve Mondo!");
           Console.Write("benvenuti");
           Console.Write("Studenti");
            Console.Clear();
           Console.WriteLine("Della 3F");
           Console.Write("Programmiamo in C#"); 
           Console.ReadLine(); 

        }
    }
}

//I metodi sono seguiti da parentesi aperta, mentre le classi sono seguite da punto
//e un metodo, le proprietà invece non sono seguite da niente e vengono dopo una
//propietà. 


//Per andare a capo con writeLine() si fa un CR (carryageReturn) e un LN(lineFeed)
//quindi va prima ad inizio rigra e poi va a capo

//La writeLine fa scrivere una costante stringa su una linea
//e poi va a capo, 
//mentre una write scrive una costante stringa una
//dopo l'altro nella stessa riga

//Le classi vanno sempre scritte con la lettera maiuscola (C# è keySesitive)

