﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2
{
    public class InputDataValidation
    {
        public string GetStringValueFromConsole()
        {
            for(; ; )
            {
                try
                {
                    return Console.ReadLine();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("String argument needed!");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Something bad occured - {e.Message}!");
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
                        " f.e. DateTime(2010, 8, 18, 16, 32, 0) displays 8/18/2010 4:32:00 PM");
                    return DateTime.Parse(Console.ReadLine());
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("DateTime argument needed!");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Something bad occured - {e.Message}!");
                }
            }
        }
    }
}
