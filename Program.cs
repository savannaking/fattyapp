using System;
using bg;

class Program
{
	public static void Main(String[] args)
	{
		User savanna = new User(135, DateTime.Parse("08/18/1992"), "F");
		savanna.AddUserProgram(100);
		savanna.AddUserProgram(150);
		savanna.PrintUserPrograms();
		savanna.AddWeighIn(200);
		savanna.AddWeighIn(150);
		savanna.PrintWeighIns();
		Console.ReadLine();
	}
}