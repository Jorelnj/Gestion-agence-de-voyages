using Infosave.tiket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiket_transport;

namespace Transport.logique
{
    public class tiketlogique
    {
        savetiket tiketrepo;
        public tiketlogique()
        {
            tiketrepo = new savetiket();
        }
    public void creationTiket(Tiket tiket)
        {
            tiketrepo.Add(tiket);
        }

        public void supprimerTiket(Tiket tiket)
        {
            tiketrepo.Delete(tiket);
        }

        public IEnumerable<Tiket> GetAllTiket()
        {
           return tiketrepo.Find();
        }
    }
}
