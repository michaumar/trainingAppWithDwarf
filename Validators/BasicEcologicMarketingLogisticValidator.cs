using TrainingApp2.Interfaces;

namespace TrainingApp2.Validators
{
    public class BasicEcologicMarketingLogisticValidator : IBasicEcologicMarketingLogisticValidator
    {
        enum Limits
        {
            limitLenghtOfName = 3,
            limitLenghtOfClient = 1,
            limitYearOfStartTime = 2020,
            budgetException = 0,
            limitLenghtOfStatus = 2

        }
        InputDataValidation inputData = new InputDataValidation();
        public string ValidateName()
        {
            while (true)
            {
                Console.WriteLine("Type project name");
                var name = inputData.GetStringValueFromConsole();
                if (name.Length >= (int)Limits.limitLenghtOfName)
                {
                    Console.WriteLine("\nName has correct length!\n");
                    return name;
                }
                else
                {
                    Console.WriteLine("\nName must have at least 3 characters!\n");
                }
            }
        }
        public DateTime ValidateStartTime()
        {
            DateTime startTime = new DateTime();
            while (true)
            {
                Console.WriteLine("Type project start time");
                startTime = inputData.GetDateTimeValueFromConsole();
                if (startTime.Year >= (int)Limits.limitYearOfStartTime)
                {
                    Console.WriteLine("\nStart time is OK! \n");
                    return startTime;
                }
                else
                {
                    Console.WriteLine("\nTime of project must be from 2020 onwards!\n");
                }
            }

        }
        public DateTime ValidateEndTime()
        {
            DateTime endTime = new DateTime();
            while (true)
            {
                Console.WriteLine("Type project end time");
                endTime = inputData.GetDateTimeValueFromConsole();
                if (endTime.Year >= (int)Limits.limitYearOfStartTime)
                {
                    Console.WriteLine("\nEnd time is OK!\n");
                    return endTime;
                }
                else
                {
                    Console.WriteLine("\nTime of project must be from 2020 onwards!\n");
                }
            }

        }
        public float ValidateBudget()
        {
            while (true)
            {
                Console.WriteLine("Type Budget");
                var name = inputData.GetFloatValueFromConsole();
                if (name != (int)Limits.budgetException)
                {
                    Console.WriteLine("\nBudget is not zero! OK\n");
                    return name;
                }
                else
                {
                    Console.WriteLine("\nBudget must not be zero!\n");
                }
            }
        }
        public string ValidateStatus()
        {
            while (true)
            {
                Console.WriteLine("Type status");
                var status = inputData.GetStringValueFromConsole();
                if (status.Length >= (int)Limits.limitLenghtOfStatus)
                {
                    Console.WriteLine("\nStatus has correct length!\n");
                    return status;
                }
                else
                {
                    Console.WriteLine("\nStatus must have at least 2 characters!\n");
                }
            }
        }
    }
}
