using System;
using System.Diagnostics.CodeAnalysis;
using TrainingApp2;

var date1 = new DateTime(33, 1, 1, 0, 0, 0); //Y, M, D, H, Min, S 
Console.WriteLine(date1);
// For en-US culture, displays 3/1/2008 7:00:00 AM


Project project = new Project("Raf", "Desc", new DateTime(33, 1, 1, 0, 0, 0), new DateTime(32, 1, 1, 0, 0, 0));
Project project2 = new Project("Raf", "Desc", new DateTime(33, 1, 1, 0, 0, 0), new DateTime(34, 1, 1, 0, 0, 0));




//Project project = new Project(name, description, startTime, endTime);
