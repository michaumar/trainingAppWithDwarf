using TrainingApp2.Interfaces;

namespace TrainingApp2.Validators
{
    public class BasicValidator: IBasicValidator
    {
        enum Limits
        {
            limitLenghtOfName = 3,
            limitLenghtOfDescription = 5
        }

        InputDataValidation inputData = new InputDataValidation();
        public string ValidateName()
        {
            while (true)
            {
                Console.WriteLine("Type project name");
                var name = inputData.GetStringValueFromConsole();
                if (name.Length >= (int)Limits.limitLenghtOfName)
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
                if (description.Length >= (int)Limits.limitLenghtOfDescription)
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
