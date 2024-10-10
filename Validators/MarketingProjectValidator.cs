using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Interfaces;

namespace TrainingApp2.Validators
{
    public class MarketingProjectValidator : BasicEcologicMarketingLogisticValidator, IMarketingProjectValidator
    {
        enum Limits
        {
           limitLenghtOfClient = 1,
           limitYearOfStartTime = 2020
        }
        InputDataValidation inputData = new InputDataValidation();
        public string ValidateClient()
        {
            while (true)
            {
                Console.WriteLine("Type client name");
                var client = inputData.GetStringValueFromConsole();
                if (client.Length >= (int)Limits.limitLenghtOfClient)
                {
                    Console.WriteLine("\nClient has correct length!\n");
                    return client;
                }
                else
                {
                    Console.WriteLine("\nClient must have at least 1 character!\n");
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
                    Console.WriteLine($"\nTime of project must be from {Limits.limitYearOfStartTime} onwards!\n");
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
                    Console.WriteLine($"\nTime of project must be from {Limits.limitYearOfStartTime} onwards!\n");
                }
            }

        }
    }
}
