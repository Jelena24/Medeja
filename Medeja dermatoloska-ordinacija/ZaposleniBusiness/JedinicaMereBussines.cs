using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class JedinicaMereBussines
    {
        JedinicaMereRepository jr;
        public JedinicaMereBussines()
        {
            this.jr = new JedinicaMereRepository();
        }

        public List<JedinicaMere> listaJedinicaMere()
        {
            return jr.ListaJedinicaMere();
        }

        public bool InsertJedinicaMere(JedinicaMere j)
        {
            int result = jr.InsertJedinicaMere(j);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdateJedinicaMere(JedinicaMere j)
        {
            int result = jr.UpdateJediniceMere(j);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool DeleteJedinicaMere(JedinicaMere j)
        {
            int result = jr.DeleteJediniceMere(j);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}
