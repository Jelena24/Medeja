using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Preparat
    {
        private int sifraPreparata;
        private string naziv;
        private int kolicina;
        private int jedinicaMereId;
        private int sifraProizvodjaca;
        private string oznaka;

        public Preparat(int sifraPreparata, string naziv, int kolicina, int jedinicaMereId, int sifraProizvodjaca, string oznaka)
        {
            this.SifraPreparata = sifraPreparata;
            this.Naziv = naziv;
            this.Kolicina = kolicina;
            this.JedinicaMereId = jedinicaMereId;
            this.SifraProizvodjaca = sifraProizvodjaca;
            this.Oznaka = oznaka;
        }

        public int SifraPreparata { get => sifraPreparata; set => sifraPreparata = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public int JedinicaMereId { get => jedinicaMereId; set => jedinicaMereId = value; }
        public int SifraProizvodjaca { get => sifraProizvodjaca; set => sifraProizvodjaca = value; }
        public string Oznaka { get => oznaka; set => oznaka = value; }

        public override string ToString()
        {
            return $"Preparat: sifra preparata({SifraPreparata}), naziv({Naziv}), količina({Kolicina}), jedinica mere id({JedinicaMereId}), oznaka({Oznaka}), sifra proizvođača({SifraProizvodjaca})";
        }
    }

}
