using Infosave.ticket;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ticket_transport;
using Transport.logique;

namespace Transport.Routier
{
    class Program
    {
      

        static void Main(string[] args)
        {
             string   Choice ="y";
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
                Console.Write("Entrer numero_CNI\t:");
                string numero_CNI = Console.ReadLine();
                Console.Write("Entrer Depart\t:");
                string ville_de_depart = Console.ReadLine();
                Console.Write("Entrer Arriver\t:");
                string ville_arriver = Console.ReadLine();
                Console.Write("Entrer prix_ticket\t:");
                float prix_ticket = float.Parse(Console.ReadLine());
                Console.Write("Entrer  sexe\t:");
                string sexe = Console.ReadLine();
                Console.Write("Entrer  siege\t:");
                string siege = Console.ReadLine();
                Console.Write("Entrer  Telephone\t:");
                float Telephone = float.Parse(Console.ReadLine());
                string Remboussement = Console.ReadLine();
                Console.Write("Entrer Le_Remboussement\t:");





                Ticket ticket = new Ticket(Nom, Prenom, Age, numero_CNI, ville_de_depart, ville_arriver, prix_ticket, sexe, siege, Remboussement, Telephone);
                ticketlogique ticketlogique = new ticketlogique();
                ticketlogique.creationTicket(ticket);


                IEnumerable<Ticket> tickets = ticketlogique.GetAllTicket();
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
