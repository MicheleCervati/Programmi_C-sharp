using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuolaElementareConMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] classi = new string[20]; //si possono inserire massimo 20 classi (numero variabile)
            string[] alunni = new string[60]; //e 60 alunni (numero variabile)
            string altreClassi = "n"; //per chiedere all utente se ci sono altre classi da inserire oppure no
            const int alunniPerClasse = 3; //il numero di alunni in una classe
            int i = 0; //contatore (che classe stiamo inserendo)
            do
            {
                do
                {
                    Console.WriteLine("Inserisci il nome della classe"); //input nome classe con controllo
                    classi[i] = Console.ReadLine();
                } while (classi[i] == "");

                for (int j = 0; j < alunniPerClasse; j++) //chiede di inserire i nomi degli alunni e li salva in un array
                {
                    Console.WriteLine($"Inserire il {j+1} alunno della classe {classi[i]}: ");
                    alunni[j + (alunniPerClasse * i)] = Console.ReadLine(); //gli alunni vengono salvati uno dopo l'altro nell array
                }                                                              

                Console.WriteLine("La classe è al completo\n"); //finito l inserimento degli alunni dice che la classe è al completo


                    for (int p = 0; p <= i; p++) //un ciclo che manda a schermo la classe e chi fa parte di quella classe
                    {
                        Console.Write($"La classe {classi[p]} è composta da\n" +
                            $"\t {alunni[alunniPerClasse*p]}\n" +
                            $"\t {alunni[alunniPerClasse*p + 1]}\n" +
                            $"\t {alunni[alunniPerClasse*p + 2]}\n");
                    }

 
                do
                { 
                    Console.WriteLine("\nInserire una nuova classe? (y/n) "); //si chiede all'utente se vuole inserire una nuova classe con controllo
                    altreClassi = Console.ReadLine().ToLower(); 
                    
                } while (altreClassi != "y" && altreClassi != "n");


                i++; //si incrementa il contatore per segnare che si è passati alla classe successiva

                if(i >= classi.Length) //se i supera il valore massimo di classi che si possono inserire si esce dal ciclo autmaticamente
                {
                    altreClassi = "n";
                }


            } while (altreClassi == "y"); //se viene risposto y si ripete il ciclo e quindi fa inserire un altra classe

            Console.WriteLine("Hai terminato l'inserimento (premi invio per continuare)");
            Console.ReadLine();
        }
    }
}
