using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class PacijentBussines
    {
        PacijentRepository pr;
        public PacijentBussines()
        {
            this.pr = new PacijentRepository();
        }

        public List<Pacijent> listaPacijenata()
        {
            return pr.ListaPacijenata();
        }

        public bool InsertPacijent(Pacijent p)
        {
            int result = pr.InsertPacijent(p);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdatePacijent(Pacijent p)
        {
            int result = pr.UpdatePacijenti(p);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool DeletePacijent(string pid)
        {
            int result = pr.DeletePacijent(pid);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}
