using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2
{

    public class ProjectValidator
    {
        InputDataValidation inputData = new InputDataValidation();
        public string ValidateName()
        {
            while (true)
            {
                Console.WriteLine("Type project name");
                var name = inputData.GetStringValueFromConsole();
                if (name.Length >= 3)
                {
                    Console.WriteLine("Name has correct length!");
                    return name;
                }
                else
                {
                    Console.WriteLine("Name must have at least 3 characters!");
                }
            }


        }
        public string ValidateDescription()
        {
            while (true)
            {
                Console.WriteLine("Type project description");
                var description = inputData.GetStringValueFromConsole();
                if (description.Length >= 5)
                {
                    Console.WriteLine("Name has correct length!");
                    return description;
                }
                else
                {
                    Console.WriteLine("Name must have at least 5 characters!");
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
                if (startTime.Year >= 2020)
                {
                    Console.WriteLine("Time is OK!");
                    return startTime;
                }
                else
                {
                    Console.WriteLine("Time of project must be from 2020 onwards!");
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
                if (endTime.Year >= 2020)
                {
                    Console.WriteLine("Time is OK!");
                    return endTime;
                }
                else
                {
                    Console.WriteLine("Time of project must be from 2020 onwards!");
                }
            }

        }

        //public void ValidateProject(bool ValidateName, bool ValidateDescription, bool ValidateTime)
        //{
        //    if (ValidateName & ValidateDescription & ValidateTime)
        //    {
        //        Console.WriteLine("Validation OK!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Validation NOK! Check logs and try one more time!");
        //    }
        //}
    }
}
