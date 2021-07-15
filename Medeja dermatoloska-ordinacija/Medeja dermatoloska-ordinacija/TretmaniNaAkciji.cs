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
using ZaposleniBusiness;

namespace Medeja_dermatoloska_ordinacija
{
    public partial class TretmaniNaAkciji : Form
    {
        public TretmaniNaAkciji()
        {
            InitializeComponent();
        }

        private void TretmaniNaAkciji_Load(object sender, EventArgs e)
        {

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "DATA SOURCE=localhost:1521/MEDEJA; USER ID=JELENA; PASSWORD=1234";
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                String command = $"DECLARE NUM_OF_UPDATED NUMBER(3); NAZIV1 TRETMANI.naziv % TYPE; CENA1 TRETMANI.CENA % TYPE; BEGIN SMANJENJE_CENE_TRETMANA({textBox1.Text}, {textBox2.Text}, NAZIV1, CENA1, NUM_OF_UPDATED); END;";
                OracleCommand com = new OracleCommand(command, con);
                int result = com.ExecuteNonQuery();
                if (result != 0)
                    listBox1.Items.Add($"Uspesno smanjena cena tretmana {textBox1.Text} za {textBox2.Text}%");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Tretman> lista = new List<Tretman>();
            TretmanBussines zb = new TretmanBussines();
            lista = zb.listaTretmana();
            foreach (Tretman t in lista)
            {
                listBox1.Items.Add(t.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
