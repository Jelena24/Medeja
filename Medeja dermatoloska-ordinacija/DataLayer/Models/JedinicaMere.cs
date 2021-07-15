using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class JedinicaMere
    {
        private int jedinicaMereId;
        private string naziv;
        private string oznaka;

        public JedinicaMere(int jedinicaMereId, string naziv, string oznaka)
        {
            this.JedinicaMereId = jedinicaMereId;
            this.Naziv = naziv;
            this.Oznaka = oznaka;
        }

        public int JedinicaMereId { get => jedinicaMereId; set => jedinicaMereId = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Oznaka { get => oznaka; set => oznaka = value; }

        public override string ToString()
        {
            return $"Jedinica mere: naziv({naziv}), oznaka({oznaka})";
        }
    }

   
}
