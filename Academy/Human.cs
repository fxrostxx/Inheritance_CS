using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Human
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public int Age { get; set; }
		public Human(string lastName, string firstName, int age)
		{
			LastName = lastName;
			FirstName = firstName;
			Age = age;
			Console.WriteLine($"HConstructor: {GetHashCode()}");
		}
		public Human(Human other)
		{
			this.LastName = other.LastName;
			this.FirstName = other.FirstName;
			this.Age = other.Age;
			Console.WriteLine($"HCopyConstructor: {GetHashCode()}");
		}
		~Human()
		{
			Console.WriteLine($"HDestructor: {GetHashCode()}");
		}
		public virtual void Info()
		{
			Console.WriteLine($"{LastName} {FirstName} {Age}");
		}
		public override string ToString()
		{
			return $"{base.ToString().Split('.').Last()}:".PadRight(16) + $"{LastName.PadRight(16)} {FirstName.PadRight(16)} {Age.ToString().PadRight(16)}";
		}
		public virtual string ToFileString()
		{
			return $"{this.GetType().ToString().Split('.').Last()}," + $"{LastName},{FirstName},{Age.ToString()}";
		}
	}
}
