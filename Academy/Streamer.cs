using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Streamer
	{
		static readonly string delimeter = "\n-----------------------\n";
		void SetDirectory()
		{
			string location = System.Windows.Forms.Application.ExecutablePath;
			Directory.SetCurrentDirectory($"{location}\\..\\..\\..");
		}
		public void Print(Human[] group)
		{
			for (int i = 0; i < group.Length; ++i)
			{
				Console.WriteLine(group[i]);
				Console.WriteLine(delimeter);
			}
			Console.WriteLine();
		}
		public void Save(Human[] group, string filename)
		{
			SetDirectory();
			StreamWriter sw = new StreamWriter(filename);
			for (int i = 0; i < group.Length; ++i) sw.WriteLine(group[i].ToFileString());
			sw.Close();
			Process.Start("notepad.exe", filename);
		}
		public Human[] Load(string filename)
		{
			SetDirectory();
			List<Human> group = new List<Human>();
			StreamReader sr = new StreamReader(filename);
			try
			{
				while (!sr.EndOfStream)
				{
					string buffer = sr.ReadLine();
					string[] values = buffer.Split(',');
					//Human human = HumanFactory(values[0]);
					//human.Init(values);
					//group.Add(human);
					group.Add(HumanFactory.Create(values[0]).Init(values));
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			sr.Close();
			return group.ToArray();
		}
	}
}
