using DataLayer.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PacijentRepository
    {
        public List<Pacijent> ListaPacijenata()
        {
            List<Pacijent> lista = new List<Pacijent>();
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = "Select * from Pacijenti";
                OracleCommand com = new OracleCommand(command, con);
                OracleDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    string alg;
                    try {alg = dr.GetString(4);}
                    catch
                    {
                        alg = "nema";
                    }
                    lista.Add(new Pacijent(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), alg));
                }
                return lista;
            }

        }

        public int InsertPacijent(Pacijent p)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Insert into Pacijenti (broj_licne_karte, ime, prezime, broj_telefona,alergije) values('{p.BrojLicneKarte}',' {p.Ime}', '{p.Prezime}', '{p.BrojTelefona}', '{p.Alergije}')";

                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();

            }
            return result;
        }

        public int UpdatePacijenti(Pacijent p)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Update Pacijenti set ime='{p.Ime}', prezime='{p.Prezime}', broj_telefona='{p.BrojTelefona}',alergije='{p.Alergije}' where broj_licne_karte='{p.BrojLicneKarte}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

        public int DeletePacijent(string pid)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Delete from Pacijenti where broj_licne_karte='{pid}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

    }
}
