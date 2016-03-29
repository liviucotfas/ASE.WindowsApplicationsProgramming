namespace ValidationTextFile
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.lblTitlu = new System.Windows.Forms.Label();
			this.lblNume = new System.Windows.Forms.Label();
			this.tbNume = new System.Windows.Forms.TextBox();
			this.lblPren = new System.Windows.Forms.Label();
			this.tbPrenume = new System.Windows.Forms.TextBox();
			this.lblSex = new System.Windows.Forms.Label();
			this.rbM = new System.Windows.Forms.RadioButton();
			this.rbF = new System.Windows.Forms.RadioButton();
			this.lblVarsta = new System.Windows.Forms.Label();
			this.tbVarsta = new System.Windows.Forms.TextBox();
			this.lblPermis = new System.Windows.Forms.Label();
			this.tbData = new System.Windows.Forms.TextBox();
			this.tbOra = new System.Windows.Forms.TextBox();
			this.lblData = new System.Windows.Forms.Label();
			this.lblOra = new System.Windows.Forms.Label();
			this.cblPermis = new System.Windows.Forms.CheckedListBox();
			this.lblDeLa = new System.Windows.Forms.Label();
			this.dtpDeLa = new System.Windows.Forms.DateTimePicker();
			this.lblPanaLa = new System.Windows.Forms.Label();
			this.dtpPanaLa = new System.Windows.Forms.DateTimePicker();
			this.lblMasina = new System.Windows.Forms.Label();
			this.cbMasina = new System.Windows.Forms.ComboBox();
			this.lblCuloare = new System.Windows.Forms.Label();
			this.btnSalvare = new System.Windows.Forms.Button();
			this.epNume = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbCuloarePick = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.epNume)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitlu
			// 
			this.lblTitlu.AutoSize = true;
			this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitlu.ForeColor = System.Drawing.Color.DarkRed;
			this.lblTitlu.Location = new System.Drawing.Point(9, 15);
			this.lblTitlu.Name = "lblTitlu";
			this.lblTitlu.Size = new System.Drawing.Size(203, 17);
			this.lblTitlu.TabIndex = 0;
			this.lblTitlu.Text = "Bon comanda- Dealer Auto";
			// 
			// lblNume
			// 
			this.lblNume.AutoSize = true;
			this.lblNume.Location = new System.Drawing.Point(25, 57);
			this.lblNume.Name = "lblNume";
			this.lblNume.Size = new System.Drawing.Size(35, 13);
			this.lblNume.TabIndex = 1;
			this.lblNume.Text = "Nume";
			// 
			// tbNume
			// 
			this.tbNume.Location = new System.Drawing.Point(82, 53);
			this.tbNume.Name = "tbNume";
			this.tbNume.Size = new System.Drawing.Size(200, 20);
			this.tbNume.TabIndex = 2;
			// 
			// lblPren
			// 
			this.lblPren.AutoSize = true;
			this.lblPren.Location = new System.Drawing.Point(335, 57);
			this.lblPren.Name = "lblPren";
			this.lblPren.Size = new System.Drawing.Size(49, 13);
			this.lblPren.TabIndex = 3;
			this.lblPren.Text = "Prenume";
			// 
			// tbPrenume
			// 
			this.tbPrenume.Location = new System.Drawing.Point(393, 53);
			this.tbPrenume.Name = "tbPrenume";
			this.tbPrenume.Size = new System.Drawing.Size(194, 20);
			this.tbPrenume.TabIndex = 4;
			// 
			// lblSex
			// 
			this.lblSex.AutoSize = true;
			this.lblSex.Location = new System.Drawing.Point(25, 99);
			this.lblSex.Name = "lblSex";
			this.lblSex.Size = new System.Drawing.Size(25, 13);
			this.lblSex.TabIndex = 5;
			this.lblSex.Text = "Sex";
			// 
			// rbM
			// 
			this.rbM.AutoSize = true;
			this.rbM.Location = new System.Drawing.Point(93, 97);
			this.rbM.Name = "rbM";
			this.rbM.Size = new System.Drawing.Size(34, 17);
			this.rbM.TabIndex = 6;
			this.rbM.TabStop = true;
			this.rbM.Text = "M";
			this.rbM.UseVisualStyleBackColor = true;
			// 
			// rbF
			// 
			this.rbF.AutoSize = true;
			this.rbF.Location = new System.Drawing.Point(156, 97);
			this.rbF.Name = "rbF";
			this.rbF.Size = new System.Drawing.Size(31, 17);
			this.rbF.TabIndex = 7;
			this.rbF.TabStop = true;
			this.rbF.Text = "F";
			this.rbF.UseVisualStyleBackColor = true;
			// 
			// lblVarsta
			// 
			this.lblVarsta.AutoSize = true;
			this.lblVarsta.Location = new System.Drawing.Point(193, 99);
			this.lblVarsta.Name = "lblVarsta";
			this.lblVarsta.Size = new System.Drawing.Size(37, 13);
			this.lblVarsta.TabIndex = 8;
			this.lblVarsta.Text = "Varsta";
			// 
			// tbVarsta
			// 
			this.tbVarsta.Location = new System.Drawing.Point(245, 95);
			this.tbVarsta.Name = "tbVarsta";
			this.tbVarsta.Size = new System.Drawing.Size(37, 20);
			this.tbVarsta.TabIndex = 9;
			this.tbVarsta.Validating += new System.ComponentModel.CancelEventHandler(this.tbVarsta_Validating);
			// 
			// lblPermis
			// 
			this.lblPermis.AutoSize = true;
			this.lblPermis.Location = new System.Drawing.Point(335, 99);
			this.lblPermis.Name = "lblPermis";
			this.lblPermis.Size = new System.Drawing.Size(38, 13);
			this.lblPermis.TabIndex = 10;
			this.lblPermis.Text = "Permis";
			// 
			// tbData
			// 
			this.tbData.Location = new System.Drawing.Point(380, 15);
			this.tbData.Name = "tbData";
			this.tbData.ReadOnly = true;
			this.tbData.Size = new System.Drawing.Size(87, 20);
			this.tbData.TabIndex = 11;
			// 
			// tbOra
			// 
			this.tbOra.Location = new System.Drawing.Point(507, 15);
			this.tbOra.Name = "tbOra";
			this.tbOra.ReadOnly = true;
			this.tbOra.Size = new System.Drawing.Size(87, 20);
			this.tbOra.TabIndex = 12;
			// 
			// lblData
			// 
			this.lblData.AutoSize = true;
			this.lblData.Location = new System.Drawing.Point(347, 19);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(30, 13);
			this.lblData.TabIndex = 13;
			this.lblData.Text = "Data";
			// 
			// lblOra
			// 
			this.lblOra.AutoSize = true;
			this.lblOra.Location = new System.Drawing.Point(480, 19);
			this.lblOra.Name = "lblOra";
			this.lblOra.Size = new System.Drawing.Size(24, 13);
			this.lblOra.TabIndex = 14;
			this.lblOra.Text = "Ora";
			// 
			// cblPermis
			// 
			this.cblPermis.FormattingEnabled = true;
			this.cblPermis.Items.AddRange(new object[] {
            "Categoria A",
            "Categoria B",
            "Categoria C"});
			this.cblPermis.Location = new System.Drawing.Point(391, 96);
			this.cblPermis.Name = "cblPermis";
			this.cblPermis.Size = new System.Drawing.Size(196, 34);
			this.cblPermis.TabIndex = 15;
			// 
			// lblDeLa
			// 
			this.lblDeLa.AutoSize = true;
			this.lblDeLa.Location = new System.Drawing.Point(8, 23);
			this.lblDeLa.Name = "lblDeLa";
			this.lblDeLa.Size = new System.Drawing.Size(35, 13);
			this.lblDeLa.TabIndex = 16;
			this.lblDeLa.Text = "De la:";
			// 
			// dtpDeLa
			// 
			this.dtpDeLa.Location = new System.Drawing.Point(65, 19);
			this.dtpDeLa.Name = "dtpDeLa";
			this.dtpDeLa.Size = new System.Drawing.Size(205, 20);
			this.dtpDeLa.TabIndex = 17;
			// 
			// lblPanaLa
			// 
			this.lblPanaLa.AutoSize = true;
			this.lblPanaLa.Location = new System.Drawing.Point(320, 23);
			this.lblPanaLa.Name = "lblPanaLa";
			this.lblPanaLa.Size = new System.Drawing.Size(46, 13);
			this.lblPanaLa.TabIndex = 18;
			this.lblPanaLa.Text = "Pana la:";
			// 
			// dtpPanaLa
			// 
			this.dtpPanaLa.Location = new System.Drawing.Point(377, 19);
			this.dtpPanaLa.Name = "dtpPanaLa";
			this.dtpPanaLa.Size = new System.Drawing.Size(198, 20);
			this.dtpPanaLa.TabIndex = 19;
			// 
			// lblMasina
			// 
			this.lblMasina.AutoSize = true;
			this.lblMasina.Location = new System.Drawing.Point(25, 206);
			this.lblMasina.Name = "lblMasina";
			this.lblMasina.Size = new System.Drawing.Size(44, 13);
			this.lblMasina.TabIndex = 20;
			this.lblMasina.Text = "Masina:";
			// 
			// cbMasina
			// 
			this.cbMasina.FormattingEnabled = true;
			this.cbMasina.Items.AddRange(new object[] {
            "BMW",
            "Dacia",
            "Ferrari",
            "Ford ",
            "Lada",
            "Mercedes",
            "Skoda"});
			this.cbMasina.Location = new System.Drawing.Point(82, 202);
			this.cbMasina.Name = "cbMasina";
			this.cbMasina.Size = new System.Drawing.Size(200, 21);
			this.cbMasina.Sorted = true;
			this.cbMasina.TabIndex = 21;
			// 
			// lblCuloare
			// 
			this.lblCuloare.AutoSize = true;
			this.lblCuloare.Location = new System.Drawing.Point(335, 206);
			this.lblCuloare.Name = "lblCuloare";
			this.lblCuloare.Size = new System.Drawing.Size(43, 13);
			this.lblCuloare.TabIndex = 22;
			this.lblCuloare.Text = "Culoare";
			// 
			// btnSalvare
			// 
			this.btnSalvare.Location = new System.Drawing.Point(519, 241);
			this.btnSalvare.Name = "btnSalvare";
			this.btnSalvare.Size = new System.Drawing.Size(75, 23);
			this.btnSalvare.TabIndex = 24;
			this.btnSalvare.Text = "Salvare";
			this.btnSalvare.UseVisualStyleBackColor = true;
			this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
			// 
			// epNume
			// 
			this.epNume.ContainerControl = this;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpDeLa);
			this.groupBox1.Controls.Add(this.lblDeLa);
			this.groupBox1.Controls.Add(this.lblPanaLa);
			this.groupBox1.Controls.Add(this.dtpPanaLa);
			this.groupBox1.Location = new System.Drawing.Point(12, 140);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(582, 52);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Data livrarii";
			// 
			// lbCuloarePick
			// 
			this.lbCuloarePick.AutoSize = true;
			this.lbCuloarePick.BackColor = System.Drawing.Color.Black;
			this.lbCuloarePick.Location = new System.Drawing.Point(390, 206);
			this.lbCuloarePick.Name = "lbCuloarePick";
			this.lbCuloarePick.Size = new System.Drawing.Size(196, 13);
			this.lbCuloarePick.TabIndex = 26;
			this.lbCuloarePick.Text = "                                                               ";
			this.lbCuloarePick.Click += new System.EventHandler(this.btnCuloare_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(618, 321);
			this.Controls.Add(this.lbCuloarePick);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSalvare);
			this.Controls.Add(this.lblCuloare);
			this.Controls.Add(this.cbMasina);
			this.Controls.Add(this.lblMasina);
			this.Controls.Add(this.cblPermis);
			this.Controls.Add(this.lblOra);
			this.Controls.Add(this.lblData);
			this.Controls.Add(this.tbOra);
			this.Controls.Add(this.tbData);
			this.Controls.Add(this.lblPermis);
			this.Controls.Add(this.tbVarsta);
			this.Controls.Add(this.lblVarsta);
			this.Controls.Add(this.rbF);
			this.Controls.Add(this.rbM);
			this.Controls.Add(this.lblSex);
			this.Controls.Add(this.tbPrenume);
			this.Controls.Add(this.lblPren);
			this.Controls.Add(this.tbNume);
			this.Controls.Add(this.lblNume);
			this.Controls.Add(this.lblTitlu);
			this.Name = "MainForm";
			this.Text = "Bon de comanda";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.epNume)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lblPren;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.Label lblPermis;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbOra;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.CheckedListBox cblPermis;
        private System.Windows.Forms.Label lblDeLa;
        private System.Windows.Forms.DateTimePicker dtpDeLa;
        private System.Windows.Forms.Label lblPanaLa;
        private System.Windows.Forms.DateTimePicker dtpPanaLa;
        private System.Windows.Forms.Label lblMasina;
        private System.Windows.Forms.ComboBox cbMasina;
        private System.Windows.Forms.Label lblCuloare;
		private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.ErrorProvider epNume;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbCuloarePick;
    }
}

