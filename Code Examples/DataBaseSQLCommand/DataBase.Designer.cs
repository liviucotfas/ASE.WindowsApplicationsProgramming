namespace DataBaseSQLCommand
{
    partial class DataBase
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAfisare = new System.Windows.Forms.TextBox();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnInstert = new System.Windows.Forms.Button();
            this.btnProc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGoleste = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informatii studenti";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbAfisare
            // 
            this.tbAfisare.Location = new System.Drawing.Point(16, 55);
            this.tbAfisare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAfisare.Multiline = true;
            this.tbAfisare.Name = "tbAfisare";
            this.tbAfisare.Size = new System.Drawing.Size(279, 205);
            this.tbAfisare.TabIndex = 1;
            // 
            // btnAfisare
            // 
            this.btnAfisare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfisare.Location = new System.Drawing.Point(353, 232);
            this.btnAfisare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(113, 28);
            this.btnAfisare.TabIndex = 2;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // btnInstert
            // 
            this.btnInstert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstert.Location = new System.Drawing.Point(21, 66);
            this.btnInstert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInstert.Name = "btnInstert";
            this.btnInstert.Size = new System.Drawing.Size(113, 32);
            this.btnInstert.TabIndex = 3;
            this.btnInstert.Text = "Inserare";
            this.btnInstert.UseVisualStyleBackColor = true;
            this.btnInstert.Click += new System.EventHandler(this.btnInstert_Click);
            // 
            // btnProc
            // 
            this.btnProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProc.Location = new System.Drawing.Point(21, 23);
            this.btnProc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(113, 30);
            this.btnProc.TabIndex = 4;
            this.btnProc.Text = "Procedura";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProc);
            this.groupBox1.Controls.Add(this.btnInstert);
            this.groupBox1.Location = new System.Drawing.Point(332, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(149, 116);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functionalitate";
            // 
            // btnGoleste
            // 
            this.btnGoleste.Location = new System.Drawing.Point(353, 188);
            this.btnGoleste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGoleste.Name = "btnGoleste";
            this.btnGoleste.Size = new System.Drawing.Size(113, 28);
            this.btnGoleste.TabIndex = 7;
            this.btnGoleste.Text = "Goleste textbox";
            this.btnGoleste.UseVisualStyleBackColor = true;
            this.btnGoleste.Click += new System.EventHandler(this.btnGoleste_Click);
            // 
            // DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 274);
            this.Controls.Add(this.btnGoleste);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.tbAfisare);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DataBase";
            this.Text = "DataBase";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAfisare;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnInstert;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGoleste;
    }
}

