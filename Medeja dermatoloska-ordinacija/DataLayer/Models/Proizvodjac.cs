using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Proizvodjac
    {
        private int sifraProizvodjaca;
        private string naziv;
        private string adresa;
        private string telefon;

        public Proizvodjac(int sifraProizvodjaca, string naziv, string adresa, string telefon)
        {
            this.SifraProizvodjaca = sifraProizvodjaca;
            this.Naziv = naziv;
            this.Adresa = adresa;
            this.Telefon = telefon;
        }

        public int SifraProizvodjaca { get => sifraProizvodjaca; set => sifraProizvodjaca = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public override string ToString()
        {
            return $"Proizvođač: sifra proizvođača({sifraProizvodjaca}), naziv({naziv}), adresa({adresa}), telefon({telefon})";
        }
    }
}
