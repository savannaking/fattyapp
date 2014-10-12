using System;
using System.Collections.Generic;

namespace bg
{
	class UserProgram
	{
		public double riskAmount;
		public DateTime startDate;
		public List<Goal> goals = new List<Goal>();

		public UserProgram(double riskAmount, DateTime startDate, List<Goal> goals)
		{
			this.riskAmount = riskAmount;
			this.startDate = startDate;
			this.goals = goals;
		}

		public void PrintGoals(){
			foreach(Goal g in goals){
				Console.WriteLine("Goal on " + g.goalDate);
			}
		}
	}
}