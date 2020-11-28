using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using tiket_transport;

namespace Infosave.tiket
{
    public class savetiket
    {
        public static List<Tiket> Tikets;
        private  FileInfo file;
        private const string FILE_Name = @"data/Tikets.json";
      

        public savetiket()
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
                    Tikets = JsonConvert.DeserializeObject<List<Tiket>>(json);
                }
            }

            if (Tikets == null)
            {
                Tikets = new List<Tiket>();
            }
        }
        
        public void Add(Tiket tiket)
        {
            Tikets.Add(tiket);
           Save();
        }

        private void Save()
        {
            using(StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(Tikets);
                sw.WriteLine(json);
            }
        }

        public void Delete (Tiket tiket)
        {
            Tikets.Remove(tiket);
            Save();
        }

        public IEnumerable<Tiket> Find()
        {
            return new List<Tiket>(Tikets);
        }
}
}
