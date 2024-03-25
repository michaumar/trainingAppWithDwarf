using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;
using System.Xml.Linq;
using TrainingApp2;



ProjectManager projects = new ProjectManager();
InputDataValidation inputData = new InputDataValidation();
ProjectValidator projectValidator = new ProjectValidator();
Menu menu = new Menu();
int tempMenuValue;

for (; ; )
{
    tempMenuValue = menu.DisplayMenu();
    if (tempMenuValue == 1)
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

        if (projects.CheckIfProjectExist(name))
        {
            Console.WriteLine("Project will not be saved, because exists!\n");
        }
        else
        {
            projects.AddProject(name, description, startTime, endTime);
        }
    }
    else if (tempMenuValue == 2)
    {
        Console.WriteLine("2. Delete project");
        for (; ; )
        {
            if (projects.CheckActualAmountOfProject() > 0)
            {
                Console.WriteLine("To delete project, type name!");
                var tempName = inputData.GetStringValueFromConsole();
                var tempNameCheck = projects.CheckIfProjectExist(tempName);

                if (tempNameCheck)
                {
                    projects.RemoveProject(tempName);
                    break;
                }
                else
                {
                    Console.WriteLine("Project does not exist! Try one more time!\n");
                }
                projects.DisplayProjects();
            }
            else
            {
                Console.WriteLine("Add projects! Nothing to delete!\n");
                break;
            }
        }
    }
    else if (tempMenuValue == 3)
    {
        Console.WriteLine("3.Display projects list");
        projects.DisplayProjects();
    }
    else if (tempMenuValue == 4)
    {
        Console.WriteLine("4. Display projects and close");
        projects.DisplayProjects();
        break;
    }
    else
    {
        Console.WriteLine("Try one more time, something went wrong!");
    }
}

