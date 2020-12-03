﻿using caissiereclass;
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
        public static List<Caissiere> caissieres;
        private FileInfo file;
        private const string FILE_Name = @"data/Tickets.json";


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
                    caissieres = JsonConvert.DeserializeObject<List<Caissiere>>(json);
                }
            }

            if (caissieres == null)
            {
                caissieres = new List<Caissiere>();
            }
        }

        public void Add(Caissiere ticket)
        {
            caissieres.Add(ticket);
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

        public void Delete(Caissiere caissiere)
        {
            caissieres.Remove(caissiere);
            Save();
        }

        public IEnumerable<Caissiere> Find()
        {
            return new List<Caissiere>(caissieres);
        }
    }
}
