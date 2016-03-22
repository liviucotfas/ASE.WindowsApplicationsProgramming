namespace Seminar5
{
    partial class BonComanda
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
			this.tbData = new System.Windows.Forms.TextBox();
			this.tbOra = new System.Windows.Forms.TextBox();
			this.lblData = new System.Windows.Forms.Label();
			this.lblOra = new System.Windows.Forms.Label();
			this.epNume = new System.Windows.Forms.ErrorProvider(this.components);
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.lbNrComenzi = new System.Windows.Forms.Label();
			this.btnSalvare = new System.Windows.Forms.Button();
			this.cbMasina = new System.Windows.Forms.ComboBox();
			this.lblMasina = new System.Windows.Forms.Label();
			this.tbPrenume = new System.Windows.Forms.TextBox();
			this.lblPren = new System.Windows.Forms.Label();
			this.tbNume = new System.Windows.Forms.TextBox();
			this.lblNume = new System.Windows.Forms.Label();
			this.tpVizComenzi = new System.Windows.Forms.TabPage();
			this.btnRestaureaza = new System.Windows.Forms.Button();
			this.btnSalveaza = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.lvComenzi = new System.Windows.Forms.ListView();
			this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chMasina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.epNume)).BeginInit();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tpVizComenzi.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitlu
			// 
			this.lblTitlu.AutoSize = true;
			this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitlu.ForeColor = System.Drawing.Color.DarkRed;
			this.lblTitlu.Location = new System.Drawing.Point(12, 18);
			this.lblTitlu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitlu.Name = "lblTitlu";
			this.lblTitlu.Size = new System.Drawing.Size(236, 20);
			this.lblTitlu.TabIndex = 0;
			this.lblTitlu.Text = "Bon comanda- Dealer Auto";
			// 
			// tbData
			// 
			this.tbData.Location = new System.Drawing.Point(507, 18);
			this.tbData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbData.Name = "tbData";
			this.tbData.ReadOnly = true;
			this.tbData.Size = new System.Drawing.Size(115, 22);
			this.tbData.TabIndex = 11;
			// 
			// tbOra
			// 
			this.tbOra.Location = new System.Drawing.Point(676, 18);
			this.tbOra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbOra.Name = "tbOra";
			this.tbOra.ReadOnly = true;
			this.tbOra.Size = new System.Drawing.Size(115, 22);
			this.tbOra.TabIndex = 12;
			// 
			// lblData
			// 
			this.lblData.AutoSize = true;
			this.lblData.Location = new System.Drawing.Point(463, 23);
			this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(38, 17);
			this.lblData.TabIndex = 13;
			this.lblData.Text = "Data";
			// 
			// lblOra
			// 
			this.lblOra.AutoSize = true;
			this.lblOra.Location = new System.Drawing.Point(640, 23);
			this.lblOra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOra.Name = "lblOra";
			this.lblOra.Size = new System.Drawing.Size(32, 17);
			this.lblOra.TabIndex = 14;
			this.lblOra.Text = "Ora";
			// 
			// epNume
			// 
			this.epNume.ContainerControl = this;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tpVizComenzi);
			this.tabControl.Location = new System.Drawing.Point(16, 50);
			this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(831, 250);
			this.tabControl.TabIndex = 27;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.lbNrComenzi);
			this.tabPage1.Controls.Add(this.btnSalvare);
			this.tabPage1.Controls.Add(this.cbMasina);
			this.tabPage1.Controls.Add(this.lblMasina);
			this.tabPage1.Controls.Add(this.tbPrenume);
			this.tabPage1.Controls.Add(this.lblPren);
			this.tabPage1.Controls.Add(this.tbNume);
			this.tabPage1.Controls.Add(this.lblNume);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage1.Size = new System.Drawing.Size(823, 221);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Adauga Comanda";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(579, 57);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 17);
			this.label1.TabIndex = 43;
			this.label1.Text = "Numar de comenzi";
			// 
			// lbNrComenzi
			// 
			this.lbNrComenzi.AutoSize = true;
			this.lbNrComenzi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.lbNrComenzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNrComenzi.Location = new System.Drawing.Point(568, 74);
			this.lbNrComenzi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbNrComenzi.Name = "lbNrComenzi";
			this.lbNrComenzi.Size = new System.Drawing.Size(155, 52);
			this.lbNrComenzi.TabIndex = 42;
			this.lbNrComenzi.Text = "           ";
			// 
			// btnSalvare
			// 
			this.btnSalvare.Location = new System.Drawing.Point(271, 161);
			this.btnSalvare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSalvare.Name = "btnSalvare";
			this.btnSalvare.Size = new System.Drawing.Size(100, 28);
			this.btnSalvare.TabIndex = 41;
			this.btnSalvare.Text = "Adauga";
			this.btnSalvare.UseVisualStyleBackColor = true;
			this.btnSalvare.Click += new System.EventHandler(this.BtnSalvareClick1);
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
			this.cbMasina.Location = new System.Drawing.Point(104, 116);
			this.cbMasina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbMasina.Name = "cbMasina";
			this.cbMasina.Size = new System.Drawing.Size(265, 24);
			this.cbMasina.Sorted = true;
			this.cbMasina.TabIndex = 39;
			// 
			// lblMasina
			// 
			this.lblMasina.AutoSize = true;
			this.lblMasina.Location = new System.Drawing.Point(31, 121);
			this.lblMasina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMasina.Name = "lblMasina";
			this.lblMasina.Size = new System.Drawing.Size(57, 17);
			this.lblMasina.TabIndex = 38;
			this.lblMasina.Text = "Masina:";
			// 
			// tbPrenume
			// 
			this.tbPrenume.Location = new System.Drawing.Point(104, 74);
			this.tbPrenume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbPrenume.Name = "tbPrenume";
			this.tbPrenume.Size = new System.Drawing.Size(265, 22);
			this.tbPrenume.TabIndex = 30;
			// 
			// lblPren
			// 
			this.lblPren.AutoSize = true;
			this.lblPren.Location = new System.Drawing.Point(31, 79);
			this.lblPren.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPren.Name = "lblPren";
			this.lblPren.Size = new System.Drawing.Size(69, 17);
			this.lblPren.TabIndex = 29;
			this.lblPren.Text = "Prenume:";
			// 
			// tbNume
			// 
			this.tbNume.Location = new System.Drawing.Point(104, 33);
			this.tbNume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbNume.Name = "tbNume";
			this.tbNume.Size = new System.Drawing.Size(265, 22);
			this.tbNume.TabIndex = 28;
			// 
			// lblNume
			// 
			this.lblNume.AutoSize = true;
			this.lblNume.Location = new System.Drawing.Point(31, 38);
			this.lblNume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNume.Name = "lblNume";
			this.lblNume.Size = new System.Drawing.Size(49, 17);
			this.lblNume.TabIndex = 27;
			this.lblNume.Text = "Nume:";
			// 
			// tpVizComenzi
			// 
			this.tpVizComenzi.Controls.Add(this.btnRestaureaza);
			this.tpVizComenzi.Controls.Add(this.btnSalveaza);
			this.tpVizComenzi.Controls.Add(this.btnDelete);
			this.tpVizComenzi.Controls.Add(this.btnEdit);
			this.tpVizComenzi.Controls.Add(this.lvComenzi);
			this.tpVizComenzi.Location = new System.Drawing.Point(4, 25);
			this.tpVizComenzi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tpVizComenzi.Name = "tpVizComenzi";
			this.tpVizComenzi.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tpVizComenzi.Size = new System.Drawing.Size(823, 221);
			this.tpVizComenzi.TabIndex = 1;
			this.tpVizComenzi.Text = "Vizalizare comenzi";
			this.tpVizComenzi.UseVisualStyleBackColor = true;
			// 
			// btnRestaureaza
			// 
			this.btnRestaureaza.Location = new System.Drawing.Point(708, 177);
			this.btnRestaureaza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRestaureaza.Name = "btnRestaureaza";
			this.btnRestaureaza.Size = new System.Drawing.Size(100, 28);
			this.btnRestaureaza.TabIndex = 4;
			this.btnRestaureaza.Text = "Restaureaza";
			this.btnRestaureaza.UseVisualStyleBackColor = true;
			this.btnRestaureaza.Click += new System.EventHandler(this.BtnRestaureazaClick);
			// 
			// btnSalveaza
			// 
			this.btnSalveaza.Location = new System.Drawing.Point(708, 139);
			this.btnSalveaza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSalveaza.Name = "btnSalveaza";
			this.btnSalveaza.Size = new System.Drawing.Size(100, 28);
			this.btnSalveaza.TabIndex = 3;
			this.btnSalveaza.Text = "Salveaza";
			this.btnSalveaza.UseVisualStyleBackColor = true;
			this.btnSalveaza.Click += new System.EventHandler(this.BtnSalveazaClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(708, 53);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(100, 28);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(708, 17);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(100, 28);
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// lvComenzi
			// 
			this.lvComenzi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNume,
            this.chPrenume,
            this.chMasina});
			this.lvComenzi.Location = new System.Drawing.Point(4, 4);
			this.lvComenzi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lvComenzi.Name = "lvComenzi";
			this.lvComenzi.Size = new System.Drawing.Size(689, 210);
			this.lvComenzi.TabIndex = 0;
			this.lvComenzi.UseCompatibleStateImageBehavior = false;
			this.lvComenzi.View = System.Windows.Forms.View.Details;
			// 
			// chNume
			// 
			this.chNume.Text = "Nume";
			// 
			// chPrenume
			// 
			this.chPrenume.Text = "Prenume";
			// 
			// chMasina
			// 
			this.chMasina.Text = "Masina";
			// 
			// BonComanda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(857, 314);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.lblOra);
			this.Controls.Add(this.lblData);
			this.Controls.Add(this.tbOra);
			this.Controls.Add(this.tbData);
			this.Controls.Add(this.lblTitlu);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "BonComanda";
			this.Text = "Bon de comanda";
			this.Load += new System.EventHandler(this.Form1Load);
			((System.ComponentModel.ISupportInitialize)(this.epNume)).EndInit();
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tpVizComenzi.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbOra;
        private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.ErrorProvider epNume;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.ComboBox cbMasina;
        private System.Windows.Forms.Label lblMasina;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label lblPren;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TabPage tpVizComenzi;
        private System.Windows.Forms.ListView lvComenzi;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chPrenume;
        private System.Windows.Forms.ColumnHeader chMasina;
        private System.Windows.Forms.Label lbNrComenzi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRestaureaza;
        private System.Windows.Forms.Button btnSalveaza;
    }
}

