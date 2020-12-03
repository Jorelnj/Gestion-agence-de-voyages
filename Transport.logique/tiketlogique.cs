using Infosave.ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ticket_transport;

namespace Transport.logique
{
    public class ticketlogique
    {
        saveTicket ticketrepo;
        public ticketlogique()
        {
            ticketrepo = new saveTicket();
        }
    public void creationTicket(Ticket ticket)
        {
            ticketrepo.Add(ticket);
        }

        public void SupprimerTicket(Ticket ticket)
        {
            ticketrepo.Delete(ticket);
        }

        public IEnumerable<Ticket> GetAllTicket()
        {
           return ticketrepo.Find();
        }
    }
}
