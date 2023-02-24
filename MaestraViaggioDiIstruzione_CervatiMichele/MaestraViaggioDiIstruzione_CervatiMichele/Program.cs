using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaestraViaggioDiIstruzione_CervatiMichele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opzione, nAlunno = 0, posizioneBambino = 0;
            string ricerca;
            const int maxOpzione = 7, nAlunni = 3;
            string[] nomeAlunni = new string[nAlunni];
            string gitaSN = "n";
            bool gitaSNcorretto = true;
            string[] bambiniInGita = new string[nAlunni];
            int nGita=0;
            //visualizzazione menù
            do
            {
                // scelta dell'opzione
                do
                {
                    Console.Clear();
                    Console.WriteLine("===Registro di classe===");
                    Console.WriteLine("[1] inserimento");
                    Console.WriteLine("[2] presenti");
                    Console.WriteLine("[3] ricerca");
                    Console.WriteLine("[4] ricerca posizione alunno/ registro");
                    Console.WriteLine("[5] Visualizza alunno");
                    Console.WriteLine("[6] Elenco bambini in gita");
                    Console.WriteLine("[{0}] esci", maxOpzione);
                    opzione = Convert.ToInt32(Console.ReadLine());
                } while (opzione < 1 || opzione > maxOpzione);
                // verifica dell'opzione ed esecuzione
                switch (opzione)
                {
                    // inserimento nome alunni
                    case 1:
                        // verifico se classe al completo
                        if (nAlunni != nAlunno)
                        {
                            Console.WriteLine("inserire nome alunno");
                            nomeAlunni[nAlunno] = Console.ReadLine(); // inserimento nome
                            do //chiedo se i bambini vengono in gita
                            {
                                if (gitaSNcorretto == true) 
                                {
                                    Console.WriteLine($"L'ulunno {nomeAlunni[nAlunno]} viene in gita? (s/n)  ");

                                    gitaSNcorretto = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Risposta non valida, rispondere con s oppure n:  ");
                                }
                                gitaSN = Console.ReadLine().ToLower();
                            } while (gitaSN != "s" && gitaSN != "n");

                            gitaSNcorretto = true;

                            if (gitaSN == "s") //se viene inserito s allora viene savato il nome del bambino nell'array bambini in gita e viene aumentato il suo indice nGita
                            {

                                bambiniInGita[nGita] = nomeAlunni[nAlunno];
                                nGita++;
                            }

                            nAlunno++;
                        }
                        // se la classe è al completo
                        else
                        {
                            Console.WriteLine("La classe è al completo. Premere invio per continuare");
                            Console.ReadLine();
                        }

                        break;
                    // visualizzazione alunno
                    case 2:
                        // verifico se sono presente degli alunni
                        if (nAlunno != 0)
                        {
                            // stampa dei presenti
                            for (int i = 0; i < nAlunno; i++)
                            {
                                Console.WriteLine("{0} {1}", i + 1, nomeAlunni[i]);
                            }
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Non hai inserito nome degli alunni. Premere invio per continuare");
                            Console.ReadLine();
                        }
                        break;
                    // ricerca
                    case 3:
                        if (nAlunno != 0)
                        {
                            Console.WriteLine("Inserire nome dell'alunno da cercare");
                            ricerca = Console.ReadLine();
                            // ricerca del nome nell'array
                            bool trovato = false;
                            for (int i = 0; i < nAlunno && !trovato; i++)
                            {
                                /*if(ricerca == nomeAlunni[i])
                                {
                                    trovato = true;
                                }
                                */
                                // trovato se la condizione è soddisfatta
                                trovato = ricerca == nomeAlunni[i];
                            }
                            // verifico se c'è il nome in elenco
                            if (trovato)
                            {
                                Console.WriteLine("L'alunno {0} è presente", ricerca);
                            }
                            else
                            {
                                Console.WriteLine("L'alunno {0} è assente", ricerca);
                            }
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Non hai inserito nome degli alunni. Premere invio per continuare");
                            Console.ReadLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Inserire nome dell'alunno da cercare");
                        ricerca = Console.ReadLine();
                        posizioneBambino = 0;
                        for (int i = 0; i < nAlunno; i++)
                        {
                            if (ricerca == nomeAlunni[i])
                            {
                                posizioneBambino = i + 1;
                            }
                        }
                        if (posizioneBambino == 0)
                        {
                            Console.WriteLine("Non è stato trovato nessun bambino");
                        }
                        else
                        {
                            Console.WriteLine($"L'alunno si trova nella posizione {posizioneBambino}");
                        }
                        Console.ReadLine();
                        break;
                    case 5:
                        if (posizioneBambino == 0)
                        {
                            Console.WriteLine("Non ci sono bambini da visualizzare");
                        }
                        else
                        {
                            Console.WriteLine($"Il bambino è {nomeAlunni[posizioneBambino - 1]}");
                        }
                        Console.ReadLine();
                        break;
                        //===============elenco bambini in gita==============
                    case 6:
                        if (nGita != 0)
                        {
                            Console.WriteLine("I bambini che vanno in gita sono i seguenti: ");
                            for (int i = 0; i < nGita; i++)
                            {
                                Console.WriteLine($"{i+1}  {bambiniInGita[i]}");
                            }
                            Console.WriteLine("\npremere invio per continuare...");
                            Console.ReadLine();
                        }
                        else //se l'elendo dei bambini che va in gita è vuoto
                        {
                            Console.WriteLine("Nessun bambino va in gita");
                            Console.WriteLine("\npremere invio per continuare...");
                            Console.ReadLine();
                        }
                        break;
                }
            } while (opzione != maxOpzione);     // ripete ciclo finché non esce
        }
    }
}
