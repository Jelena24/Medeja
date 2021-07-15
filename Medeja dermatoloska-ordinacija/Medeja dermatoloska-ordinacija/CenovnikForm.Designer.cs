namespace Medeja_dermatoloska_ordinacija
{
    partial class CenovnikForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CenovnikForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sifra = new System.Windows.Forms.TextBox();
            this.naziv = new System.Windows.Forms.TextBox();
            this.dijagnoza = new System.Windows.Forms.TextBox();
            this.cena = new System.Windows.Forms.TextBox();
            this.sifraPreparata = new System.Windows.Forms.TextBox();
            this.idRegije = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(328, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(547, 354);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "CENOVNIK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "DODAJ TRETMAN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "CENOVNIK NAKON IZMENA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sifra
            // 
            this.sifra.Location = new System.Drawing.Point(129, 61);
            this.sifra.Name = "sifra";
            this.sifra.Size = new System.Drawing.Size(100, 22);
            this.sifra.TabIndex = 5;
            // 
            // naziv
            // 
            this.naziv.Location = new System.Drawing.Point(129, 98);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(100, 22);
            this.naziv.TabIndex = 6;
            // 
            // dijagnoza
            // 
            this.dijagnoza.Location = new System.Drawing.Point(129, 145);
            this.dijagnoza.Name = "dijagnoza";
            this.dijagnoza.Size = new System.Drawing.Size(100, 22);
            this.dijagnoza.TabIndex = 7;
            // 
            // cena
            // 
            this.cena.Location = new System.Drawing.Point(129, 197);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(100, 22);
            this.cena.TabIndex = 8;
            // 
            // sifraPreparata
            // 
            this.sifraPreparata.Location = new System.Drawing.Point(129, 247);
            this.sifraPreparata.Name = "sifraPreparata";
            this.sifraPreparata.Size = new System.Drawing.Size(100, 22);
            this.sifraPreparata.TabIndex = 9;
            // 
            // idRegije
            // 
            this.idRegije.Location = new System.Drawing.Point(129, 292);
            this.idRegije.Name = "idRegije";
            this.idRegije.Size = new System.Drawing.Size(100, 22);
            this.idRegije.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(728, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "<- POČETNA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Šifra tretmana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Naziv:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dijagnoza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cena:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Šifra preparata:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Id regije:";
            // 
            // CenovnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1082, 582);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idRegije);
            this.Controls.Add(this.sifraPreparata);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.dijagnoza);
            this.Controls.Add(this.naziv);
            this.Controls.Add(this.sifra);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CenovnikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CenovnikForm";
            this.Load += new System.EventHandler(this.CenovnikForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox sifra;
        private System.Windows.Forms.TextBox naziv;
        private System.Windows.Forms.TextBox dijagnoza;
        private System.Windows.Forms.TextBox cena;
        private System.Windows.Forms.TextBox sifraPreparata;
        private System.Windows.Forms.TextBox idRegije;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}