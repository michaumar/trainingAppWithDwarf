﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TrainingApp2.Menus.Menu;
using static TrainingApp2.Projects.ProjectManagerLogisticProjects;
using TrainingApp2.Validators;
using TrainingApp2.Projects;

namespace TrainingApp2.Menus
{
    public class LogisticProjectMenu
    {
        ProjectManagerLogisticProjects projects = new ProjectManagerLogisticProjects();
        InputDataValidation inputData = new InputDataValidation();
        BasicEcologicMarketingLogisticValidator basicEcologicMarketingLogisticValidator = new BasicEcologicMarketingLogisticValidator();
        LogisticProjectValidator logisticProjectValidator = new LogisticProjectValidator();
        Menu menu = new Menu();

        int tempProjectSelectMenu;


        public void LogisticProjectMenuSelection()
        {
            while (true)
            {
                tempProjectSelectMenu = menu.DisplayProjectManagerMenu();
                if (tempProjectSelectMenu == (int)ProjectManagerMenuSelections.addProjectSelection)
                {
                    Console.WriteLine("1. Add project");
                    var name = basicEcologicMarketingLogisticValidator.ValidateName();
                    var client = logisticProjectValidator.ValidateClient();
                    var budget = basicEcologicMarketingLogisticValidator.ValidateBudget();
                    var status = basicEcologicMarketingLogisticValidator.ValidateStatus();
                    var costOfSomething = logisticProjectValidator.ValidateCostOfSomething();
                    var startTime = basicEcologicMarketingLogisticValidator.ValidateStartTime();
                    var endTime = basicEcologicMarketingLogisticValidator.ValidateEndTime();
                    var transportCustomerList = logisticProjectValidator.ValidateTransportCustomerList();
                    var allTasksList = logisticProjectValidator.ValidateAllTasksList();

                    while (true)
                    {
                        if (endTime > startTime)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("end time > start time!\n");
                            endTime = basicEcologicMarketingLogisticValidator.ValidateEndTime();
                        }
                    }

                    if (projects.CheckIfLogisticProjectExist(name))
                    {
                        Console.WriteLine("Project will not be saved, because exists!\n");
                    }
                    else
                    {
                        projects.AddLogisticProject(name, client, startTime, endTime, budget, status, costOfSomething, transportCustomerList, allTasksList);
                    }
                }
                else if (tempProjectSelectMenu == (int)ProjectManagerMenuSelections.deleteProjectSelection)
                {
                    Console.WriteLine("2. Delete project");
                    while (true)
                    {
                        if (projects.CheckActualAmountOfLogisticProject() > (int)Limits.limitNumberOfProjects)
                        {
                            Console.WriteLine("To delete project, type name!");
                            var tempName = inputData.GetStringValueFromConsole();
                            var tempNameCheck = projects.CheckIfLogisticProjectExist(tempName);

                            if (tempNameCheck)
                            {
                                projects.RemoveLogisticProject(tempName);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Project does not exist! Try one more time!\n");
                            }
                            projects.DisplayLogisticProjects();
                        }
                        else
                        {
                            Console.WriteLine("Add projects! Nothing to delete!\n");
                            break;
                        }
                    }
                }
                else if (tempProjectSelectMenu == (int)ProjectManagerMenuSelections.displayProjectListSelection)
                {
                    Console.WriteLine("3.Display projects list");
                    projects.DisplayLogisticProjects();
                }
                else if (tempProjectSelectMenu == (int)ProjectManagerMenuSelections.displayProjectListAndSelectMenuSelection)
                {
                    Console.WriteLine("4. Display projects list and display project select menu");
                    projects.DisplayLogisticProjects();
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
