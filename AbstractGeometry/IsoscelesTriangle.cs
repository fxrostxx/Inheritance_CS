using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	internal class IsoscelesTriangle : Triangle
	{
		private double itSide;
		private double itBase;
		public IsoscelesTriangle(double itSide, double itBase, int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color)
		{
			Side = itSide;
			Base = itBase;
		}
		public double Side
		{
			get { return itSide; }
			set { itSide = FilterSize(value); }
		}
		public double Base
		{
			get { return itBase; }
			set { itBase = FilterSize(value); }
		}
		public override double GetHeight()
		{
			return Math.Sqrt(Math.Pow(itSide, 2) - Math.Pow(itBase / 2, 2));
		}
		public override double GetArea()
		{
			return itBase * GetHeight() / 2;
		}
		public override double GetPerimeter()
		{
			return itSide * 2 + itBase;
		}
		public override void Draw()
		{
			
		}
		public override void Info()
		{
			Console.WriteLine(GetType().ToString().Split('.').Last());
			Console.WriteLine($"Стороны: {Side}");
			Console.WriteLine($"Основание: {Base}");
			Console.WriteLine($"Высота: {GetHeight()}");
			base.Info();
		}
	}
}
