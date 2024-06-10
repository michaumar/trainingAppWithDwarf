﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Validators;

namespace TrainingApp2.Menus
{
    public class ClassicProjectMenu
    {
        ProjectManager projects = new ProjectManager();
        InputDataValidation inputData = new InputDataValidation();
        BasicValidator basicValidator = new BasicValidator();
        ClassicProjectValidator classicProjectValidator = new ClassicProjectValidator();
        Menu menu = new Menu();

        int tempProjectSelectMenu;
        public void ClassicProjectMenuSelection()
        {
            while (true)
            {
                tempProjectSelectMenu = menu.DisplayProjectManagerMenu();
                if (tempProjectSelectMenu == menu.addProjectSelection)
                {
                    Console.WriteLine("1. Add project");
                    var name = basicValidator.ValidateName();
                    var description = basicValidator.ValidateDescription();
                    var startTime = classicProjectValidator.ValidateStartTime();
                    var endTime = classicProjectValidator.ValidateEndTime();

                    while (true)
                    {
                        if (endTime > startTime)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("end time > start time!\n");
                            endTime = classicProjectValidator.ValidateEndTime();
                        }
                    }

                    if (projects.CheckIfClassicProjectExist(name))
                    {
                        Console.WriteLine("Project will not be saved, because exists!\n");
                    }
                    else
                    {
                        projects.AddClassicProject(name, description, startTime, endTime);
                    }
                }
                else if (tempProjectSelectMenu == menu.deleteProjectSelection)
                {
                    Console.WriteLine("2. Delete project");
                    while (true)
                    {
                        if (projects.CheckActualAmountOfClassicProject() > projects.limitNumberOfProjects)
                        {
                            Console.WriteLine("To delete project, type name!");
                            var tempName = inputData.GetStringValueFromConsole();
                            var tempNameCheck = projects.CheckIfClassicProjectExist(tempName);

                            if (tempNameCheck)
                            {
                                projects.RemoveClassicProject(tempName);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Project does not exist! Try one more time!\n");
                            }
                            projects.DisplayClassicProjects();
                        }
                        else
                        {
                            Console.WriteLine("Add projects! Nothing to delete!\n");
                            break;
                        }
                    }
                }
                else if (tempProjectSelectMenu == menu.displayProjectListSelection)
                {
                    Console.WriteLine("3.Display projects list");
                    projects.DisplayClassicProjects();
                }
                else if (tempProjectSelectMenu == menu.displayProjectListAndSelectMenuSelection)
                {
                    Console.WriteLine("4. Display projects list and display project select menu");
                    projects.DisplayClassicProjects();
                    break;
                }
                else
                {
                    Console.WriteLine("Try one more time, something went wrong!");
                }

            }

        }

    }
}