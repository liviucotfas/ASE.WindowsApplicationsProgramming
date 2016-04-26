using System.Drawing;
using System.Windows.Forms;
using PieChartGraphicsSample.Entities;

namespace PieChartGraphicsSample
{
	public partial class PieChartControl : UserControl
	{
		#region Properties
		private PieChartCategory[] _data;
		public PieChartCategory[] Data {
			get { return _data; }
			set
			{
				if(_data == value)
				return;
				_data = value;
				Invalidate();
			}
		}
		#endregion

		public PieChartControl()
		{
			InitializeComponent();
			ResizeRedraw = true;

			//Default data
			Data = new[]
			{
				new PieChartCategory("Category 1", 20, Color.Red),
				new PieChartCategory("Category 2", 80, Color.Blue),
			};
		}

		private void PieChartControl_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;

			float percent1 = 0;
			float percent2 = 0;
			const float radius = 75;
			const int xCenter = 90;
			const int yCenter = 150;

			const float x = xCenter - radius;
			const float y = yCenter - radius;
			const float width = radius * 2;
			const float height = radius * 2;

			for (int i = 0; i < Data.Length; i++)
			{
				if (i >= 1)
					percent1 += Data[i - 1].Percentage;

				percent2 += Data[i].Percentage;

				float angle1 = percent1 / 100 * 360;
				float angle2 = percent2 / 100 * 360;

				Brush b = new SolidBrush(Data[i].Color);

				graphics.FillPie(b, x, y, width, height, angle1, angle2 - angle1);
			}

			Pen pen = new Pen(Color.Black);

			graphics.DrawEllipse(pen, x, y, width, height);

			const float xpos = x + width + 20;
			float ypos = y - 25;

			for (int i = 0; i < Data.Length; i++)
			{
				Brush b = new SolidBrush(Data[i].Color);

				graphics.FillRectangle(b, xpos, ypos, 30, 30);
				graphics.DrawRectangle(pen, xpos, ypos, 30, 30);

				Brush b2 = new SolidBrush(Color.Black);

				graphics.DrawString(Data[i].Description + ": " + Data[i].Percentage + "%", Font, b2,
					xpos + 35, ypos + 12);

				ypos += 35;
			}
		}
	}
}
