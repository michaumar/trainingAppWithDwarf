namespace TrainingApp2.Validators
{
    public class BasicValidator
    {
        public int limitLenghtOfName = 3;
        public int limitLenghtOfDescription = 5;

        InputDataValidation inputData = new InputDataValidation();
        public string ValidateName()
        {
            while (true)
            {
                Console.WriteLine("Type project name");
                var name = inputData.GetStringValueFromConsole();
                if (name.Length >= limitLenghtOfName)
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
                if (description.Length >= limitLenghtOfDescription)
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
    }
}
