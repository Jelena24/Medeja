using DataLayer.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PreparatRepository
    {
        public List<Preparat> ListaPreparata()
        {
            List<Preparat> lista = new List<Preparat>();
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = "Select * from Preparati";
                OracleCommand com = new OracleCommand(command, con);
                OracleDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Preparat(dr.GetInt32(0), dr.GetString(1), dr.GetInt32(2), dr.GetInt32(3), dr.GetInt32(4), dr.GetString(5)));
                }
                return lista;
            }

        }

        public int InsertPreparat(Preparat p)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Insert into Preparati (sifra_preparata, naziv, kolicina, jedinica_mere_id,sifra_proizvodjaca) values('{p.SifraPreparata}',' {p.Naziv}', '{p.Kolicina}', '{p.JedinicaMereId}', '{p.SifraProizvodjaca}','{p.Oznaka}')";

                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();

            }
            return result;
        }

        public int UpdatePreparati(Preparat p)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Update Preparati set naziv='{p.Naziv}', kolicina='{p.Kolicina}', jedinica_mere_id='{p.JedinicaMereId}',sifra_proizvodjaca='{p.SifraProizvodjaca}', oznaka='{p.Oznaka}' where sifra_preparata='{p.SifraPreparata}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

        public int DeletePreparat(Preparat p)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Delete from Preparati where sifra_preparata='{p.SifraPreparata}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

    }
}
