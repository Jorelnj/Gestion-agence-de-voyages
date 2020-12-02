using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiket_transport
{
    [Serializable]
    public class Tiket
    {

            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string Age { get; set; }
            public string numero_CNI { get; set; }
            public string ville_de_Depart { get; set; }
            public string ville_Arriver { get; set; }
            public float prix_tiket { get; set; }
            public string Sexe { get; set; }
            public string Telephone { get; set; }
            public string Siege { get; set; }
            public float Remboussement { get; set; }
           
            

            public Tiket()//pour la serialisation
            {

            }

        public Tiket(string nom, string prenom, string age, string numero_CNI,
            string ville_de_Depart, string ville_Arriver, float prix_tiket, string sexe, string telephone, string siege, float remboussement)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            this.numero_CNI = numero_CNI;
            this.ville_de_Depart = ville_de_Depart;
            this.ville_Arriver = ville_Arriver;
            this.prix_tiket = prix_tiket;
            Sexe = sexe;
            Telephone = telephone;
            Siege = siege;
            Remboussement = remboussement;
        }

        public override bool Equals(object obj)
            {
                return obj is Tiket tiket &&
                       numero_CNI == tiket.numero_CNI;
            }

            public override int GetHashCode()
            {
                return 1442208734 + EqualityComparer<string>.Default.GetHashCode(numero_CNI);
            }


        }
    
}
