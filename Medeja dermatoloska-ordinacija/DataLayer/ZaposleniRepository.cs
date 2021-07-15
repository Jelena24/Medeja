using DataLayer.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ZaposleniRepository
    {
        public List<Zaposleni> ListaZaposlenih()
        {
            List<Zaposleni>lista = new List<Zaposleni>();
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";
           
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = "Select * from Zaposleni";
                OracleCommand com = new OracleCommand(command, con);
                OracleDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Zaposleni(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6)));
                }
                return lista;
            }

 }

        public int InsertZaposleni(Zaposleni z)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Insert into Zaposleni (broj_licne_karte, ime, prezime, broj_telefona,strucna_sprema,diploma,sertifikat) values('{z.BrojLicneKarte}',' {z.Ime}', '{z.Prezime}', '{z.BrojTelefona}', '{z.StrucnaSprema}', '{z.Diploma}', '{z.Sertifikat}')";
           
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();

            }
            return result;
        }

        public int UpdateZaposleni(Zaposleni z)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Update Zaposleni set ime='{z.Ime}', prezime='{z.Prezime}', broj_telefona='{z.BrojTelefona}',strucna_sprema='{z.StrucnaSprema}',diploma='{z.Diploma}', sertifikat='{z.Sertifikat}' where broj_licne_karte='{z.BrojLicneKarte}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

        public int DeleteZaposleni(string zid)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Delete from Zaposleni where broj_licne_karte='{zid}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

    }
}
