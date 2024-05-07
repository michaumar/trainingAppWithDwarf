using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;
using System.Xml.Linq;
using TrainingApp2;

ProjectManager projects = new ProjectManager();
InputDataValidation inputData = new InputDataValidation();
ProjectValidator projectValidator = new ProjectValidator();

Menu menu = new Menu();
int tempManagerMenuValue;
int tempProjectSelectMenu;

for (; ; )
{
    tempProjectSelectMenu = menu.DisplayProjectSelectMenu();
    if (tempProjectSelectMenu == menu.classicProjectSelection)
    {
        for(; ; )
        {
            tempManagerMenuValue = menu.DisplayProjectManagerMenu();
            if (tempManagerMenuValue == menu.addProjectSelection)
            {
                Console.WriteLine("1. Add project");
                var name = projectValidator.ValidateName();
                var description = projectValidator.ValidateDescription();
                var startTime = projectValidator.ValidateStartTime();
                var endTime = projectValidator.ValidateEndTime();

                for (; ; )
                {
                    if (endTime > startTime)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("end time > start time!\n");
                        endTime = projectValidator.ValidateEndTime();
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
            else if (tempManagerMenuValue == menu.deleteProjectSelection)
            {
                Console.WriteLine("2. Delete project");
                for (; ; )
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
            else if (tempManagerMenuValue == menu.displayProjectListSelection)
            {
                Console.WriteLine("3.Display projects list");
                projects.DisplayClassicProjects();
            }
            else if (tempManagerMenuValue == menu.displayProjectListAndSelectMenuSelection)
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
    else if (tempProjectSelectMenu == menu.financeProjectSelection)
    {
        for (; ; )
        {
            tempManagerMenuValue = menu.DisplayProjectManagerMenu();
            if (tempManagerMenuValue == menu.addProjectSelection)
            {
                Console.WriteLine("1. Add project");
                var name = projectValidator.ValidateName();
                var description = projectValidator.ValidateDescription();
                var price = projectValidator.ValidatePrice();
                var author = projectValidator.ValidateAuthor();


                if (projects.CheckIfFinanceProjectExist(name))
                {
                    Console.WriteLine("Project will not be saved, because exists!\n");
                }
                else
                {
                    projects.AddFinanceProject(name, description, price, author);
                }
            }
            else if (tempManagerMenuValue == menu.deleteProjectSelection)
            {
                Console.WriteLine("2. Delete project");
                for (; ; )
                {
                    if (projects.CheckActualAmountOfFinanceProject() > projects.limitNumberOfProjects)
                    {
                        Console.WriteLine("To delete project, type name!");
                        var tempName = inputData.GetStringValueFromConsole();
                        var tempNameCheck = projects.CheckIfFinanceProjectExist(tempName);

                        if (tempNameCheck)
                        {
                            projects.RemoveFinanceProject(tempName);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Project does not exist! Try one more time!\n");
                        }
                        projects.DisplayFinanceProjects();
                    }
                    else
                    {
                        Console.WriteLine("Add projects! Nothing to delete!\n");
                        break;
                    }
                }
            }
            else if (tempManagerMenuValue == menu.displayProjectListSelection)
            {
                Console.WriteLine("3.Display projects list");
                projects.DisplayFinanceProjects();
            }
            else if (tempManagerMenuValue == menu.displayProjectListAndSelectMenuSelection)
            {
                Console.WriteLine("4. Display projects list and display project select menu");
                projects.DisplayFinanceProjects();
                break;
            }
            else
            {
                Console.WriteLine("Try one more time, something went wrong!");
            }
        }
    }
    else if (tempProjectSelectMenu == menu.closeProjectSelection)
    {
        break;
    }
}

