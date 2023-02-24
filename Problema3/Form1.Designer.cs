namespace Problema3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtNrTel = new System.Windows.Forms.TextBox();
            this.txtNrSerie = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.textNumeLoc = new System.Windows.Forms.TextBox();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.MistyRose;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(485, 324);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Departament loc de munca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Numar de telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Varsta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nume loc de munca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nr serie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Serie CI";
            // 
            // txtNume
            // 
            this.txtNume.BackColor = System.Drawing.Color.Pink;
            this.txtNume.Location = new System.Drawing.Point(135, 56);
            this.txtNume.Multiline = true;
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(343, 23);
            this.txtNume.TabIndex = 11;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // txtNrTel
            // 
            this.txtNrTel.BackColor = System.Drawing.Color.Pink;
            this.txtNrTel.Location = new System.Drawing.Point(182, 257);
            this.txtNrTel.Multiline = true;
            this.txtNrTel.Name = "txtNrTel";
            this.txtNrTel.Size = new System.Drawing.Size(296, 23);
            this.txtNrTel.TabIndex = 12;
            this.txtNrTel.TextChanged += new System.EventHandler(this.txtNrTel_TextChanged);
            // 
            // txtNrSerie
            // 
            this.txtNrSerie.BackColor = System.Drawing.Color.Pink;
            this.txtNrSerie.Location = new System.Drawing.Point(316, 299);
            this.txtNrSerie.Multiline = true;
            this.txtNrSerie.Name = "txtNrSerie";
            this.txtNrSerie.Size = new System.Drawing.Size(162, 23);
            this.txtNrSerie.TabIndex = 13;
            this.txtNrSerie.TextChanged += new System.EventHandler(this.txtNrSerie_TextChanged);
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.Pink;
            this.txtSerie.Location = new System.Drawing.Point(114, 299);
            this.txtSerie.Multiline = true;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(114, 23);
            this.txtSerie.TabIndex = 14;
            this.txtSerie.TextChanged += new System.EventHandler(this.txtSerie_TextChanged);
            // 
            // txtAdresa
            // 
            this.txtAdresa.BackColor = System.Drawing.Color.Pink;
            this.txtAdresa.Location = new System.Drawing.Point(135, 222);
            this.txtAdresa.Multiline = true;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(343, 23);
            this.txtAdresa.TabIndex = 15;
            // 
            // txtDep
            // 
            this.txtDep.BackColor = System.Drawing.Color.Pink;
            this.txtDep.Location = new System.Drawing.Point(239, 189);
            this.txtDep.Multiline = true;
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(239, 23);
            this.txtDep.TabIndex = 16;
            // 
            // textNumeLoc
            // 
            this.textNumeLoc.BackColor = System.Drawing.Color.Pink;
            this.textNumeLoc.Location = new System.Drawing.Point(203, 155);
            this.textNumeLoc.Multiline = true;
            this.textNumeLoc.Name = "textNumeLoc";
            this.textNumeLoc.Size = new System.Drawing.Size(275, 23);
            this.textNumeLoc.TabIndex = 17;
            this.textNumeLoc.TextChanged += new System.EventHandler(this.textNumeLoc_TextChanged);
            // 
            // txtVarsta
            // 
            this.txtVarsta.BackColor = System.Drawing.Color.Pink;
            this.txtVarsta.Location = new System.Drawing.Point(135, 125);
            this.txtVarsta.Multiline = true;
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(343, 23);
            this.txtVarsta.TabIndex = 18;
            this.txtVarsta.TextChanged += new System.EventHandler(this.txtVarsta_TextChanged);
            // 
            // txtPrenume
            // 
            this.txtPrenume.BackColor = System.Drawing.Color.Pink;
            this.txtPrenume.Location = new System.Drawing.Point(135, 89);
            this.txtPrenume.Multiline = true;
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(343, 23);
            this.txtPrenume.TabIndex = 19;
            this.txtPrenume.TextChanged += new System.EventHandler(this.txtPrenume_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Problema3.Properties.Resources.WhatsApp_Image_2022_06_02_at_16_53_26;
            this.pictureBox1.Location = new System.Drawing.Point(12, 360);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Location = new System.Drawing.Point(362, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 57);
            this.button1.TabIndex = 21;
            this.button1.Text = "Trimite";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.MistyRose;
            this.listBox2.ColumnWidth = 300;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(579, 46);
            this.listBox2.MultiColumn = true;
            this.listBox2.Name = "listBox2";
            this.listBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox2.Size = new System.Drawing.Size(359, 224);
            this.listBox2.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(579, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Ati Completat cu urmatoarele";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1058, 523);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtVarsta);
            this.Controls.Add(this.textNumeLoc);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtNrSerie);
            this.Controls.Add(this.txtNrTel);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Date Personale";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtNume;
        private TextBox txtNrTel;
        private TextBox txtNrSerie;
        private TextBox txtSerie;
        private TextBox txtAdresa;
        private TextBox txtDep;
        private TextBox textNumeLoc;
        private TextBox txtVarsta;
        private TextBox txtPrenume;
        private PictureBox pictureBox1;
        private Button button1;
        private ListBox listBox2;
        private Label label11;
    }
}