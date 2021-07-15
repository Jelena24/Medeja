using DataLayer.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RegijeTretmanaRepository
    {
        public List<RegijaTretmana> ListaRegijaTretmana()
        {
            List<RegijaTretmana> lista = new List<RegijaTretmana>();
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = "Select * from Regije_Tretmana";
                OracleCommand com = new OracleCommand(command, con);
                OracleDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    int temp = 0;
                    try
                    {
                        temp = dr.GetInt32(5);
                    }
                    catch
                    {
                        temp = 0;
                    }
                    lista.Add(new RegijaTretmana(dr.GetInt32(0), dr.GetString(1), dr.GetInt32(2), dr.GetInt32(3), dr.GetInt32(4),temp));
                }
                return lista;
            }

        }

        public int InsertRegijeTretmana(RegijaTretmana r)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Insert into Regije_Tretmana (id, naziv_regije, bmi, telesna_masa,jedinica_mere_id) values('{r.Id1}',' {r.NazivRegije}', '{r.Bmi}', '{r.TelesnaMasa}', '{r.JedinicaMereId}')";

                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();

            }
            return result;
        }

        public int UpdateRegijeTretmana(RegijaTretmana r)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Update Regije_Tretmana set naziv_regije='{r.NazivRegije}', bmi='{r.Bmi}', telesna_masa='{r.TelesnaMasa}',jedinica_mere_id='{r.JedinicaMereId}' where id='{r.Id1}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

        public int DeleteRegijaTretmana(RegijaTretmana r)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Delete from Regije_Tretmana where id='{r.Id1}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

    }
}
