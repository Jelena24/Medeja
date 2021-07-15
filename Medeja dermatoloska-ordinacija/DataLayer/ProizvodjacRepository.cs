using DataLayer.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProizvodjacRepository
    {
        public List<Proizvodjac> ListaProizvodjaca()
        {
            List<Proizvodjac> lista = new List<Proizvodjac>();
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = "Select * from Zaposleni";
                OracleCommand com = new OracleCommand(command, con);
                OracleDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Proizvodjac(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3)));
                }
                return lista;
            }

        }

        public int InsertProizvodjac(Proizvodjac p)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Insert into Proizvodjaci (sifra_proizvodjaca, naziv, adresa, telefon) values('{p.SifraProizvodjaca}',' {p.Naziv}', '{p.Adresa}', '{p.Telefon}')";

                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();

            }
            return result;
        }

        public int UpdateProizvodjac(Proizvodjac p)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Update Proizvodjaci set naziv='{p.Naziv}', adresa='{p.Adresa}',telefon='{p.Telefon}' where sifra_proizvodjaca='{p.SifraProizvodjaca}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

        public int DeleteProizvodjac(Proizvodjac p)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Delete from Proizvodjaci where sifra_proizvodjaca='{p.SifraProizvodjaca}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

    }
}
