using System.Drawing;
using System.Windows.Forms;
using PieChartGraphicsSample.Entities;

namespace PieChartGraphicsSample
{
	public partial class MainForm : Form
	{
		#region Attributes
		private readonly PieChartCategory[] _pieCategories;
		#endregion

		public MainForm()
		{
			InitializeComponent();

			_pieCategories = new[]
			{
				new PieChartCategory("Gold", 20, Color.Red),
				new PieChartCategory("Stocks", 15, Color.Blue),
				new PieChartCategory("Bonds", 35, Color.Magenta),
				new PieChartCategory("ETFs", 15, Color.YellowGreen),
				new PieChartCategory("Options", (float) 7.5, Color.Tomato),
				new PieChartCategory("Cash", (float) 7.5, Color.Beige)
			};
		}

		private void MainForm_Paint(object sender, PaintEventArgs e)
		{
			float percent1 = 0;
			float percent2 = 0;
			float radius = 75;
			int xCenter = 90, yCenter = 150;

			Graphics myGraphics = e.Graphics;

			float x = xCenter - radius;
			float y = yCenter - radius;
			float width = radius*2;
			float height = radius*2;

			for (int i = 0; i < _pieCategories.Length; i++)
			{

				if (i >= 1)
					percent1 += _pieCategories[i - 1].Percentage;

				percent2 += _pieCategories[i].Percentage;

				float angle1 = percent1/100*360;
				float angle2 = percent2/100*360;

				Brush b = new SolidBrush(_pieCategories[i].Color);

				myGraphics.FillPie(b, x, y, width, height, angle1, angle2 - angle1);
			}

			Pen pen = new Pen(Color.Black);

			myGraphics.DrawEllipse(pen, x, y, width, height);

			float xpos = x + width + 20;
			float ypos = y - 25;

			for (int i = 0; i < _pieCategories.Length; i++)
			{
				Brush b = new SolidBrush(_pieCategories[i].Color);

				myGraphics.FillRectangle(b, xpos, ypos, 30, 30);
				myGraphics.DrawRectangle(pen, xpos, ypos, 30, 30);

				Brush b2 = new SolidBrush(Color.Black);

				myGraphics.DrawString(_pieCategories[i].Description + ": " + _pieCategories[i].Percentage + "%", Font, b2,
					xpos + 35, ypos + 12);

				ypos += 35;
			}
			
			myGraphics.Dispose();
		}
	}
}
