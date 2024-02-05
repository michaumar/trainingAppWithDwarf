using System;
using System.Diagnostics.CodeAnalysis;
using TrainingApp2;

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

ProjectManager projects = new ProjectManager();
InputDataValidation inputData = new InputDataValidation();

//projects.AddProject("masarnia", "boczek opis", DateTime.Now, DateTime.Now.AddDays(2));
//projects.AddProject("sexshop", "dildo opis", DateTime.Now, DateTime.Now.AddDays(3));
for (int i = 0; i < 2; i++)
{
    Console.WriteLine("name");
    var name = inputData.GetStringValueFromConsole();
    Console.WriteLine("desc");
    var description = inputData.GetStringValueFromConsole();
    Console.WriteLine("stime");
    var startTime = inputData.GetDateTimeValueFromConsole();
    Console.WriteLine("etime");
    var endTime = inputData.GetDateTimeValueFromConsole();
    //wrr to nie działa tak jak powinno, jak wpiszemy zły etime to wywala tylko błąd, jakoś cza to ogarnąć, pętla w properties nie bangla,
    //no i jak się zły wpisze w kolejnym powtórzeniu to bierze endTime z poprzedniego -_-
    projects.AddProject(name, description, startTime, endTime);
}


projects.DisplayProjects();

Console.WriteLine("dupa");

//Project pro = projects.First();
//Project searchProject = projects.First(project => project.Name == "name");
//Project p = projects.First(project => project.Name == "pro");
//projects.Remove(projects[0]);









//Project project = new Project(name, description, startTime, endTime);
