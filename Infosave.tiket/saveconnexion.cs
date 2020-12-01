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

namespace Infosave.connexion
{
    public class saveconnexion
    {
        public static List<Connexion> Connexions;
        private  FileInfo file;
        private const string FILE_Name = @"data/Connexion.json";

        public List<Connexion> Connexion { get; }

        public saveconnexion()
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
                    Connexion = JsonConvert.DeserializeObject<List<Connexion>>(json);
                }
            }

            if (Connexions == null)
            {
                Connexions = new List<Connexion>();
            }
        }
        
        public void Add(Connexion connexion
            )
        {
            Connexions.Add(connexion);
           Save();
        }

        private void Save()
        {
            using(StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(Connexions);
                sw.WriteLine(json);
            }
        }

        public void Delete (Connexion connexion)
        {
            Connexions.Remove(connexion);
            Save();
        }

        public IEnumerable<Connexion> Find()
        {
            return new List<Connexion>(Connexions);
        }
}
}
