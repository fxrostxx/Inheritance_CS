using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	abstract internal class Shape
	{
		protected Color color;
		protected int startX;
		protected int startY;
		protected int lineWidth;
		public const int MIN_START_X = 100;
		public const int MIN_START_Y = 100;
		public const int MAX_START_X = 1000;
		public const int MAX_START_Y = 600;
		public const int MIN_LINE_WIDTH = 1;
		public const int MAX_LINE_WIDTH = 16;
		public const int MIN_SIZE = 32;
		public const int MAX_SIZE = 512;
		public Shape(int startX, int startY, int lineWidth, Color color)
		{
			StartX = startX;
			StartY = startY;
			LineWidth = lineWidth;
			this.color = color;
		}
		public int StartX
		{
			get { return startX; }
			set
			{
				startX =
				value < MIN_START_X ? MIN_START_X :
				value > MAX_START_X ? MAX_START_X :
				value;
			}
		}
		public int StartY
		{
			get { return startY; }
			set
			{
				startY =
				value < MIN_START_Y ? MIN_START_Y :
				value > MAX_START_Y ? MAX_START_Y :
				value;
			}
		}
		public int LineWidth
		{
			get { return lineWidth; }
			set
			{
				lineWidth =
				value < MIN_LINE_WIDTH ? MIN_LINE_WIDTH :
				value > MAX_LINE_WIDTH ? MAX_LINE_WIDTH :
				value;
			}
		}
		public double FilterSize(double size)
		{
			return size < MIN_SIZE ? MIN_SIZE :
				   size > MAX_SIZE ? MAX_SIZE :
				   size;
		}
		public abstract double GetArea();
		public abstract double GetPerimeter();
		public abstract void Draw();
		public virtual void Info()
		{
			Console.WriteLine($"Площадь фигуры: {GetArea()}");
			Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
			Draw();
		}
	}
}
