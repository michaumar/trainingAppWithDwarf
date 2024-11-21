using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TrainingApp2.Menus.Menu;
using static TrainingApp2.Projects.ProjectManagerMarketingProjects;
using TrainingApp2.Validators;
using TrainingApp2.Projects;
using TrainingApp2.Interfaces;

namespace TrainingApp2.Menus
{
    public class MarketingProjectMenu
    {
        ProjectManagerMarketingProjects projects = new ProjectManagerMarketingProjects();
        InputDataValidation inputData = new InputDataValidation();
        BasicEcologicMarketingLogisticValidator basicEcologicMarketingLogisticValidator = new BasicEcologicMarketingLogisticValidator();
        Menu menu = new Menu();

        int tempProjectSelectMenu;
        public void MarketingProjectMenuSelection()
        {
            while (true)
            {
                tempProjectSelectMenu = menu.DisplayProjectManagerMenu();
                if (tempProjectSelectMenu == (int)ProjectManagerMenuSelections.addProjectSelection)
                {
                    Console.WriteLine("1. Add project");
                    var name = basicEcologicMarketingLogisticValidator.ValidateName();
                    var client = basicEcologicMarketingLogisticValidator.ValidateClient();
                    var budget = basicEcologicMarketingLogisticValidator.ValidateBudget();
                    var status = basicEcologicMarketingLogisticValidator.ValidateStatus();
                    var startTime = basicEcologicMarketingLogisticValidator.ValidateStartTime();
                    var endTime = basicEcologicMarketingLogisticValidator.ValidateEndTime();

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

                    if (projects.CheckIfMarketingProjectExist(name))
                    {
                        Console.WriteLine("Project will not be saved, because exists!\n");
                    }
                    else
                    {
                        projects.AddMarketingProject(name, client, startTime, endTime, budget, status);
                    }
                }
                else if (tempProjectSelectMenu == (int)ProjectManagerMenuSelections.deleteProjectSelection)
                {
                    Console.WriteLine("2. Delete project");
                    while (true)
                    {
                        if (projects.CheckActualAmountOfMarketingProject() > (int)Limits.limitNumberOfProjects)
                        {
                            Console.WriteLine("To delete project, type name!");
                            var tempName = inputData.GetStringValueFromConsole();
                            var tempNameCheck = projects.CheckIfMarketingProjectExist(tempName);

                            if (tempNameCheck)
                            {
                                projects.RemoveMarketingProject(tempName);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Project does not exist! Try one more time!\n");
                            }
                            projects.DisplayMarketingProjects();
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
                    projects.DisplayMarketingProjects();
                }
                else if (tempProjectSelectMenu == (int)ProjectManagerMenuSelections.displayProjectListAndSelectMenuSelection)
                {
                    Console.WriteLine("4. Display projects list and display project select menu");
                    projects.DisplayMarketingProjects();
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
