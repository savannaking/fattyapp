using System;

namespace bg{
	public class WeighIn
	{
        //use properties like this instead of writing get/set methods
        public double Weight { get; set; }
        public DateTime? WeighInDate { get; set; }

		public WeighIn(DateTime? weighInDate = null)
		{
			/*Allow a  WeighIn object to be initialized with a specified datetime FOR TESTING. 
			Otherwise weighInDate should be the date the object is created */
			if(weighInDate == null)
				this.weighInDate = DateTime.Now;
            else
				this.weighInDate = weighInDate;
		}

	}
}