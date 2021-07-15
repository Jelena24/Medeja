using DataLayer.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EvidencijeRepository
    {
        public List<Evidencija> ListaEvidencija()
        {
            List<Evidencija> lista = new List<Evidencija>();
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = "Select * from Evidencije";
                OracleCommand com = new OracleCommand(command, con);
                OracleDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    string naziv;
                    try
                    {
                        naziv = dr.GetString(6);
                    }
                    catch
                    {
                        naziv = "";
                    }
                    lista.Add(new Evidencija(dr.GetDateTime(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetInt32(5),naziv));
                }
                return lista;
            }

        }

        public int InsertEvidencije(Evidencija e)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Insert into Evidencije (datum_izvodjenja_tretmana, vreme_tretmana, napomena, broj_licne_karte_pacijenta,broj_licne_karte_zaposlenog,sifra_tretmana) values('{e.DatumIzvodjenjaTretmana}',' {e.VremeTretmana}', '{e.Napomena}', '{e.BrojLicneKartePacijenta}', '{e.BrojLicneKarteZaposlenig}', '{e.SifraTretmana}')";

                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();

            }
            return result;
        }

        public int UpdateEvidencije(Evidencija e)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Update Evidencije set napomena='{e.Napomena}' where datum_izvodjenja_tretmana='{e.DatumIzvodjenjaTretmana}' and vreme_tretmana='{e.VremeTretmana}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }

        public int DeleteEvidencija(Evidencija e)
        {
            int result;
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string command = $"Delete from Evidencije where datum_izvodjenja_tretmana='{e.DatumIzvodjenjaTretmana}' and vreme_tretmana='{e.VremeTretmana}'";
                OracleCommand com = new OracleCommand(command, con);
                result = com.ExecuteNonQuery();
            }
            return result;
        }
    }
}
