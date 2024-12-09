namespace TrainingApp2.Interfaces
{
    internal interface IBasicEcologicMarketingLogisticValidator
    {
        public string ValidateName();
        public DateTime ValidateStartTime();
        public DateTime ValidateEndTime();
        public float ValidateBudget();
        public string ValidateStatus();
        public string ValidateClient();
    }
}
