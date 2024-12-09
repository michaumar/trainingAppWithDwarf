using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2.Projects
{
    public class MarketingProjectProperties : BasicEcologicMarketingLogisticProperties
    {
		private string client;

		public string Client
		{
			get { return client; }
			set { client = value; }
		}

		public MarketingProjectProperties(string name, string client, DateTime startTime, DateTime endTime, float budget, string status) 
		{
			Name = name;
			Client = client;
			StartTime = startTime;
			EndTime = endTime;
			Budget = budget;
			Status = status;
		
		}

	}
}
