using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2
{
    public class Project
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                for (; ; )
                {
                    try
                    {
                        name = value;
                        break;
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("String required!"); ;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Bad things occured :/ - {e.Message}");
                    }
                }
            }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set
            {
                for (; ; )
                {
                    try
                    {
                        description = value;
                        break;
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("String required!"); ;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Bad things occured :/ - {e.Message}");
                    }
                }
            }
        }

        private DateTime startTime;

        public DateTime StartTime
        {
            get { return startTime; }
            set
            {
                for (; ; )
                {
                    try
                    {
                        startTime = value;
                        break;
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("DateTime required!"); ;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Bad things occured :/ - {e.Message}");
                    }
                }
            }
        }

        private DateTime endTime;

        public DateTime EndTime
        {
            get { return endTime; }
            set
            {
                for (; ; )
                {
                    try
                    {
                        if (value > startTime)
                        {
                            endTime = value;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Check input data");
                        }
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("DateTime required!"); ;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Bad things occured :/ - {e.Message}");
                    }
                }
            }
        }

        public Project(string name, string description, DateTime startTime, DateTime endTime)
        {
            Name = name;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
