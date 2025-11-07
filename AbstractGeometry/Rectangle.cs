using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Rectangle : Shape
	{
		private double width;
		private double height;
		public Rectangle(double width, double height, int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color)
		{
			Width = width;
			Height = height;
		}
		public double Width
		{
			get => width;
			set => width = FilterSize(value);
		}
		public double Height
		{
			get => height;
			set => height = FilterSize(value);
		}
		public override double GetArea() => width * height;
		public override double GetPerimeter() => 2 * (width + height);
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			SolidBrush brush = new SolidBrush(Color);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Width, (float)Height);
			e.Graphics.FillRectangle(brush, StartX, StartY, (float)Width, (float)Height);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(GetType().ToString().Split('.').Last());
			Console.WriteLine($"Ширина: {width}");
			Console.WriteLine($"Высота: {height}");
			base.Info(e);
		}
	}
}
