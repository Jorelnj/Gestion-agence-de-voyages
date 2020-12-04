using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ticket_transport;

namespace Infosave.ticket
{
    public class saveTicket
    {
        private static List<Ticket> tickets;
        private const string FILE_Name = @"tickets.json";
        private readonly string dbFolder;
        private FileInfo file;

        public saveTicket(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_Name));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }

            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }

            if (file.Length > 0)
            {
            using(StreamReader sr = new StreamReader(file.FullName))   
                {
                    string json = sr.ReadToEnd();
                    tickets = JsonConvert.DeserializeObject<List<Ticket>>(json);
                }
            }

            if (tickets == null)
            {
                tickets = new List<Ticket>();
            }
        }

        public void Set(Ticket oldTicket, Ticket newTicket)
        {
            var oldIndex = tickets.IndexOf(oldTicket);
            var newIndex = tickets.IndexOf(newTicket);
            if (oldIndex < 0)
                throw new KeyNotFoundException("Le produit n'existe pas !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("La référence de ce produit existe déjà");
            tickets[oldIndex] = newTicket;
            Save();
        }

        public void Add(Ticket ticket)
        {
            var index = tickets.IndexOf(ticket);
            if (index >= 0)
                throw new DuplicateNameException("Ce ticket existe déjà !");
            tickets.Add(ticket);
            Save();
        }

        private void Save()
        {
            using(StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(tickets);
                sw.WriteLine(json);
            }
        }

        public void Delete (Ticket ticket)
        {
            tickets.Remove(ticket);
            Save();
        }

        public IEnumerable<Ticket> Find()
        {
            return new List<Ticket>(tickets);
        }

        public IEnumerable<Ticket> Find(Func<Ticket, bool> predicate)
        {
            return new List<Ticket>(tickets.Where(predicate).ToArray());
        }
    }
}
