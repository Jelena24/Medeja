using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class BusinessZaposleni
    {
        ZaposleniRepository zr;
        public BusinessZaposleni()
        {
            this.zr = new ZaposleniRepository();
        }

        public List<Zaposleni> listaZaposlenih()
        {
            return zr.ListaZaposlenih();
        }

        public bool InsertZaposleni(Zaposleni z)
        {
            int result = zr.InsertZaposleni(z);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdateZaposleni(Zaposleni z)
        {
            int result = zr.UpdateZaposleni(z);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool DeleteZaposleni(string zid)
        {
            int result = zr.DeleteZaposleni(zid);
            if (result != 0)
                return true;
            else
                return false;
        }

 
    }
}
