using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class ProizvodjacBussines
    {
      
            ProizvodjacRepository pr;
            public ProizvodjacBussines()
            {
                this.pr = new ProizvodjacRepository();
            }

            public List<Proizvodjac> listaProizvodjaca()
            {
                return pr.ListaProizvodjaca();
            }

            public bool InsertProizvodjac(Proizvodjac p)
            {
                int result = pr.InsertProizvodjac(p);
                if (result != 0)
                    return true;
                else
                    return false;
            }
            public bool UpdatePreparat(Proizvodjac p)
            {
                int result = pr.UpdateProizvodjac(p);
                if (result != 0)
                    return true;
                else
                    return false;
            }
            public bool DeletePreparat(Proizvodjac p)
            {
                int result = pr.DeleteProizvodjac(p);
                if (result != 0)
                    return true;
                else
                    return false;
            }
        }
}
