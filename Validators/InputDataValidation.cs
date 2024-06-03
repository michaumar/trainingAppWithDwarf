using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2.Validators
{
    public class InputDataValidation
    {
        public string GetStringValueFromConsole()
        {
            for (; ; )
            {
                try
                {
                    return Console.ReadLine();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("String argument needed! \n");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Something bad occured - {e.Message}! Try one more time! \n");
                }
            }
        }
        public DateTime GetDateTimeValueFromConsole()
        {
            for (; ; )
            {
                try
                {
                    Console.WriteLine("DateTime format - (int year, int month, int day, int hour, int minute, int second)" +
                        " f.e. DateTime(2010, 8, 18, 16, 32, 0), type 2010/8/18 16:32:00 to display 8/18/2010 4:32:00 PM");
                    return DateTime.Parse(Console.ReadLine());
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("DateTime argument needed! \n");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Something bad occured - {e.Message}! Try one more time! \n");
                }
            }
        }
        public float GetFloatValueFromConsole()
        {
            for (; ; )
            {
                try
                {
                    return float.Parse(Console.ReadLine());
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Float argument needed! \n");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Something bad occured - {e.Message}! Try one more time! \n");
                }
            }
        }

    }
}
