using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiket_transport
{
    [Serializable]
    public class Connexion
    {
        private object email;
        private object mot_de_passe1;
        public object Email;

        public string Emaill{ get; set; }
            public string mot_de_passe { get; set; }

    

        public Connexion()
        {
        }
        public Connexion(string mot_de_passe)
        {
            this.mot_de_passe = mot_de_passe;
        }

        public Connexion(object email, object mot_de_passe1)
        {
            this.email = email;
            this.mot_de_passe1 = mot_de_passe1;
        }
    }
    
}
