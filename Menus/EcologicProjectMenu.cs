using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Interfaces;
using TrainingApp2.Projects;
using TrainingApp2.Validators;
using static TrainingApp2.Menus.Menu;
using static TrainingApp2.Projects.ProjectManagerEcologicProjects;
using TrainingApp2.Projects;

namespace TrainingApp2.Menus
{
    public class EcologicProjectMenu
    {
        ProjectManagerEcologicProjects projects = new ProjectManagerEcologicProjects();
        InputDataValidation inputData = new InputDataValidation();
        BasicEcologicMarketingLogisticValidator basicEcologicMarketingLogisticValidator = new BasicEcologicMarketingLogisticValidator();
        EcologicProjectValidator ecologicProjectValidator = new EcologicProjectValidator();
        Menu menu = new Menu();

        int tempProjectSelectMenu;

        public void EcologicProjectMenuSelection()
        {
            while (true)
            {
                tempProjectSelectMenu = menu.DisplayProjectManagerMenu();
                if (tempProjectSelectMenu == (int)ProjectManagerMenuSelections.addProjectSelection)
                {
                    Console.WriteLine("1. Add project");
                    var name = basicEcologicMarketingLogisticValidator.ValidateName();
                    var organizer = ecologicProjectValidator.ValidateOrganizer();
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

                    var toDoList = ecologicProjectValidator.ValidateToDoList();



                    if (projects.CheckIfEcologicProjectExist(name))
                    {
                        Console.WriteLine("Project will not be saved, because exists!\n");
                    }
                    else
                    {
                        projects.AddEcologicProject(name, organizer, startTime, endTime, budget, status, toDoList);
                    }
                }
                else if (tempProjectSelectMenu == (int)ProjectManagerMenuSelections.deleteProjectSelection)
                {
                    Console.WriteLine("2. Delete project");
                    while (true)
                    {
                        if (projects.CheckActualAmountOfEcologicProject() > (int)Limits.limitNumberOfProjects)
                        {
                            Console.WriteLine("To delete project, type name!");
                            var tempName = inputData.GetStringValueFromConsole();
                            var tempNameCheck = projects.CheckIfEcologicProjectExist(tempName);

                            if (tempNameCheck)
                            {
                                projects.RemoveEcologicProject(tempName);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Project does not exist! Try one more time!\n");
                            }
                            projects.DisplayEcologicProjects();
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
                    projects.DisplayEcologicProjects();
                }
                else if (tempProjectSelectMenu == (int)ProjectManagerMenuSelections.displayProjectListAndSelectMenuSelection)
                {
                    Console.WriteLine("4. Display projects list and display project select menu");
                    projects.DisplayEcologicProjects();
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
