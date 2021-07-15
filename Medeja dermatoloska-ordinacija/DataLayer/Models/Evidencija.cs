using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Evidencija
    {
        private DateTime datumIzvodjenjaTretmana;
        private string vremeTretmana;
        private string napomena;
        private string brojLicneKartePacijenta;
        private string brojLicneKarteZaposlenig;
        private int sifraTretmana;
        private string naziv;

        public Evidencija(DateTime datumIzvodjenjaTretmana, string vremeTretmana, string napomena, string brojLicneKartePacijenta, string brojLicneKarteZaposlenig, int sifraTretmana, string naziv)
        {
            this.DatumIzvodjenjaTretmana = datumIzvodjenjaTretmana;
            this.VremeTretmana = vremeTretmana;
            this.Napomena = napomena;
            this.BrojLicneKartePacijenta = brojLicneKartePacijenta;
            this.BrojLicneKarteZaposlenig = brojLicneKarteZaposlenig;
            this.SifraTretmana = sifraTretmana;
            this.Naziv = naziv;
        }

        public DateTime DatumIzvodjenjaTretmana { get => datumIzvodjenjaTretmana; set => datumIzvodjenjaTretmana = value; }
        public string VremeTretmana { get => vremeTretmana; set => vremeTretmana = value; }
        public string Napomena { get => napomena; set => napomena = value; }
        public string BrojLicneKartePacijenta { get => brojLicneKartePacijenta; set => brojLicneKartePacijenta = value; }
        public string BrojLicneKarteZaposlenig { get => brojLicneKarteZaposlenig; set => brojLicneKarteZaposlenig = value; }
        public int SifraTretmana { get => sifraTretmana; set => sifraTretmana = value; }
        public string Naziv { get => naziv; set => naziv = value; }

        public override string ToString()
        {
            return $"Evidencija: datum izvođenja tretmana({DatumIzvodjenjaTretmana}), vreme({VremeTretmana}), napomena({Napomena}), broj lične karte zaposlenog({BrojLicneKarteZaposlenig}), broj lične karte({BrojLicneKartePacijenta}), naziv tretmana ({Naziv})";
        }
    }
}
