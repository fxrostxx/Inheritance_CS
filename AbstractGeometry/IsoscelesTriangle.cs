using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class IsoscelesTriangle : Triangle
	{
		private double itSide;
		private double itBase;
		public IsoscelesTriangle(double itSide, double itBase, int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color)
		{
			if (IsValidTriangle(itSide, itSide, itBase))
			{
				this.itSide = FilterSize(itSide);
				this.itBase = FilterSize(itBase);
			}
			else
			{
				this.itSide = 0;
				this.itBase = 0;
			}
		}
		public double Side
		{
			get => itSide;
			set
			{
				double newValue = FilterSize(value);
				if (IsValidTriangle(newValue, newValue, itBase)) itSide = newValue;
			}
		}
		public double Base
		{
			get => itBase;
			set
			{
				double newValue = FilterSize(value);
				if (IsValidTriangle(itSide, itSide, newValue)) itBase = newValue;
			}
		}
		public override double GetHeight() => Math.Sqrt(Math.Pow(itSide, 2) - Math.Pow(itBase / 2, 2));
		public override double GetArea() => itBase * GetHeight() / 2;
		public override double GetPerimeter() => itSide * 2 + itBase;
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			SolidBrush brush = new SolidBrush(Color);
			PointF[] vertices =
			{
				new PointF((float)(StartX + Base / 2), (float)StartY),
				new PointF((float)StartX, (float)(StartY + GetHeight())),
				new PointF((float)(StartX + Base), (float)(StartY + GetHeight()))
			};
			e.Graphics.DrawPolygon(pen, vertices);
			e.Graphics.FillPolygon(brush, vertices);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(GetType().ToString().Split('.').Last());
			Console.WriteLine($"Стороны: {Side}");
			Console.WriteLine($"Основание: {Base}");
			Console.WriteLine($"Высота: {GetHeight()}");
			base.Info(e);
		}
	}
}
