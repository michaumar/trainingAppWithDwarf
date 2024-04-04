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
                    Console.WriteLine("\nName has correct length!\n");
                    return name;
                }
                else
                {
                    Console.WriteLine("\nName must have at least 3 characters!\n");
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
                    Console.WriteLine("\nDescription has correct length!\n");
                    return description;
                }
                else
                {
                    Console.WriteLine("\nDescription must have at least 5 characters!\n");
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
                if (endTime.Year >= 2020)
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
        public string ValidateAuthor()
        {
            while (true)
            {
                Console.WriteLine("Type author");
                var name = inputData.GetStringValueFromConsole();
                if (name.Length >= 2)
                {
                    Console.WriteLine("\nAuthor has correct length!\n");
                    return name;
                }
                else
                {
                    Console.WriteLine("\nAuthor must have at least 2 characters!\n");
                }
            }
        }
        public float ValidatePrice()
        {
            while (true)
            {
                Console.WriteLine("Type price");
                var name = inputData.GetFloatValueFromConsole();
                if (name != 0)
                {
                    Console.WriteLine("\nPrice is not zero! OK\n");
                    return name;
                }
                else
                {
                    Console.WriteLine("\nPrice must not be zero!\n");
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
