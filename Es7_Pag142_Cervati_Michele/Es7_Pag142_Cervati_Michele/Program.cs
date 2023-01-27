using System;

namespace Es7_Pag142_Cervati_Michele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string veicolo; //tipologia di veicolo
            int cilindrata; 

            int classeCilindrata1 = 1000; //tabella di tutte le cilindrate con relativi costi
            int classeCilindrata2 = 2000;
            int classeCilindrata3= 2000;
            int classeCilindrata4 = 3000;

            int costoCilindrata1 = 20;
            int costoCilindrata2 = 30;
            int costoCilindrata3 = costoCilindrata2 + (costoCilindrata2*10/100);
            int costoCilindrata4 = 40;
            int costoCilindrata5 = 50;
            int costoCilindrata6 = costoCilindrata5 + (costoCilindrata5 * 100 / 100);

            Console.Write("Inserisci il tipo di veicolo (A per autovetture, C per camion): "); //input tipo veicolo
            veicolo = Console.ReadLine();


            if (veicolo == "A") //If per decidere a che categoria appartiene 
            {
                Console.Write("Inserisci cilindrata del veicolo: "); //inserimiento cilindrata del veicolo
                cilindrata = Convert.ToInt32(Console.ReadLine());
                if (cilindrata <= classeCilindrata1) //if per stabilire quanto deve pagare in relazione alla propria cilindrata
                {
                    Console.WriteLine("L'importo da pagare è euro {0}", costoCilindrata1);
                }else if(cilindrata <= classeCilindrata2)
                {
                    Console.WriteLine("L'importo da pagare è euro {0}", costoCilindrata2);
                }
                else
                {
                    Console.WriteLine("L'importo da pagare è euro {0}", costoCilindrata3);
                }
            }
            else if (veicolo == "C") 
            {
                Console.Write("Inserisci cilindrata del veicolo: "); //inserimiento cilindrata del veicolo
                cilindrata = Convert.ToInt32(Console.ReadLine());
                if (cilindrata <= classeCilindrata3) //if per stabilire quanto deve pagare in relazione alla propria cilindrata
                {
                    Console.WriteLine("L'importo da pagare è euro {0}", costoCilindrata4);
                }else if(cilindrata <= classeCilindrata4)
                {
                    Console.WriteLine("L'importo da pagare è euro {0}", costoCilindrata5);
                }
                else
                {
                    Console.WriteLine("L'importo da pagare è euro {0}", costoCilindrata6);
                }
            }
            else // se il veicolo non appartiene ne ai camion ne alle autovetture viene mandato un errore e il programma termina
            {
                Console.WriteLine("Il veicolo inserito non è presente nella tabella-prezzi");
            }

            Console.ReadLine(); //per far rimanere gli output anche dopo l'esecuzione del programma
        }
    }
}
