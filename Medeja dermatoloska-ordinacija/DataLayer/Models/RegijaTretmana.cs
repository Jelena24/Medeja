using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class RegijaTretmana
    {
        private int Id;
        private string nazivRegije;
        private int bmi;
        private int telesnaMasa;
        private int jedinicaMereId;
        private int maxCena;

        public RegijaTretmana(int id, string nazivRegije, int bmi, int telesnaMasa, int jedinicaMereId, int maxCena)
        {
            Id1 = id;
            this.NazivRegije = nazivRegije;
            this.Bmi = bmi;
            this.TelesnaMasa = telesnaMasa;
            this.JedinicaMereId = jedinicaMereId;
            this.MaxCena = maxCena;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string NazivRegije { get => nazivRegije; set => nazivRegije = value; }
        public int Bmi { get => bmi; set => bmi = value; }
        public int TelesnaMasa { get => telesnaMasa; set => telesnaMasa = value; }
        public int JedinicaMereId { get => jedinicaMereId; set => jedinicaMereId = value; }
        public int MaxCena { get => maxCena; set => maxCena = value; }

        public override string ToString()
        {
            return $"Regija tretmana: id({Id1}), naziv regije({NazivRegije}), BMI({Bmi}) telesna masa({TelesnaMasa}), jedinica mere id({JedinicaMereId}), MAX CENA({MaxCena})";
        }
    }
}
