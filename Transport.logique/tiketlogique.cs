﻿using Infosave.ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ticket_transport;

namespace Transport.logique
{
    public class TicketLogique
    {
        saveTicket ticketrepo;
        public TicketLogique(string dbFolder)
        {
            ticketrepo = new saveTicket(dbFolder);
        }
    public void creationTicket(Ticket ticket)
        {
            ticketrepo.Add(ticket);
        }

        public void SupprimerTicket(Ticket ticket)
        {
            ticketrepo.Delete(ticket);
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
           return ticketrepo.Find();
        }

        public void EditTicket(Ticket oldTicket, Ticket newTicket)
        {
            ticketrepo.Set(oldTicket, newTicket);
        }
    }
}
