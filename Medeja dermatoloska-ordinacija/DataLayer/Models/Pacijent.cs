using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Pacijent
    {

        private string brojLicneKarte;
        private string ime;
        private string prezime;
        private string brojTelefona;
        private string alergije;

        public Pacijent()
        {
        }

        public Pacijent(string brojLicneKarte, string ime, string prezime, string brojTelefona, string alergije)
        {
            this.BrojLicneKarte = brojLicneKarte;
            this.Ime = ime;
            this.Prezime = prezime;
            this.BrojTelefona = brojTelefona;
            this.Alergije = alergije;
        }

        public string BrojLicneKarte { get => brojLicneKarte; set => brojLicneKarte = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        public string Alergije { get => alergije; set => alergije = value; }

        public override string ToString()
        {
            return $"Pacijent: broj lične karte({BrojLicneKarte}), ime({Ime}), prezime({Prezime}), broj telefona({ BrojTelefona}), alergije({alergije})";
        }
    }
}
