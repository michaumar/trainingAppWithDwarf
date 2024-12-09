using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2.Projects
{
    public class LogisticProjectProperties : BasicEcologicMarketingLogisticProperties
    {
        private List<string> transportCustomerList;

        public List<string> TransportCustomerList
        {
            get { return transportCustomerList; }
            set { transportCustomerList = value; }
        }

        private List<string> allTasksList;

        public List<string> AllTasksList
        {
            get { return allTasksList; }
            set { allTasksList = value; }
        }

        private float costOfSomething;

        public float CostOfSomething
        {
            get { return costOfSomething; }
            set { costOfSomething = value; }
        }

        private string client;

        public string Client
        {
            get { return client; }
            set { client = value; }
        }

        public LogisticProjectProperties(string name, string client, DateTime startTime, DateTime endTime,
            float budget, string status, 
            float costOfSomething, 
            List<string> transportCustomerList = null, List<string> allTasksList = null)
        {
            Name = name;
            Client = client;
            StartTime = startTime;
            EndTime = endTime;
            Budget = budget;
            Status = status;
            CostOfSomething = costOfSomething;
            TransportCustomerList = transportCustomerList ?? new List<string>();
            AllTasksList = allTasksList ?? new List<string>();

        }
    }
}
