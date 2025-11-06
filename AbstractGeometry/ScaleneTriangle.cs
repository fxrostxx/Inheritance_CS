using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	internal class ScaleneTriangle : Triangle
	{
		private double side1;
		private double side2;
		private double side3;
		private bool IsValidScaleneTriangle(double side1, double side2, double side3)
		{
			return side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2;
		}
		public ScaleneTriangle(double side1, double side2, double side3, int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color)
		{
			if (IsValidScaleneTriangle(side1, side2, side3))
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
			get { return side1; }
			set
			{
				double newValue = FilterSize(value);
				if (IsValidScaleneTriangle(newValue, side2, side3)) side1 = newValue;
			}
		}
		public double Side2
		{
			get { return side2; }
			set
			{
				double newValue = FilterSize(value);
				if (IsValidScaleneTriangle(side1, newValue, side3)) side2 = newValue;
			}
		}
		public double Side3
		{
			get { return side3; }
			set
			{
				double newValue = FilterSize(value);
				if (IsValidScaleneTriangle(side1, side2, newValue)) side3 = newValue;
			}
		}
		public override double GetHeight()
		{
			return 2 * GetArea() / side1;
		}
		public override double GetArea()
		{
			double halfperimeter = GetPerimeter() / 2;
			return Math.Sqrt(halfperimeter * (halfperimeter - side1) * (halfperimeter - side2) * (halfperimeter - side3));
		}
		public override double GetPerimeter()
		{
			return side1 + side2 + side3;
		}
		public override void Draw()
		{
			
		}
		public override void Info()
		{
			Console.WriteLine(GetType().ToString().Split('.').Last());
			Console.WriteLine($"Стороны: {Side1}, {Side2}, {Side3}");
			Console.WriteLine($"Высота: {GetHeight()}");
			base.Info();
		}
	}
}
