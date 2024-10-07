using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TrainingApp2.Menus.Menu;
using TrainingApp2.Validators;

namespace TrainingApp2.Menus
{
    public class MarketingProjectMenu
    {
        ProjectManagerMarketingProjects projects = new ProjectManagerMarketingProjects();
        InputDataValidation inputData = new InputDataValidation();
        BasicEcologicMarketingLogisticValidator basicEcologicMarketingLogisticValidator = new BasicEcologicMarketingLogisticValidator();
        MarketingProjectValidator MarketingProjectValidator = new MarketingProjectValidator();
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
                    var name = basicValidator.ValidateName();
                    var description = basicValidator.ValidateDescription();
                    var price = financeProjectValidator.ValidatePrice();
                    var author = financeProjectValidator.ValidateAuthor();


                    if (projects.CheckIfFinanceProjectExist(name))
                    {
                        Console.WriteLine("Project will not be saved, because exists!\n");
                    }
                    else
                    {
                        projects.AddFinanceProject(name, description, price, author);
                    }
                }
                else if (tempProjectSelectMenu == (int)ProjectManagerMenuSelections.deleteProjectSelection)
                {
                    Console.WriteLine("2. Delete project");
                    while (true)
                    {
                        if (projects.CheckActualAmountOfFinanceProject() > (int)Limits.limitNumberOfProjects)
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
                else if (tempProjectSelectMenu == (int)ProjectManagerMenuSelections.displayProjectListSelection)
                {
                    Console.WriteLine("3.Display projects list");
                    projects.DisplayFinanceProjects();
                }
                else if (tempProjectSelectMenu == (int)ProjectManagerMenuSelections.displayProjectListAndSelectMenuSelection)
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

    }
}
