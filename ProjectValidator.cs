using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2
{
    public class ProjectValidator
    {
        public bool ValidateName(string nameCheck)
        {
            if (nameCheck.Length >= 3) 
            {
                Console.WriteLine("Name has correct length!");
                return true;
            }
            else
            {
                Console.WriteLine("Name must have at least 3 characters!");
                return false;
            }

        }
        public bool ValidateDescription(string descriptionCheck)
        {
            if (descriptionCheck.Length >= 5)
            {
                Console.WriteLine("Name has correct length!");
                return true;
            }
            else
            {
                Console.WriteLine("Name must have at least 3 characters!");
                return false;
            }

        }

        public bool ValidateTime(DateTime timeCheck)
        {
            if (timeCheck.Year >= 2020)
            {
                Console.WriteLine("Time is OK!");
                return true;
            }
            else
            {
                Console.WriteLine("Time of project must be from 2020 onwards!");
                return false;
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
