using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class PreparatBussines
    {
        PreparatRepository pr;
        public PreparatBussines()
        {
            this.pr = new PreparatRepository();
        }

        public List<Preparat> listaPreparata()
        {
            return pr.ListaPreparata();
        }

        public bool InsertPreparat(Preparat p)
        {
            int result = pr.InsertPreparat(p);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdatePreparat(Preparat p)
        {
            int result = pr.UpdatePreparati(p);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool DeletePreparat(Preparat p)
        {
            int result = pr.DeletePreparat(p);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}
