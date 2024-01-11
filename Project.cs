using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2
{
    public class Project
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string description;

		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		private DateTime startTime;

		public DateTime StartTime
        {
			get { return startTime; }
			set { startTime = value; }
		}

		private DateTime endTime;

		public DateTime EndTime
        {
			get { return endTime; }
			set 
			{
				//tu będą jakieś warunki typu endTime>startTime i uzupełnianie całego formatu
				if (true)
				{

				}	
				endTime = value; 
			}
		}

		public Project(string name, string description, DateTime startTime, DateTime endTime)
		{
			Name = name;
			Description = description;
			StartTime = startTime;
			EndTime = endTime;
		}


	}
}
