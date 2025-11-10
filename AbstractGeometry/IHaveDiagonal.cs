using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	internal interface IHaveDiagonal
	{
		double GetDiagonal();
		void DrawDiagonal(System.Windows.Forms.PaintEventArgs e);
	}
}
