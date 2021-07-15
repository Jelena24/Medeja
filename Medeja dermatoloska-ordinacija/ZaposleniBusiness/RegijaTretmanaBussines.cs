using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaposleniBusiness
{
    public class RegijaTretmanaBussines
    {

        RegijeTretmanaRepository rr;
        public RegijaTretmanaBussines()
        {
            this.rr = new RegijeTretmanaRepository();
        }

        public List<RegijaTretmana> listaRegijaTretmana()
        {
            return rr.ListaRegijaTretmana();
        }

        public bool InsertRegijaTretmana(RegijaTretmana r)
        {
            int result = rr.InsertRegijeTretmana(r);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdateRegijeTretmana(RegijaTretmana r)
        {
            int result = rr.UpdateRegijeTretmana(r);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool DeleteRegijaTretmana(RegijaTretmana r)
        {
            int result = rr.DeleteRegijaTretmana(r);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}
