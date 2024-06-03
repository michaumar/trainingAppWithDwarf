namespace TrainingApp2.Validators
{
    public class ClassicProjectValidator : BasicValidator
    {
        public int limitYearOfStartTime = 2020;

        InputDataValidation inputData = new InputDataValidation();
        public DateTime ValidateStartTime()
        {
            DateTime startTime = new DateTime();
            while (true)
            {
                Console.WriteLine("Type project start time");
                startTime = inputData.GetDateTimeValueFromConsole();
                if (startTime.Year >= limitYearOfStartTime)
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
                if (endTime.Year >= limitYearOfStartTime)
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
    }
}
