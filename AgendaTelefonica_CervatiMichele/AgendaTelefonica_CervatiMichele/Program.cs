using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica_CervatiMichele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxContatti = 4; //costante che indica il massimo numero di contatti salvabili nell'agenda
            int scelta = 0; //l'opzione scelta dall'utente (inserimento, visualizza etc...)
            int i = 0; //posizione nell elenco (inserimento)
            string[] cognomi = new string[maxContatti]; //creazione array con dimensione massima il numero massimo di contatti
            string[] nomi = new string[maxContatti];
            string[] numTelefono = new string[maxContatti];
            bool esci = false; // per determinare quando finire il programma
            int sceltaModifica; //la scelta del contatto che si desidera modificare
            bool presenteInLista = true; //se il contatto selezionato è presente o meno nella lista dei contatti

            do
            {
                //==========menù============
                Console.Clear();
                Console.WriteLine("Scegliere una delle seguenti opzioni: ");
                Console.WriteLine("[1] - Inserimento {inserire cognome nome, numero telefono}");
                Console.WriteLine("[2] - Visualizza contatti telefonici");
                Console.WriteLine("[3] - Modifica contatto");
                Console.WriteLine($"[{maxContatti}] - Fine\n");

                Console.Write("La tua scelta: ");
                scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1: //inserimento
                        if (i < maxContatti) //se non si ha raggiunto il massimo di contatti telefonici ne fa inserire altri altriementi dice che l'agenda è piena
                        {
                            //========INSERIMENTO CONTATTI TELEFONICI===========
                            do
                            {
                                Console.WriteLine("\nnome: ");
                                nomi[i] = Console.ReadLine();
                            } while (nomi[i] == "");

                            do
                            {
                                Console.WriteLine("\ncognome: ");
                                cognomi[i] = Console.ReadLine();
                            } while (cognomi[i] == "");

                            do
                            {
                                Console.WriteLine("\nnum Telefono: ");
                                numTelefono[i] = Console.ReadLine();
                            } while (numTelefono[i] == "");

                            i++;//incremento il contatore i così da inserire i contatti nella posizione successiva degli array
                        }
                        else
                        {
                            Console.WriteLine("\nHai già inserito il numero massimo di contatti telefonici");
                            Console.WriteLine("\nPremi invio per continuare...");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        //===========VISUALIZZA CONTATTI TELEFONICI=================
                        if (nomi[0] != null) //i contatti si possono visualizzare solo se almeno la prima cella dell array nomi è stata riempita altrimenti scrive che non sono ancora stati inseriti contatti telefonici
                        {
                            Console.WriteLine("\nI contatti telefonici inseriti sono: ");
                            for (int j = 0; j < i; j++)
                            {
                                Console.WriteLine($"{cognomi[j]} {nomi[j]} : +{numTelefono[j]} ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNon sono stati ancora inseriti numeri di telefono");
                        }

                        Console.WriteLine("\nPremi invio per continuare...");
                        Console.ReadLine();
                        break;
                    case 3:
                        //========Modifica Contatto========

                        if (nomi[0] != null) //i contatti si possono modificare solo se è stato inserito almeno un contatto
                        {
                            Console.WriteLine("\nI contatti telefonici inseriti sono: "); //mando a schermo tutti i contatti con accanto un indice
                            for (int j = 0; j < i; j++)
                            {
                                Console.WriteLine($"{j + 1}. {cognomi[j]} {nomi[j]} : +{numTelefono[j]} ");
                            }
                            //======input scelta del contatto da modificare=======
                            do
                            {
                                if (presenteInLista == true)
                                {
                                    Console.WriteLine("\nChe contatto desideri modificare? (rispondere con 1,2 etc..) ");
                                    presenteInLista = false;
                                }
                                else
                                {
                                    Console.WriteLine("Il contatto selezionato non è presente nell'agenda. Reinserire il contatto: ");
                                }
                                sceltaModifica = Convert.ToInt32(Console.ReadLine());
                            } while (sceltaModifica > i || sceltaModifica < 1);
                            presenteInLista = true;

                            //====input dati del contatto da modificare=====

                            do
                            {
                                Console.WriteLine("\nnome: ");
                                nomi[sceltaModifica - 1] = Console.ReadLine();
                            } while (nomi[sceltaModifica - 1] == "");

                            do
                            {
                                Console.WriteLine("\ncognome: ");
                                cognomi[sceltaModifica - 1] = Console.ReadLine();
                            } while (cognomi[sceltaModifica - 1] == "");

                            do
                            {
                                Console.WriteLine("\nnum Telefono: ");
                                numTelefono[sceltaModifica - 1] = Console.ReadLine();
                            } while (numTelefono[sceltaModifica - 1] == "");

                            Console.WriteLine("\nIl tuo contatto è stato modificato correttamente");
                            Console.WriteLine("\nPremi invio per continuare...");
                            Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine("\nNon sono stati ancora inseriti numeri di telefono");
                            Console.WriteLine("\nPremi invio per continuare...");
                            Console.ReadLine();
                        }

                        break;
                    case 4:
                        //=======FINE PROGRAMMA==========
                        esci = true;
                        break;
                    default: //se si inserisce un'opzione che non è stata gestita dai casi precendenti allora scrive che si è inserita un'opzione non valida e fa reinserire l'opzione dall'utente
                        Console.WriteLine("\nHai scelto un opzione non valida");
                        Console.WriteLine("\nPremi invio per continuare...");
                        Console.ReadLine();
                        break;
                }

            } while (esci == false);

        }
    }
}
