using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2.Projects
{
    public class EcologicProjectProperties : BasicEcologicMarketingLogisticProperties
    {
		private string organizer;

		public string Organizer
		{
			get { return organizer; }
			set { organizer = value; }
		}

        private List<string> toDoList;

        public List<string> ToDoList
        {
            get { return toDoList; }
            set { toDoList = value; }
        }


        public EcologicProjectProperties(string name, string organizer, DateTime startTime, DateTime endTime, float budget, string status, List<string> toDoList
            //List<string> toDoList = null
            )
        {
            Name = name;
            Organizer = organizer;
            StartTime = startTime;
            EndTime = endTime;
            Budget = budget;
            Status = status;
            ToDoList = toDoList;
            //ToDoList = toDoList ?? new List<string>();

        }



    }
}
