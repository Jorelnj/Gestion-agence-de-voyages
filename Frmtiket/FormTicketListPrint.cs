using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frmtiket
{
    public class FormTicketListPrint
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

        public FormTicketListPrint(string nom, string prenom, string age, string numeroCNI, 
            string villeDepart, string villeArrivee, float prixTicket, string sexe, 
            string telephone, string siege, string observation, float remboussement)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            NumeroCNI = numeroCNI;
            VilleDepart = villeDepart;
            VilleArrivee = villeArrivee;
            PrixTicket = prixTicket;
            Sexe = sexe;
            Telephone = telephone;
            Siege = siege;
            Observation = observation;
            Remboussement = remboussement;
        }
    }
}
