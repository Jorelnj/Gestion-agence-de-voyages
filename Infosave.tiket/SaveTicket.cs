using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        public static List<Ticket> Tickets;
        private  FileInfo file;
        private const string FILE_Name = @"data/Tickets.json";
      

        public saveTicket()
        {
            file = new FileInfo(FILE_Name);
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
                    Tickets = JsonConvert.DeserializeObject<List<Ticket>>(json);
                }
            }

            if (Tickets == null)
            {
                Tickets = new List<Ticket>();
            }
        }
        
        public void Add(Ticket ticket)
        {
            Tickets.Add(ticket);
           Save();
        }

        private void Save()
        {
            using(StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(Tickets);
                sw.WriteLine(json);
            }
        }

        public void Delete (Ticket ticket)
        {
            Tickets.Remove(ticket);
            Save();
        }

        public IEnumerable<Ticket> Find()
        {
            return new List<Ticket>(Tickets);
        }
}
}
