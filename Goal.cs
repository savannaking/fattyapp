using System;

namespace bg
{
	public class Goal
	{
        public DateTime GoalDate { get; set; }

		public Goal(DateTime goalDate){
			this.GoalDate = goalDate;
		}
	}
}