using caissiereclass;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCaissiere
{
    public class SaveCaissiere
    {
        public static List<Ccaissiere> caissieres;
        private FileInfo file;
        private const string FILE_Name = @"data/Tikets.json";


        public SaveCaissiere()
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
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    caissieres = JsonConvert.DeserializeObject<List<Ccaissiere>>(json);
                }
            }

            if (caissieres == null)
            {
                caissieres = new List<Ccaissiere>();
            }
        }

        public void Add(Ccaissiere tiket)
        {
            caissieres.Add(tiket);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(caissieres);
                sw.WriteLine(json);
            }
        }

        public void Delete(Ccaissiere caissiere)
        {
            caissieres.Remove(caissiere);
            Save();
        }

        public IEnumerable<Ccaissiere> Find()
        {
            return new List<Ccaissiere>(caissieres);
        }
    }
}
