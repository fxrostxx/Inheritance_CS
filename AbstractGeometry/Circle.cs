using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	internal class Circle : Shape
	{
		private double radius;
		public Circle(double radius, int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color)
		{
			this.radius = radius;
		}
		public double Radius
		{
			get { return radius; }
			set { radius = FilterSize(value); }
		}
		public double GetDiameter()
		{
			return 2 * radius;
		}
		public override double GetArea()
		{
			return Math.PI * radius * radius;
		}
		public override double GetPerimeter()
		{
			return Math.PI * GetDiameter();
		}
		public override void Draw()
		{
			
		}
		public override void Info()
		{
			Console.WriteLine(GetType().ToString().Split('.').Last());
			Console.WriteLine($"Радиус: {radius}");
			base.Info();
		}
	}
}
