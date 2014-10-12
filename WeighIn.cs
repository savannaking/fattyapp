using System;

namespace bg{
	class WeighIn
	{
		public double weight;
		public DateTime? weighInDate;

		public WeighIn(DateTime? weighInDate = null)
		{
			/*Allow a  WeighIn object to be initialized with a specified datetime FOR TESTING. 
			Otherwise weighInDate should be the date the object is created */
			if(weighInDate == null){
				this.weighInDate = DateTime.Now;
			} else{
				this.weighInDate = weighInDate;
			}
		}

		public void setWeight(double weight)
		{
			this.weight = weight;
		}
	}
}