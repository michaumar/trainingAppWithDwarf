namespace TrainingApp2.Projects
{
    public abstract class BasicEcologicMarketingLogisticProperties
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
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
            set { endTime = value; }
        }

        private float budget;

        public float Budget
        {
            get { return budget; }
            set { budget = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}
