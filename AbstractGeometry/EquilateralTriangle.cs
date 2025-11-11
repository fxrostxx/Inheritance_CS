using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class EquilateralTriangle : Triangle
	{
		private double side;
		public EquilateralTriangle(double side, int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color)
		{
			Side = side;
		}
		public double Side
		{
			get => side;
			set => side = FilterSize(value);
		}
		public override double GetHeight() => Math.Sqrt(Math.Pow(side, 2) - Math.Pow(side, 2) / 2);
		public override double GetArea() => side * GetHeight() / 2;
		public override double GetPerimeter() => side * 3;
		public override void DrawHeight(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			SolidBrush brush = new SolidBrush(Color);
			e.Graphics.DrawLine(pen, (float)(StartX + side / 2), (float)(StartY), (float)(StartX + side / 2), (float)(StartY + GetHeight()));
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			SolidBrush brush = new SolidBrush(Color);
			PointF[] vertices = new PointF[]
			{
				new PointF((float)(StartX + Side / 2), (float)StartY),
				new PointF((float)StartX, (float)(StartY + GetHeight())),
				new PointF((float)(StartX + Side), (float)(StartY + GetHeight()))
			};
			e.Graphics.DrawPolygon(pen, vertices);
			//e.Graphics.FillPolygon(brush, vertices);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(GetType().ToString().Split('.').Last());
			Console.WriteLine($"Стороны: {Side}");
			Console.WriteLine($"Высота: {GetHeight()}");
			base.Info(e);
		}
	}
}
