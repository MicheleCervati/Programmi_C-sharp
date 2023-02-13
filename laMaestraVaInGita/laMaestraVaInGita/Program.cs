using System;

namespace laMaestraVaInGita
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //chiede quanti bambini ci sono in classe 
            //per ogni bambino inserire nome e cognome
            int nStudenti;//quanti studenti ci sono
            string[] nomiBambini; //inseriti dall'utente
            string[] registro = { "piero", "franco", "gino" }; //studenti nella clase
            int bambiniSulPulman = 0; //se è salito sul pulman si incrementa
            bool imboscato = true; //se è imboscato


            //do
            //{
            //    Console.WriteLine("Quanti bambini ci sono in classe? ");
            //    nStudenti = Convert.ToInt32(Console.ReadLine());
            //} while (nStudenti <= 0);

            nStudenti = registro.Length;

            nomiBambini = new string[nStudenti];

            for (int i = 0; i < nStudenti; i++)
            {
                do
                {
                    Console.WriteLine($"Inserisci il nome del {i + 1} bambino: ");
                    nomiBambini[i] = Console.ReadLine();

                } while (nomiBambini[i] == "");

                for (int j = 0; j < registro.Length; j++)
                {
                    if (nomiBambini[i] == registro[j])
                    {
                        bambiniSulPulman++;
                        imboscato = false;
                        break;
                    }
                }

                if (imboscato == true)
                {
                    Console.WriteLine($"{nomiBambini[i]} è un imboscato");
                    imboscato = false;
                }

            }

            Console.WriteLine("\n");
            //visualizzazione del registro di classe 
            for (int i = 0; i < nStudenti; i++)
            {
                Console.WriteLine($"Il {i + 1} bambino è {nomiBambini[i]}");

            }

            if (bambiniSulPulman == registro.Length)
            {
                Console.WriteLine("\nsono saliti tutti!");
            }
            else
            {
                Console.WriteLine("\nhai perso dei bambini per strada");
            }
            Console.ReadLine();
        }
    }
}
