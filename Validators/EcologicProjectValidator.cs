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
                var organizer = inputData.GetStringValueFromConsole();
                if (organizer.Length >= (int)Limits.limitLenghtOfOrganizer)
                {
                    Console.WriteLine("\nOrganizer has correct length!\n");
                    return organizer;
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

            var toDoList = inputData.GetListValueFromConsole();
            if (toDoList.Any())
            {
                Console.WriteLine("List is OK");
                return true;
            }
            else
            {
                Console.WriteLine("List is empty");
                return false;
            }
        }
    }
}
