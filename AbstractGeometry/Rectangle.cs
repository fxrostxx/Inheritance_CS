using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	internal class Rectangle : Shape
	{
		private double height;
		private double width;
		public Rectangle(double width, double height, int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color)
		{
			Width = width;
			Height = height;
		}
		public double Height
		{
			get { return height; }
			set { height = FilterSize(value); }
		}
		public double Width
		{
			get { return width; }
			set { width = FilterSize(value); }
		}
		public override double GetArea()
		{
			return width * height;
		}
		public override double GetPerimeter()
		{
			return 2 * (width + height);
		}
		public override void Draw()
		{
			
		}
		public override void Info()
		{
			Console.WriteLine(GetType().ToString().Split('.').Last());
			Console.WriteLine($"Стороны: {width} x {height}");
			base.Info();
		}
	}
}
