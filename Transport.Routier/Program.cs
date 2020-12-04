using Infosave.ticket;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Xml.Serialization;
using ticket_transport;
using Transport.logique;

namespace Transport.Routier
{
    class Program
    {
        static void Main(string[] args)
        {
             string Choice ="y";
            do
            {
                Console.Clear();
                Console.WriteLine("....................Creation d'un ticket............");
                Console.Write("Entrer Nom\t:");
                string Nom = Console.ReadLine();
                Console.Write("Entrer Prenom\t:");
                string Prenom = Console.ReadLine();
                Console.Write("Entrer Age\t:");
                string Age = Console.ReadLine();
                Console.Write("Entrer NumeroCNI\t:");
                string NumeroCNI = Console.ReadLine();
                Console.Write("Entrer Depart\t:");
                string ville_de_depart = Console.ReadLine();
                Console.Write("Entrer Arriver\t:");
                string ville_arriver = Console.ReadLine();
                Console.Write("Entrer PrixTicket\t:");
                float PrixTicket = float.Parse(Console.ReadLine());
                Console.Write("Entrer  sexe\t:");
                string sexe = Console.ReadLine();
                Console.Write("Entrer  siege\t:");
                string siege = Console.ReadLine();
                Console.Write("Entrer  Telephone\t:");
                float Telephone = float.Parse(Console.ReadLine());
                string Remboussement = Console.ReadLine();
                Console.Write("Entrer Le_Remboussement\t:");

                Ticket ticket = new Ticket(Nom, Prenom, Age, NumeroCNI, ville_de_depart, ville_arriver, PrixTicket, sexe, siege, Remboussement, Telephone);
                TicketLogique ticketLogique = new TicketLogique(ConfigurationManager.AppSettings["DbFolder"]);
                ticketLogique.creationTicket(ticket);


                IEnumerable<Ticket> tickets = ticketLogique.GetAllTickets();
                foreach (Ticket T in tickets)
                {
                    Console.WriteLine($"{T.Nom}\t\n {T.Prenom}\t\n");
                }

                Console.Write("vouler cree un nouveux ticket? [y/n]:");
               Choice = Console.ReadLine();

            }
            while (Choice.ToLower() != "n");
            Console.WriteLine("merci et a la prochaine");
            Console.ReadKey();

        }
    }
}
