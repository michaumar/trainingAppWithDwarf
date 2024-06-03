namespace TrainingApp2.Validators
{
    public class FinanceProjectValidator : BasicValidator
    {
        public int limitLenghtOfAuthor = 2;
        public int priceException = 0;

        InputDataValidation inputData = new InputDataValidation();
        public string ValidateAuthor()
        {
            while (true)
            {
                Console.WriteLine("Type author");
                var name = inputData.GetStringValueFromConsole();
                if (name.Length >= limitLenghtOfAuthor)
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
                if (name != priceException)
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

    }
}
