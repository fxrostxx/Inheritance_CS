using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	abstract internal class Triangle : Shape
	{
		public Triangle(int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color) {}
		public abstract double GetHeight();
	}
}
