using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Circle : Shape
	{
		private double radius;
		public Circle(double radius, int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color)
		{
			Radius = radius;
		}
		public double Radius
		{
			get => radius;
			set => radius = FilterSize(value);
		}
		public double GetDiameter() => 2 * radius;
		public override double GetArea() => Math.PI * radius * radius;
		public override double GetPerimeter() => Math.PI * GetDiameter();
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			SolidBrush brush = new SolidBrush(Color);
			e.Graphics.DrawEllipse(pen, StartX, StartY, (float)GetDiameter(), (float)GetDiameter());
			//e.Graphics.FillEllipse(brush, StartX, StartY, (float)GetDiameter(), (float)GetDiameter());
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(GetType().ToString().Split('.').Last());
			Console.WriteLine($"Радиус: {radius}");
			base.Info(e);
		}
	}
}
