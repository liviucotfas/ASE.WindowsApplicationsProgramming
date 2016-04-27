using ClockUserControlSample;

namespace ClockUserControlAppSample
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
			this.tbOra = new System.Windows.Forms.TextBox();
			this.btnGetSystemTime = new System.Windows.Forms.Button();
			this.ceas = new ClockUserControlSample.Ceas();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbOra
			// 
			this.tbOra.Location = new System.Drawing.Point(250, 29);
			this.tbOra.Name = "tbOra";
			this.tbOra.Size = new System.Drawing.Size(171, 20);
			this.tbOra.TabIndex = 1;
			this.tbOra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbOra_MouseDown);
			// 
			// btnGetSystemTime
			// 
			this.btnGetSystemTime.Location = new System.Drawing.Point(250, 74);
			this.btnGetSystemTime.Name = "btnGetSystemTime";
			this.btnGetSystemTime.Size = new System.Drawing.Size(171, 23);
			this.btnGetSystemTime.TabIndex = 2;
			this.btnGetSystemTime.Text = "Reset to System Time";
			this.btnGetSystemTime.UseVisualStyleBackColor = true;
			this.btnGetSystemTime.Click += new System.EventHandler(this.btnGetSystemTime_Click);
			// 
			// ceas
			// 
			this.ceas.AllowDrop = true;
			this.ceas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ceas.Location = new System.Drawing.Point(9, 13);
			this.ceas.Min = 9;
			this.ceas.MinAlarm = 36;
			this.ceas.Name = "ceas";
			this.ceas.Ora = 0;
			this.ceas.OraAlarm = 4;
			this.ceas.Sec = 14;
			this.ceas.Size = new System.Drawing.Size(208, 189);
			this.ceas.TabIndex = 0;
			this.ceas.Suna += new System.EventHandler(this.ceas1_Suna);
			this.ceas.DragDrop += new System.Windows.Forms.DragEventHandler(this.ceas1_DragDrop);
			this.ceas.DragEnter += new System.Windows.Forms.DragEventHandler(this.ceas1_DragEnter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(247, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Drag / drop:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 287);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGetSystemTime);
			this.Controls.Add(this.tbOra);
			this.Controls.Add(this.ceas);
			this.Name = "MainForm";
			this.Text = "Clock";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Ceas ceas;
        public System.Windows.Forms.TextBox tbOra;
        private System.Windows.Forms.Button btnGetSystemTime;
        private System.Windows.Forms.Label label1;
    }
}

