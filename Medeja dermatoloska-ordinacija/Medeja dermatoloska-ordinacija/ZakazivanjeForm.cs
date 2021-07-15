using BussinesLayer;
using DataLayer.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medeja_dermatoloska_ordinacija
{
    public partial class ZakazivanjeForm : Form
    {
        public ZakazivanjeForm()
        {
            InitializeComponent();
        }

        private void ZakazivanjeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {




            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                String command = $"SELECT SIFRA_TRETMANA, DATUM_IZVODJENJA_TRETMANA, SLOBODNIT('{vreme.Text}', '{DATUM.Text}') FROM EVIDENCIJE WHERE DATUM_IZVODJENJA_TRETMANA = '{DATUM.Text}'";
                OracleCommand com = new OracleCommand(command, con);
                OracleDataReader dr = com.ExecuteReader();

                
                while(dr.Read())
                {
                    listBox1.Items.Add(dr.GetString(2));
               }
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Evidencija> lista = new List<Evidencija>();
            EvidencijeBussines zb = new EvidencijeBussines();
            lista = zb.listaEvidencija();
            foreach (Evidencija t in lista)
            {
                listBox1.Items.Add(t.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
