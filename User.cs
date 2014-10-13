using System;
using System.Collections.Generic;

namespace bg
{
	class User
	{
		public enum Genders {Male, Female};

		double weight;
		DateTime birthdate;
		Genders gender;
		List<UserProgram> userPrograms = new List<UserProgram>();
		List<WeighIn> weighIns = new List<WeighIn>();

		public User(double weight, DateTime birthdate, string gender){
			if (gender=="F")
				this.gender = Genders.Female;
			else
				this.gender = Genders.Male;
			this.weight = weight;
			this.birthdate = birthdate;
		}

		public int Age(){
			return (int)(DateTime.Now.Year - birthdate.Year);
		}

		public void AddUserProgram(double riskAmount){
			List<Goal> goals = new List<Goal>();
			Goal myGoal = new Goal(DateTime.Parse("06/1/2014"));
			goals.Add(myGoal);

			UserProgram myProgram = new UserProgram(riskAmount, DateTime.Now, goals);
			userPrograms.Add(myProgram);
		}

		public void PrintUserPrograms(){
			foreach (UserProgram up in userPrograms){
				Console.WriteLine("Program started on " + up.startDate + " with risk amount " + up.riskAmount);
				up.PrintGoals();
				Console.WriteLine("");
			}
		}

		public void AddWeighIn(double weight){
			WeighIn weighIn = new WeighIn();
			weighIn.setWeight(weight);
			weighIns.Add(weighIn);
		}

		public void PrintWeighIns()
		{
			foreach(WeighIn w in weighIns)
			{
				Console.WriteLine("You weighed in at " + w.weight + " on " + w.weighInDate);
			}
		}

		public WeighIn getWeighIn(DateTime? someDate = null)
		{
			//Return weigh in closest to, but not exceeding, someDate

		}

		public List<WeighIn> getWeighIns(DateTime d1, DateTime? d2)
		{
			//Return a list of all weighIns for a user, between dates d1 and d2 (inclusive)
			//Default d2 to DateTime.now

			
		}
	}
}