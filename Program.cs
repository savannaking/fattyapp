using System;
using bg;

class Program
{
	public static void Main(String[] args)
	{
		User savanna = new User(135, DateTime.Parse("08/18/1992"), "F");
		savanna.AddUserProgram(100);
		savanna.AddUserProgram(150);
		//savanna.PrintUserPrograms();
		savanna.AddWeighIn(200);
		savanna.AddWeighIn(150);
        savanna.WeighIns[1].WeighInDate = DateTime.Now.AddDays(-5); //to make sure we are selecting only the most recent one with GetWeighIn()
		savanna.PrintWeighIns();

        //testing new user methods
        var test = savanna.GetWeighIn(DateTime.Now);
        //Console.WriteLine(test.WeighInDate + " " + test.Weight);
        var weighins = savanna.GetWeighIns(DateTime.Now.AddDays(-6));
        foreach (var weighIn in weighins)
        {
            Console.WriteLine(weighIn.WeighInDate);
        }
		Console.ReadLine();
	}
}