using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class ScaleneTriangle : Triangle
	{
		private double side1;
		private double side2;
		private double side3;
		public ScaleneTriangle(double side1, double side2, double side3, int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color)
		{
			if (IsValidTriangle(side1, side2, side3))
			{
				this.side1 = FilterSize(side1);
				this.side2 = FilterSize(side2);
				this.side3 = FilterSize(side3);
			}
			else
			{
				this.side1 = 0;
				this.side2 = 0;
				this.side3 = 0;
			}
		}
		public double Side1
		{
			get => side1;
			set
			{
				double newValue = FilterSize(value);
				if (IsValidTriangle(newValue, side2, side3)) side1 = newValue;
			}
		}
		public double Side2
		{
			get => side2;
			set
			{
				double newValue = FilterSize(value);
				if (IsValidTriangle(side1, newValue, side3)) side2 = newValue;
			}
		}
		public double Side3
		{
			get => side3;
			set
			{
				double newValue = FilterSize(value);
				if (IsValidTriangle(side1, side2, newValue)) side3 = newValue;
			}
		}
		public override double GetHeight() => 2 * GetArea() / side1;
		public override double GetArea()
		{
			double halfperimeter = GetPerimeter() / 2;
			return Math.Sqrt(halfperimeter * (halfperimeter - side1) * (halfperimeter - side2) * (halfperimeter - side3));
		}
		public override double GetPerimeter() => side1 + side2 + side3;
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			SolidBrush brush = new SolidBrush(Color);
			PointF[] vertices = new PointF[]
			{
				new PointF((float)(StartX + (Side2 * Side2 - Side3 * Side3 + Side1 * Side1) / (2 * Side1)), (float)(StartY + GetHeight())),
				new PointF((float)StartX, (float)(StartY)),
				new PointF((float)(StartX + Side1), (float)(StartY)),
			};
			e.Graphics.DrawPolygon(pen, vertices);
			//e.Graphics.FillPolygon(brush, vertices);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(GetType().ToString().Split('.').Last());
			Console.WriteLine($"Стороны: {Side1}, {Side2}, {Side3}");
			Console.WriteLine($"Высота: {GetHeight()}");
			base.Info(e);
		}
	}
}
