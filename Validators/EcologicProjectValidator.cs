using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Interfaces;

namespace TrainingApp2.Validators
{
    public class EcologicProjectValidator : BasicEcologicMarketingLogisticValidator, IEcologicProjectValidator
    {
        enum Limits
        {
            limitLenghtOfOrganizer = 1,
        }

        InputDataValidation inputData = new InputDataValidation();
        public string ValidateOrganizer()
        {
            while (true)
            {
                Console.WriteLine("Type organizer");
                var status = inputData.GetStringValueFromConsole();
                if (status.Length >= (int)Limits.limitLenghtOfOrganizer)
                {
                    Console.WriteLine("\nOrganizer has correct length!\n");
                    return status;
                }
                else
                {
                    Console.WriteLine("\nOrganizer must have at least 2 characters!\n");
                }
            }
        }

        public bool ValidateToDoList()
        {
            Console.WriteLine("Type to do list");
            //get list from console no i potem validacja
            return false;
        }
    }
}
