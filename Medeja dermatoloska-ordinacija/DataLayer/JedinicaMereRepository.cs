using DataLayer.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class JedinicaMereRepository
    {
        public List<JedinicaMere> ListaJedinicaMere()
        {
            List<JedinicaMere> lista = new List<JedinicaMere>();
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = "Select * from Jedinice_Mere";
                OracleCommand com = new OracleCommand(command, con);
                OracleDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new JedinicaMere(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)));
                }
                return lista;
            }

        }

        public int InsertJedinicaMere(JedinicaMere j)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Insert into Jedinice_Mere (jedinica_mere_id, naziv,oznaka) values('{j.JedinicaMereId}',' {j.Naziv}', '{j.Oznaka}')";

                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();

            }
            return result;
        }

        public int UpdateJediniceMere(JedinicaMere j)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Update Jedinice_Mere set oznaka='{j.Oznaka}' where jedinica_mere_id='{j.JedinicaMereId}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

        public int DeleteJediniceMere(JedinicaMere j)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Delete from Jedinice_Mere where jedinica_mere_id='{j.JedinicaMereId}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

    }
}
