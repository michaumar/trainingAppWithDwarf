using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Interfaces;

namespace TrainingApp2.Validators
{
    public class MarketingProjectValidator : IMarketingProjectValidator
    {
        enum Limits
        {
           limitLenghtOfClient = 1
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
    }
}
