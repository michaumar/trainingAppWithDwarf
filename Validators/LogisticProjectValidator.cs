using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Interfaces;

namespace TrainingApp2.Validators
{
    public class LogisticProjectValidator : BasicEcologicMarketingLogisticValidator, ILogisticProjectValidator
    {
        InputDataValidation inputData = new InputDataValidation();
        enum Limits
        {
            limitLenghtOfOrganizer = 1,
            costOfSomething = 0,
        }
        public List<string> ValidateTransportCustomerList()
        {
            Console.WriteLine("Type transport customer list");

            var toDoList = inputData.GetListValueFromConsole();
            if (toDoList.Any())
            {
                Console.WriteLine("List is OK");
            }
            else
            {
                Console.WriteLine("List is empty");
            }
            return toDoList;
        }
        public List<string> ValidateAllTasksList()
        {
            Console.WriteLine("Type all tasks list");

            var toDoList = inputData.GetListValueFromConsole();
            if (toDoList.Any())
            {
                Console.WriteLine("List is OK");
            }
            else
            {
                Console.WriteLine("List is empty");
            }
            return toDoList;
        }
        public float ValidateCostOfSomething()
        {
            while (true)
            {
                Console.WriteLine("Type cost of something");
                var cost = inputData.GetFloatValueFromConsole();
                if (cost >= (int)Limits.costOfSomething)
                {
                    Console.WriteLine("\nCost of something has to be >= 0! OK\n");
                    return cost;
                }
                else
                {
                    Console.WriteLine("\nCost of something must not < zero!\n");
                }
            }
        }
    }
}
