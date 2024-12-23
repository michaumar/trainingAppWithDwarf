﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Interfaces;

namespace TrainingApp2.Projects
{
    public class ProjectManagerEcologicProjects: IProjectManagerEcologicProjects
    {
        //nejm, organizator, data początkowa, data end, budżet, status, jako lista akcje do wykonania
        public enum Limits
        {
            limitNumberOfProjects = 0
        }

        List<EcologicProjectProperties> ecologicProjectList = new List<EcologicProjectProperties>();
        public void AddEcologicProject(string name, string organizer, DateTime startTime, DateTime endTime, float budget, string status, List<string> toDoList)
        {
            ecologicProjectList.Add(new EcologicProjectProperties(name, organizer, startTime, endTime, budget, status, toDoList));
        }
        public void RemoveEcologicProject(string name)
        {
            EcologicProjectProperties searchProject = ecologicProjectList.First(project => project.Name == name);
            ecologicProjectList.Remove(searchProject);
        }
        public bool CheckIfEcologicProjectExist(string name)
        {
            EcologicProjectProperties searchProject = ecologicProjectList.FirstOrDefault(project => project.Name == name);
            return ecologicProjectList.Contains(searchProject);
        }
        public void DisplayEcologicProjects()
        {
            foreach (var project in ecologicProjectList)
            {
                //string toDoList = string.Join(", ", project.ToDoList);
                string toDoList = string.Join(", ", project.ToDoList.Select((task, index) => $"{index + 1}. {task}"));
                Console.WriteLine("Name: {0}, Organizer: {1}, Start time: {2}, End time: {3}, Budget: {4:C}, Status: {5}, ToDoList: {6}", project.Name, project.Organizer, project.StartTime, project.EndTime, project.Budget, project.Status, toDoList);
            }
        }
        public int CheckActualAmountOfEcologicProject()
        {
            return ecologicProjectList.Count();
        }


    }
}
