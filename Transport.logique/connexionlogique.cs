using Infosave.connexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiket_transport;

namespace Transport.logique
{
    public class connexionlogique
    {
        saveconnexion connexionrepo;
        public connexionlogique()
        {
            connexionrepo = new saveconnexion();
        }
    public void creationConnexion(Connexion connexion
        )
        {
            connexionrepo.Add(connexion);
        }

        public void supprimerConnexion(Connexion connexion)
        {
            connexionrepo.Delete(connexion);
        }

        public IEnumerable<Connexion> GetAllConnexion()
        {
           return connexionrepo.Find();
        }
    }
}
