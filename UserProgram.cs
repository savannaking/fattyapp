using System;
using System.Collections.Generic;

namespace bg
{
	public class UserProgram
	{
        public double RiskAmount { get; set; }
        public DateTime StartDate { get; set; }
        public List<Goal> Goals { get; set; }

		public UserProgram(double riskAmount, DateTime startDate, List<Goal> goals)
		{
            Goals = new List<Goal>();
			this.RiskAmount = riskAmount;
			this.StartDate = startDate;
			this.Goals = goals;
			//Need to check to make sure goals is not empty? 
		}

		public void PrintGoals()
		{
			foreach(Goal g in Goals){
				Console.WriteLine("Goal on " + g.GoalDate);
			}
		}

        public Goal NextGoal(DateTime? someDate = null)
        {
            //Returns the next goal (regardless of whether it is active)  (How are boundaries handled??)
            //Returns null if none exists

            //if there is a "next goal" should there also be a current goal? how do we know which is current?
        }

        public double AmountEligible(DateTime? someDate = null)
        {
            //Returns the amount of money still elligible to be earned as of someDate (How are boundaries handled??)
        }

        public double AmountEarned()
        {
            //Returns the amount of money earned thus far
        }
	}
}