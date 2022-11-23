namespace WinForm_Gyumolcsok
{
    partial class Form1
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
            this.listBox_gyumolcsok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_egysegar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.egysegar = new System.Windows.Forms.Label();
            this.mennyiseg = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.Label();
            this.azonosito = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_egysegar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_gyumolcsok
            // 
            this.listBox_gyumolcsok.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox_gyumolcsok.FormattingEnabled = true;
            this.listBox_gyumolcsok.Location = new System.Drawing.Point(451, 0);
            this.listBox_gyumolcsok.Name = "listBox_gyumolcsok";
            this.listBox_gyumolcsok.Size = new System.Drawing.Size(152, 450);
            this.listBox_gyumolcsok.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_egysegar);
            this.groupBox1.Controls.Add(this.numericUpDown_mennyiseg);
            this.groupBox1.Controls.Add(this.textBox_nev);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.egysegar);
            this.groupBox1.Controls.Add(this.mennyiseg);
            this.groupBox1.Controls.Add(this.nev);
            this.groupBox1.Controls.Add(this.azonosito);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kivalasztott_gyumolcs";
            // 
            // numericUpDown_egysegar
            // 
            this.numericUpDown_egysegar.DecimalPlaces = 2;
            this.numericUpDown_egysegar.Location = new System.Drawing.Point(153, 223);
            this.numericUpDown_egysegar.Name = "numericUpDown_egysegar";
            this.numericUpDown_egysegar.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown_egysegar.TabIndex = 7;
            this.numericUpDown_egysegar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_mennyiseg
            // 
            this.numericUpDown_mennyiseg.DecimalPlaces = 2;
            this.numericUpDown_mennyiseg.Location = new System.Drawing.Point(153, 171);
            this.numericUpDown_mennyiseg.Name = "numericUpDown_mennyiseg";
            this.numericUpDown_mennyiseg.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown_mennyiseg.TabIndex = 6;
            this.numericUpDown_mennyiseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(153, 118);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(118, 20);
            this.textBox_nev.TabIndex = 5;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(153, 60);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(62, 20);
            this.textBox_id.TabIndex = 4;
            // 
            // egysegar
            // 
            this.egysegar.AutoSize = true;
            this.egysegar.Location = new System.Drawing.Point(63, 225);
            this.egysegar.Name = "egysegar";
            this.egysegar.Size = new System.Drawing.Size(54, 13);
            this.egysegar.TabIndex = 3;
            this.egysegar.Text = "Egységár:";
            // 
            // mennyiseg
            // 
            this.mennyiseg.AutoSize = true;
            this.mennyiseg.Location = new System.Drawing.Point(56, 173);
            this.mennyiseg.Name = "mennyiseg";
            this.mennyiseg.Size = new System.Drawing.Size(61, 13);
            this.mennyiseg.TabIndex = 2;
            this.mennyiseg.Text = "Mennyiség:";
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Location = new System.Drawing.Point(87, 121);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(30, 13);
            this.nev.TabIndex = 1;
            this.nev.Text = "Név:";
            // 
            // azonosito
            // 
            this.azonosito.AutoSize = true;
            this.azonosito.Location = new System.Drawing.Point(59, 63);
            this.azonosito.Name = "azonosito";
            this.azonosito.Size = new System.Drawing.Size(58, 13);
            this.azonosito.TabIndex = 0;
            this.azonosito.Text = "Azonosító:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_gyumolcsok);
            this.Name = "Form1";
            this.Text = "Gyümölcsök";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_egysegar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mennyiseg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_gyumolcsok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_egysegar;
        private System.Windows.Forms.NumericUpDown numericUpDown_mennyiseg;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label egysegar;
        private System.Windows.Forms.Label mennyiseg;
        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label azonosito;
    }
}

