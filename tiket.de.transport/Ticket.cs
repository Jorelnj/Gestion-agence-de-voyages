using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticket_transport
{
    [Serializable]
    public class Ticket
    {

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Age { get; set; }
        public string NumeroCNI { get; set; }
        public string VilleDepart { get; set; }
        public string VilleArrivee { get; set; }
        public float PrixTicket { get; set; }
        public string Sexe { get; set; }
        public string Telephone { get; set; }
        public string Siege { get; set; }
        public string Observation { get; set; }
        public float Remboussement { get; set; }
           
        public Ticket()//pour la serialisation
        {

        }

        public Ticket(string nom, string prenom, string age, string NumeroCNI, string VilleDepart, string VilleArrivee,
             float PrixTicket, string sexe, string telephone, string siege, float remboussement)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            this.NumeroCNI = NumeroCNI;
            this.VilleDepart = VilleDepart;
            this.VilleArrivee = VilleArrivee;
            this.PrixTicket = PrixTicket;
            Sexe = sexe;
            Telephone = telephone;
            Siege = siege;
            Remboussement = remboussement;
        }

        public override bool Equals(object obj)
            {
                return obj is Ticket ticket &&
                       NumeroCNI == ticket.NumeroCNI;
            }

            public override int GetHashCode()
            {
                return 1442208734 + EqualityComparer<string>.Default.GetHashCode(NumeroCNI);
            }


        }
    
}
