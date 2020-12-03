﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  namespace caissiereclass
{
    [Serializable]
    public class Caissiere
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }

        public Caissiere()
        {
        }

        public Caissiere(string nom, string prenom, string telephone)
        {
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
        }

        
    }
}