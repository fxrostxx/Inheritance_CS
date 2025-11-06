using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	internal class Square : Rectangle
	{
		public Square(int side, int startX, int startY, int lineWidth, Color color)
			: base(side, side, startX, startY, lineWidth, color) {}
	}
}
