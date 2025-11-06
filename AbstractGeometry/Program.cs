using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	enum Color
	{
		Black = 0x00000000,
		White = 0x00FFFFFF,
		Red = 0x000000FF,
		Green = 0x0000FF00,
		Blue = 0x00FF0000,
		Yellow = 0x0000FFFF,
		Orange = 0x0000A5FF
	};
	internal class Program
	{
		public static string delimeter = "\n-----------------------\n";
		static void Main(string[] args)
		{
			Rectangle rect = new Rectangle(150, 100, 100, 2, 2, Color.Orange);
			rect.Info();
			Console.WriteLine(delimeter);
			Square square = new Square(100, 100, 100, 1, Color.Red);
			square.Info();
			Console.WriteLine(delimeter);
			Circle circle = new Circle(50, 800, 200, 1, Color.Yellow);
			circle.Info();
			Console.WriteLine(delimeter);
			EquilateralTriangle eTriangle = new EquilateralTriangle(50, 550, 350, 1, Color.Green);
			eTriangle.Info();
			Console.WriteLine(delimeter);
			IsoscelesTriangle iTriangle = new IsoscelesTriangle(80, 50, 650, 450, 1, Color.Red);
			iTriangle.Info();
			Console.WriteLine(delimeter);
			ScaleneTriangle sTriangle = new ScaleneTriangle(40, 50, 80, 750, 550, 1, Color.White);
			sTriangle.Info();
			Console.WriteLine(delimeter);
			sTriangle.Side1 = 1;
			sTriangle.Info();
		}
	}
}
