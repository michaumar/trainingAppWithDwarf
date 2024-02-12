using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;
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

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Type project name");
    var name = inputData.GetStringValueFromConsole();
    Console.WriteLine("Type project description");
    var description = inputData.GetStringValueFromConsole();
    Console.WriteLine("Type project start time");
    var startTime = inputData.GetDateTimeValueFromConsole();

    DateTime endTime = new DateTime();

    for (; ; )
    {
        Console.WriteLine("Type project end time");
        endTime = inputData.GetDateTimeValueFromConsole();
        if (endTime > startTime)
        {
            break;
        }
        else
        {
            Console.WriteLine("end time > start time!");
        }
    }

    projects.AddProject(name, description, startTime, endTime);
}

//zabezpieczenie przed tą samą nazwą projektu? opcja nadpisywania czy coś?

projects.DisplayProjects();

//zabezpiczenie przez usuwaniem wszystkiego, chociaż teoretycznie można usunąć wszystkie projekty -_-

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("delete project, type name");
    projects.RemoveProject(inputData.GetStringValueFromConsole());
    projects.DisplayProjects();
}

Console.WriteLine("final");
projects.DisplayProjects();


//Project pro = projects.First();
//Project searchProject = projects.First(project => project.Name == "name");
//Project p = projects.First(project => project.Name == "pro");
//projects.Remove(projects[0]);


//Project project = new Project(name, description, startTime, endTime);
