using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Zaposleni
    {
        private string brojLicneKarte;
        private string ime;
        private string prezime;
        private string brojTelefona;
        private string strucnaSprema;
        private string diploma;
        private string sertifikat;

        public Zaposleni()
        {
        }

        public Zaposleni(string brojLicneKarte, string ime, string prezime, string brojTelefona, string strucnaSprema, string diploma, string sertifikat)
        {
            this.brojLicneKarte = brojLicneKarte;
            this.ime = ime;
            this.prezime = prezime;
            this.brojTelefona = brojTelefona;
            this.strucnaSprema = strucnaSprema;
            this.diploma = diploma;
            this.sertifikat = sertifikat;
        }

        public string BrojLicneKarte { get => brojLicneKarte; set => brojLicneKarte = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        public string StrucnaSprema { get => strucnaSprema; set => strucnaSprema = value; }
        public string Diploma { get => diploma; set => diploma = value; }
        public string Sertifikat { get => sertifikat; set => sertifikat = value; }

        public override string ToString()
        {
            return $"Zaposleni: broj lične karte({brojLicneKarte}), ime({ime}), prezime({prezime}), broj telefona({brojTelefona}), stručna sprema({strucnaSprema}), diploma({diploma}), sertifikat({sertifikat})";
        }

    }
}
