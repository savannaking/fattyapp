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
			//Need to check to make sure goals is not empty?
		}

		public void PrintGoals()
		{
			foreach(Goal g in goals){
				Console.WriteLine("Goal on " + g.goalDate);
			}
		}

		public void Update(DateTime? updateDate = null)
		{
			//Method to update this user program based on updateDate (default to DateTime.Now)
			//Checks whether goals are met

			if(updateDate == null){
				updateDate = DateTime.Now;
			} else{
				//Check to make sure updateDate is after the most recent weigh in for this user
			}

		}

		public Goal nextGoal(DateTime? someDate = null){
			//Returns the next goal (regardless of whether it is active)  (How are boundaries handled??)
			//Returns null if none exists

		}

		public double AmountElligible(DateTime? someDate = null){
			//Returns the amount of money still elligible to be earned as of someDate (How are boundaries handled??)

		}

		public double AmountEarned(){
			//Returns the amount of money earned thus far

		}
	}
}