using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	abstract internal class Triangle : Shape, IHaveHeight
	{
		public Triangle(int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color) {}
		public abstract double GetHeight();
		public abstract void DrawHeight(PaintEventArgs e);
		protected bool IsValidTriangle(double side1, double side2, double side3)
		{
			return side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2;
		}
	}
}
