using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaposleniBusiness
{
    public class TretmanBussines
    {

        TretmanRepository tr;
        public TretmanBussines()
        {
            this.tr = new TretmanRepository();
        }

        public List<Tretman> listaTretmana()
        {
            return tr.ListaTretmana();
        }

        public bool InsertTretmana(Tretman t)
        {
            int result = tr.InsertTretman(t);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdateTretman(Tretman t)
        {
            int result = tr.UpdateTretman(t);
            if (result != 0)
                return true;
            else
                return false;
        }

        public bool UpdateTretmanDenormalizacija(Tretman t)
        {
            int result = tr.UpdateTretmanDenormalizacija(t);
            if (result != 0)
                return true;
            else
                return false;
        }

        public bool UpdateTretmanOptimizacija(Tretman t)
        {
            int result = tr.UpdateTretmanOptimizacija(t);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool DeleteTretman(Tretman t)
        {
            int result = tr.DeleteTretman (t);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}
