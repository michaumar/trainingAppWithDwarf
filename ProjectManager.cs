﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2
{
    public class ProjectManager
    {
        List<Project> projectsList = new List<Project>();
        public void AddProject(string name, string description, DateTime startTime, DateTime endTime)
        {
            projectsList.Add(new Project(name, description, startTime, endTime));
        }
        public void RemoveProject(string name)
        {
            Project searchProject = projectsList.First(project => project.Name == name);
            projectsList.Remove(searchProject);
        }

        public bool CheckIfProjectExist(string name)
        {
            Project searchProject = projectsList.FirstOrDefault(project => project.Name == name);
            return projectsList.Contains(searchProject);
        }
        public void DisplayProjects()
        {
            foreach (var project in projectsList)
            {
                Console.WriteLine("Name: {0}, Description: {1}, Start time: {2}, End time: {3}", project.Name, project.Description, project.StartTime, project.EndTime);
            }
        }

        public int CheckActualAmountOfProject()
        {
            return projectsList.Count();
        }


    }
}
