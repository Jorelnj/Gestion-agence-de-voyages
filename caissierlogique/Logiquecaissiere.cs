using caissiereclass;
using InfoCaissiere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caissierlogique
{
    public class Logiquecaissiere
    {

        SaveCaissiere caissiererepo;
        public Logiquecaissiere()
        {
            caissiererepo = new SaveCaissiere();
        }
        public void creationTiket(Ccaissiere caissiere)
        {
            caissiererepo.Add(caissiere);
        }

        public void supprimerTiket(Ccaissiere caissiere)
        {
            caissiererepo.Delete(caissiere);
        }

        public IEnumerable<Ccaissiere> GetAllTiket()
        {
            return caissiererepo.Find();
        }

    }
  }
