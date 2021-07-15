using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Tretman
    {
        private int sifraTretmana;
        private string naziv;
        private string dijagnoza;
        private int cena;
        private int sifraPreparata;
        private int idRegije;

        public Tretman()
        {
        }

        public Tretman(int sifraTretmana, string naziv, string dijagnoza, int cena, int sifraPreparata, int idRegije)
        {
            this.SifraTretmana = sifraTretmana;
            this.Naziv = naziv;
            this.Dijagnoza = dijagnoza;
            this.Cena = cena;
            this.SifraPreparata = sifraPreparata;
            this.IdRegije = idRegije;
        }

        public int SifraTretmana { get => sifraTretmana; set => sifraTretmana = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Dijagnoza { get => dijagnoza; set => dijagnoza = value; }
        public int Cena { get => cena; set => cena = value; }
        public int SifraPreparata { get => sifraPreparata; set => sifraPreparata = value; }
        public int IdRegije { get => idRegije; set => idRegije = value; }

        public override string ToString()
        {
            return $"Tretman: šifra({sifraTretmana}), naziv({naziv}), dijagnoza({dijagnoza}), cena({cena}), šifra preparata({sifraPreparata}), id regije({idRegije})";
        }
    }


}
