using System;
using System.Collections.Generic;
using System.Linq;

namespace bg
{
	public class User
	{
		public enum Genders {Male, Female};

        public double Weight { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders Gender { get; set; }
        public List<UserProgram> UserPrograms { get; set; } //initialize in constructor instead
        public List<WeighIn> WeighIns { get; set; }

		public User(double weight, DateTime birthdate, string gender)
        {
            this.UserPrograms = new List<UserProgram>();
            this.WeighIns = new List<WeighIn>();
			if (gender == "F")
				this.Gender = Genders.Female;
			else
				this.Gender = Genders.Male;
			this.Weight = weight;
			this.BirthDate = birthdate;
		}

		public int GetUserAge()
        {
			return (int)(DateTime.Now.Year - BirthDate.Year);
		}

		public void AddUserProgram(double riskAmount)
        {
			List<Goal> goals = new List<Goal>();
			Goal myGoal = new Goal(DateTime.Parse("06/1/2014"));
			goals.Add(myGoal);

			UserProgram myProgram = new UserProgram(riskAmount, DateTime.Now, goals);
			UserPrograms.Add(myProgram);
		}

		public void PrintUserPrograms()
        {
			foreach (UserProgram up in UserPrograms){
				Console.WriteLine("Program started on " + up.startDate + " with risk amount " + up.riskAmount);
				up.PrintGoals();
				Console.WriteLine("");
			}
		}

		public void AddWeighIn(double weight)
        {
            //you can do all this in one line, might not even really need a separate method for it
			WeighIns.Add(new WeighIn() { Weight = weight });
		}

		public void PrintWeighIns()
		{
			foreach(WeighIn w in WeighIns)
			{
				Console.WriteLine("You weighed in at " + w.Weight + " on " + w.WeighInDate);
			}
		}

		public WeighIn GetWeighIn(DateTime? someDate = null)
		{
            if (someDate == null)
            {
                someDate = DateTime.Now;
            }
			//Return weigh in closest to, but not exceeding, someDate
            //for now for this to sort correctly i set a default value of DateTime.Now otherwise the LINQ sort will not work with DateTime? type
            //need to maintain list sorted by date (descending). IRL this can probably be done in SQL when we get the list in the first place.
            var orderedWeighIns = WeighIns.OrderByDescending(x => x.WeighInDate ?? DateTime.Now); 
            return orderedWeighIns.FirstOrDefault(b => b.WeighInDate <= someDate); 
		}

		public List<WeighIn> GetWeighIns(DateTime d1, DateTime? d2 = null)
		{
            if (d2 == null)
            {
                d2 = DateTime.Now;
            }
			//Return a list of all weighIns for a user, between dates d1 and d2 (inclusive)
			//Default d2 to DateTime.now
            //this will probably also be done in SQL--not sure what the intended use of these methods is though
            return WeighIns.Where(x => x.WeighInDate >= d1 && x.WeighInDate <= d2).OrderByDescending(x => x.WeighInDate ?? DateTime.Now).ToList();
		}

        //this method belongs here because updating is an action the user would take, and we don't want each user program to have a reference to its user. users own programs, not vice versa. 
        public void Update(UserProgram currentProgram, DateTime? updateDate = null)
        {
            //Method to update this user program based on updateDate (default to DateTime.Now)
            //Checks whether goals are met

            if (updateDate == null)
            {
                updateDate = DateTime.Now;
            }
            else
            {
                //Check to make sure updateDate is after the most recent weigh in for this user
                if (updateDate > WeighIns.Max(x => x.WeighInDate))
                {
                    //logic to depend on what we are doing with this data, not sure atm
                }
            }

        }

	}
}