using Infosave.tiket;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using tiket_transport;
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
                Console.WriteLine("....................Creation d'un tiket............");
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
                Console.Write("Entrer prix_tiket\t:");
                float prix_tiket = float.Parse(Console.ReadLine());
                Console.Write("Entrer  numero_place\t:");
                string numero_place = Console.ReadLine();


                Tiket tiket = new Tiket(Nom, Prenom, Age, numero_CNI, ville_de_depart, ville_arriver, prix_tiket, numero_place);
                tiketlogique tiketlogique = new tiketlogique();
                tiketlogique.creationTiket(tiket);


                IEnumerable<Tiket> tikets = tiketlogique.GetAllTiket();
                foreach (Tiket T in tikets)
                {
                    Console.WriteLine($"{T.Nom}\t\n {T.Prenom}\t\n");
                }

                Console.Write("vouler cree un nouveux tiket? [y/n]:");
               Choice = Console.ReadLine();

            }
            while (Choice.ToLower() != "n");
            Console.WriteLine("merci et a la prochaine");
            Console.ReadKey();

        }
    }
}
