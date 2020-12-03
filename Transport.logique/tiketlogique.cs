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
    public void creationTicket(Ticket tiket)
        {
            tiketrepo.Add(tiket);
        }

        public void supprimerTicket(Ticket tiket)
        {
            tiketrepo.Delete(tiket);
        }

        public IEnumerable<Ticket> GetAllTicket()
        {
           return tiketrepo.Find();
        }
    }
}
