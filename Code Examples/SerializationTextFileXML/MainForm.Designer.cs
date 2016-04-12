﻿namespace SerializationTextFileXML
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvParticipants = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSerialize = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDeserialize = new System.Windows.Forms.ToolStripMenuItem();
			this.textFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnTextFile = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(501, 76);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(167, 23);
			this.btnAdd.TabIndex = 52;
			this.btnAdd.Text = "Add Participant";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Last Name";
			// 
			// tbLastName
			// 
			this.tbLastName.Location = new System.Drawing.Point(102, 31);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(200, 20);
			this.tbLastName.TabIndex = 0;
			// 
			// tbFirstName
			// 
			this.tbFirstName.Location = new System.Drawing.Point(102, 72);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(200, 20);
			this.tbFirstName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "First Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(403, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Birth Date";
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.Location = new System.Drawing.Point(467, 29);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
			this.dtpBirthDate.TabIndex = 5;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "First Name";
			this.columnHeader2.Width = 150;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Last Name";
			this.columnHeader1.Width = 150;
			// 
			// lvParticipants
			// 
			this.lvParticipants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lvParticipants.FullRowSelect = true;
			this.lvParticipants.GridLines = true;
			this.lvParticipants.Location = new System.Drawing.Point(12, 163);
			this.lvParticipants.Name = "lvParticipants";
			this.lvParticipants.Size = new System.Drawing.Size(687, 234);
			this.lvParticipants.TabIndex = 60;
			this.lvParticipants.UseCompatibleStateImageBehavior = false;
			this.lvParticipants.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Birth Date";
			this.columnHeader3.Width = 120;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tbLastName);
			this.groupBox1.Controls.Add(this.tbFirstName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.dtpBirthDate);
			this.groupBox1.Location = new System.Drawing.Point(12, 38);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(687, 119);
			this.groupBox1.TabIndex = 59;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "New Participant";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.textFileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(706, 24);
			this.menuStrip1.TabIndex = 61;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerialize,
            this.btnDeserialize});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
			this.fileToolStripMenuItem.Text = "Serialization";
			// 
			// btnSerialize
			// 
			this.btnSerialize.Name = "btnSerialize";
			this.btnSerialize.Size = new System.Drawing.Size(152, 22);
			this.btnSerialize.Text = "Serialize";
			this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
			// 
			// btnDeserialize
			// 
			this.btnDeserialize.Name = "btnDeserialize";
			this.btnDeserialize.Size = new System.Drawing.Size(152, 22);
			this.btnDeserialize.Text = "Deserialize";
			this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
			// 
			// textFileToolStripMenuItem
			// 
			this.textFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTextFile});
			this.textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
			this.textFileToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.textFileToolStripMenuItem.Text = "TextFile";
			// 
			// btnTextFile
			// 
			this.btnTextFile.Name = "btnTextFile";
			this.btnTextFile.Size = new System.Drawing.Size(152, 22);
			this.btnTextFile.Text = "Export";
			this.btnTextFile.Click += new System.EventHandler(this.btnTextFile_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(706, 401);
			this.Controls.Add(this.lvParticipants);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "WinAppProgramming Run";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvParticipants;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnSerialize;
		private System.Windows.Forms.ToolStripMenuItem btnDeserialize;
		private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnTextFile;
	}
}

