namespace Medeja_dermatoloska_ordinacija
{
    partial class ZakazivanjeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZakazivanjeForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DATUM = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vreme = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(760, 292);
            this.listBox1.TabIndex = 0;
            // 
            // DATUM
            // 
            this.DATUM.Location = new System.Drawing.Point(71, 386);
            this.DATUM.Name = "DATUM";
            this.DATUM.Size = new System.Drawing.Size(100, 22);
            this.DATUM.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Proveri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vreme
            // 
            this.vreme.Location = new System.Drawing.Point(276, 386);
            this.vreme.Name = "vreme";
            this.vreme.Size = new System.Drawing.Size(100, 22);
            this.vreme.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(625, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 38);
            this.button3.TabIndex = 12;
            this.button3.Text = "<- POČETNA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Datum:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vreme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Provera zauzetosti termina:";
            // 
            // ZakazivanjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.vreme);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DATUM);
            this.Controls.Add(this.listBox1);
            this.Name = "ZakazivanjeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZakazivanjeForm";
            this.Load += new System.EventHandler(this.ZakazivanjeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox DATUM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox vreme;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}