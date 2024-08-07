﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2.Menus
{
    public class Menu
    {
        public enum ProjectManagerMenuSelections
        {
            addProjectSelection = 1,
            deleteProjectSelection,
            displayProjectListSelection,
            displayProjectListAndSelectMenuSelection
        }

        public enum ProjectSelectMenuSelections
        {
            classicProjectSelection = 1,
            financeProjectSelection,
            closeProjectSelection
        }

        public int DisplayProjectManagerMenu()
        {
            Console.WriteLine("\nAvailable options:\n" +
                              "1. Add project\n" +
                              "2. Delete project\n" +
                              "3. Display projects list\n" +
                              "4. Display projects list and display project select menu\n"

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

        public int DisplayProjectSelectMenu()
        {
            Console.WriteLine("\nAvailable options:\n" +
                              "1. Classic project\n" +
                              "2. Finance project\n" +
                              "3. Close\n"

                              );
            while (true)
            {
                try
                {
                    var optionValue = int.Parse(Console.ReadLine());
                    if (optionValue >= 1 && optionValue <= 3)
                        return optionValue;
                    else
                        throw new ArgumentOutOfRangeException();
                }
                catch
                {
                    Console.WriteLine("Wrong! Choose between 1, 2, 3");
                }
            }

        }
    }
}
