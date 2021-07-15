using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class EvidencijeBussines
    {
        EvidencijeRepository er;
        public EvidencijeBussines()
        {
            this.er = new EvidencijeRepository();
        }

        public List<Evidencija> listaEvidencija()
        {
            return er.ListaEvidencija();
        }

        public bool InsertEvidencije(Evidencija e)
        {
            int result = er.InsertEvidencije(e);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdateEvidencije(Evidencija e)
        {
            int result = er.UpdateEvidencije(e);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool DeleteEvidencija(Evidencija e)
        {
            int result = er.DeleteEvidencija(e);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}
