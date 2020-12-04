using caissiereclass;
using InfoCaissiere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caissierlogique
{
    public class LogiqueCaissiere
    {

        SaveCaissiere caissiererepo;
        public LogiqueCaissiere()
        {
            caissiererepo = new SaveCaissiere();
        }
        public void creationTicket(Ccaissiere caissiere)
        {
            caissiererepo.Add(caissiere);
        }

        public void supprimerTicket(Ccaissiere caissiere)
        {
            caissiererepo.Delete(caissiere);
        }

        public IEnumerable<Ccaissiere> GetAllTicket()
        {
            return caissiererepo.Find();
        }

    }
  }
