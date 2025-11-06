using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			get{ return side; }
			set { side = FilterSize(value); }
		}
		public override double GetHeight()
		{
			return Math.Sqrt(Math.Pow(side, 2) - Math.Pow(side, 2) / 2);
		}
		public override double GetArea()
		{
			return side * GetHeight() / 2;
		}
		public override double GetPerimeter()
		{
			return side * 3;
		}
		public override void Draw()
		{
			
		}
		public override void Info()
		{
			Console.WriteLine(GetType().ToString().Split('.').Last());
			Console.WriteLine($"Стороны: {Side}");
			Console.WriteLine($"Высота: {GetHeight()}");
			base.Info();
		}
	}
}
