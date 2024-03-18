using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;
using System.Xml.Linq;
using TrainingApp2;

/*
//var date1 = new DateTime(33, 1, 1, 0, 0, 0); //Y, M, D, H, Min, S 
//Console.WriteLine(date1);
//// For en-US culture, displays 3/1/2008 7:00:00 AM


////Project project = new Project("Raf", "Desc", new DateTime(33, 1, 1, 0, 0, 0), new DateTime(32, 1, 1, 0, 0, 0));
////Project project2 = new Project("Raf", "Desc", new DateTime(33, 1, 1, 0, 0, 0), new DateTime(34, 1, 1, 0, 0, 0));

//InputDataValidation getValueFromConsole = new InputDataValidation();
//ProjectManager projectManager = new ProjectManager();


//var name = getValueFromConsole.GetStringValueFromConsole();
//var description = getValueFromConsole.GetStringValueFromConsole();
//var startTime = getValueFromConsole.GetDateTimeValueFromConsole();
//var endTime = getValueFromConsole.GetDateTimeValueFromConsole();


//var dictValue = getValueFromConsole.Parsing(description, startTime, endTime);

//projectManager.AddProject(name, dictValue);
//projectManager.DisplayProjects();


//List<Project> projects = new List<Project>();
//projects.Add(new Project("name", "desc", DateTime.Now, DateTime.Now.AddDays(2)));

//projects.AddProject("masarnia", "boczek opis", DateTime.Now, DateTime.Now.AddDays(2));
//projects.AddProject("sexshop", "dildo opis", DateTime.Now, DateTime.Now.AddDays(3));
*/

ProjectManager projects = new ProjectManager();
InputDataValidation inputData = new InputDataValidation();
ProjectValidator projectValidator = new ProjectValidator();

for (int i = 0; i < 2; i++)
{
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

    projects.DisplayProjects();
}

Console.WriteLine("\nFinal list:");
projects.DisplayProjects();

for (int i = 0; i < 3; i++)
{
    for (; ; )
    {
        if (projects.CheckActualAmountOfProject()>0)
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
    
    projects.DisplayProjects();
}

Console.WriteLine("final");
projects.DisplayProjects();


//Project pro = projects.First();
//Project searchProject = projects.First(project => project.Name == "name");
//Project p = projects.First(project => project.Name == "pro");
//projects.Remove(projects[0]);


//Project project = new Project(name, description, startTime, endTime);
