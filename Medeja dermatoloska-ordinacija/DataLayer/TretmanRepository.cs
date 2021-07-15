using DataLayer.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TretmanRepository
    {
        public List<Tretman> ListaTretmana()
        {
            List<Tretman> lista = new List<Tretman>();
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = "Select * from Tretmani";
                OracleCommand com = new OracleCommand(command, con);
                OracleDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Tretman(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3), dr.GetInt32(4), dr.GetInt32(5)));
                }
                return lista;
            }

        }

        public int InsertTretman(Tretman t)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Insert into Tretmani (sifra_tretmana, naziv, dijagnoza, cena,sifra_preparata,id_regije) values('{t.SifraPreparata}',' {t.Naziv}', '{t.Dijagnoza}', '{t.Cena}', '{t.SifraPreparata}', '{t.IdRegije}')";

                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();

            }
            return result;
        }

        public int UpdateTretman(Tretman t)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Update Tretmani set naziv='{t.Naziv}', dijagnoza='{t.Dijagnoza}',cena='{t.Cena}',sifra_preparata='{t.SifraPreparata}', id_regije='{t.IdRegije}' where sifra_tretmana='{t.SifraTretmana}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

        public int UpdateTretmanDenormalizacija(Tretman t)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Update Tretmani set naziv='{t.Naziv}' where sifra_tretmana='{t.SifraTretmana}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

        public int UpdateTretmanOptimizacija(Tretman t)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Update Tretmani set cena='{t.Cena}' where sifra_tretmana='{t.SifraTretmana}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }
        
        public int DeleteTretman(Tretman t)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Delete from Tretmani where sifra_tretmana='{t.SifraTretmana}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

    }
}
