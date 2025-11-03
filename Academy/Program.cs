//#define INHERITANCE_1
//#define INHERITANCE_2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Program
	{
		static readonly string delimeter = "\n-----------------------\n";
		static void Main(string[] args)
		{
#if INHERITANCE_1
			Human human = new Human("Montano", "Antonio", 25);
			human.Info();
			Console.WriteLine(delimeter);
			Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 90, 95);
			student.Info();
			Console.WriteLine(delimeter);
			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			teacher.Info();
			Console.WriteLine(delimeter); 
#endif
#if INHERITANCE_2
			Human human = new Human("Pinkman", "Jessie", 22);
			human.Info();
			Console.WriteLine(delimeter);
			Student student = new Student(human, "Chemistry", "WW_240", 90, 95);
			student.Info();
			Console.WriteLine(delimeter);
			Teacher teacher = new Teacher(new Human("White", "Walter", 50), "Chemistry", 25);
			teacher.Info();
			Console.WriteLine(delimeter);
			Human h_hank = new Human("Schreder", "Hank", 40);
			Student s_hank = new Student(h_hank, "Criminalistic", "OBN", 50, 60);
			Graduate graduate = new Graduate(s_hank, "How to catch Heisenberg");
			graduate.Info();
			Console.WriteLine(delimeter);
#endif
			Human[] group =
			{
				new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 90, 95),
				new Teacher("White", "Walter", 50, "Chemistry", 25),
				new Graduate("Schreder", "Hank", 40, "Criminalistic", "OBN", 50, 60, "How to catch Heisenberg"),
				new Student("Verchetty", "Tommy", 30, "Theft", "Vice", 98, 99),
				new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20),
				new Teacher("Schwarzenegger", "Arnold", 78, "Heavy metal", 65)
			};
			for (int i = 0; i < group.Length; ++i)
			{
				//group[i].Info();
				Console.WriteLine(group[i].ToString());
				Console.WriteLine(delimeter);
			}
		}
	}
}
