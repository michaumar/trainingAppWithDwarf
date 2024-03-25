using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2
{
    public class Menu
    {
        public int DisplayMenu()
        {
            Console.WriteLine("\nAvailable options:\n" +
                              "1. Add project\n" +
                              "2. Delete project\n" +
                              "3. Display projects list\n" +
                              "4. Close and display projects\n"
                              );
            while (true)
            {
                try
                {
                    var optionValue = int.Parse(Console.ReadLine());
                    if (optionValue >= 1 && optionValue <= 4)
                        return optionValue;
                    else
                        throw new ArgumentOutOfRangeException();
                }
                catch
                {
                    Console.WriteLine("Wrong! Choose between 1, 2, 3, 4");
                }
            }

        }
    }
}
