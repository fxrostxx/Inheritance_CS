//#define ABSTRACT_1

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Program
	{
		public static string delimeter = "\n-----------------------\n";
		static void Main(string[] args)
		{
			IntPtr hwnd = GetDesktopWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(Screen.PrimaryScreen.Bounds.Left, Screen.PrimaryScreen.Bounds.Top, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);

#if ABSTRACT_1
			Rectangle rect = new Rectangle(150, 100, 100, 100, 1, Color.Orange);
			rect.Info(e);
			Console.WriteLine(delimeter);
			Square square = new Square(100, 300, 100, 1, Color.Red);
			square.Info(e);
			Console.WriteLine(delimeter);
			Circle circle = new Circle(50, 450, 100, 1, Color.Yellow);
			circle.Info(e);
			Console.WriteLine(delimeter);
			EquilateralTriangle eTriangle = new EquilateralTriangle(150, 100, 300, 1, Color.Green);
			eTriangle.Info(e);
			Console.WriteLine(delimeter);
			IsoscelesTriangle iTriangle = new IsoscelesTriangle(105, 50, 325, 300, 1, Color.Red);
			iTriangle.Info(e);
			Console.WriteLine(delimeter);
			ScaleneTriangle sTriangle = new ScaleneTriangle(100, 90, 80, 450, 300, 1, Color.White);
			sTriangle.Info(e);
			Console.WriteLine(delimeter);

			while (true)
			{
				rect.Draw(e);
				rect.DrawDiagonal(e);
				square.Draw(e);
				square.DrawDiagonal(e);
				circle.Draw(e);
				eTriangle.Draw(e);
				iTriangle.Draw(e);
				sTriangle.Draw(e);
			}
#endif
			Shape[] shapes =
			{
			new Rectangle(150, 100, 100, 100, 1, Color.Orange),
			new Square(100, 300, 100, 1, Color.Red),
			new Circle(50, 450, 100, 1, Color.Yellow),
			new EquilateralTriangle(150, 100, 300, 1, Color.Green),
			new IsoscelesTriangle(105, 50, 325, 300, 1, Color.Red),
			new ScaleneTriangle(100, 90, 80, 450, 300, 1, Color.White)
			};
			while (true)
			{
				for (int i = 0; i < shapes.Length; ++i)
				{
					if (!(shapes[i] is IHaveDiagonal)) shapes[i].Draw(e);
				}
			}
		}
		[DllImport("user32.dll")]
		public static extern IntPtr GetDesktopWindow();
	}
}
