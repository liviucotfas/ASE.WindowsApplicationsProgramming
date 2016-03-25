using System;
using System.Windows.Forms;

namespace MouseEvents
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			lbl.Text = "";
			txt.Text = "";
		}

		private void lbl_MouseEnter(object sender, EventArgs e)
		{
			lbl.Text = "MouseEnter";
			TextBoxDraw("Label MouseEnter");
		}

		private void lbl_MouseHover(object sender, EventArgs e)
		{
			lbl.Text = "MouseHover";
			TextBoxDraw("Label MouseHover");
		}

		private void lbl_MouseLeave(object sender, EventArgs e)
		{
			lbl.Text = "MouseLeave";
			TextBoxDraw("Label MouseLeave");
		}

		private void lbl_MouseDown(object sender, MouseEventArgs e)
		{
			lbl.Text = "MouseDown";
			string str;
			str = "Label MouseDown";
			str += "\r\n\tButton:  " + e.Button.ToString();
			str += "\r\n\tClicks:  " + e.Clicks.ToString();
			str += "\r\n\tDelta:  " + e.Delta.ToString();
			str += "\r\n\tX:  " + e.X.ToString();
			str += "\r\n\tY:  " + e.Y.ToString();
			TextBoxDraw(str);
		}

		private void lbl_MouseMove(object sender, MouseEventArgs e)
		{
			lbl.Text = "MouseMove";
			string str;
			str = "Label MouseMove";
			str += "\r\n\tButton:  " + e.Button.ToString();
			str += "\r\n\tClicks:  " + e.Clicks.ToString();
			str += "\r\n\tDelta:  " + e.Delta.ToString();
			str += "\r\n\tX:  " + e.X.ToString();
			str += "\r\n\tY:  " + e.Y.ToString();
			TextBoxDraw(str);
		}

		private void lbl_MouseUp(object sender, MouseEventArgs e)
		{
			lbl.Text = "MouseUp";
			string str;
			str = "Label MouseUp";
			str += "\r\n\tButton:  " + e.Button.ToString();
			str += "\r\n\tClicks:  " + e.Clicks.ToString();
			str += "\r\n\tDelta:  " + e.Delta.ToString();
			str += "\r\n\tX:  " + e.X.ToString();
			str += "\r\n\tY:  " + e.Y.ToString();
			TextBoxDraw(str);
		}

		private void lbl_MouseWheel(object sender, MouseEventArgs e)
		{
			lbl.Text = "MouseWheel";
			string str;
			str = "Label MouseWheel";
			str += "\r\n\tButton:  " + e.Button.ToString();
			str += "\r\n\tClicks:  " + e.Clicks.ToString();
			str += "\r\n\tDelta:  " + e.Delta.ToString();
			str += "\r\n\tX:  " + e.X;
			str += "\r\n\tY:  " + e.Y.ToString();
			TextBoxDraw(str);
		}

		private void lbl_Click(object sender, EventArgs e)
		{
			lbl.Text = "Click";
			TextBoxDraw("Label Click");
		}

		private void lbl_DoubleClick(object sender, EventArgs e)
		{
			lbl.Text = "DoubleClick";
			TextBoxDraw("Label DoubleClick");
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			TextBoxDraw("Form MouseEnter");
		}

		protected override void OnMouseHover(EventArgs e)
		{
			base.OnMouseHover(e);
			TextBoxDraw("Form MouseHover");
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			TextBoxDraw("Form MouseLeave");
		}

		private void TextBoxDraw(string str)
		{
			txt.AppendText("\r\n" + str);
		}
	}
}
