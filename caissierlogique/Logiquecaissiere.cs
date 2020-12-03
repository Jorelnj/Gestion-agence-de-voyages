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
        public void creationTicket(Caissiere caissiere)
        {
            caissiererepo.Add(caissiere);
        }

        public void SupprimerTicket(Caissiere caissiere)
        {
            caissiererepo.Delete(caissiere);
        }

        public IEnumerable<Caissiere> GetAllTicket()
        {
            return caissiererepo.Find();
        }

    }
  }
