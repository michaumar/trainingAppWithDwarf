using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Interfaces;


namespace TrainingApp2.Projects
{
    public class ProjectManagerClassicProjects : IProjectManagerClassicProjects
    {
        public enum Limits
        {
            limitNumberOfProjects = 0
        }

        List<ClassicProjectProperties> classicProjectsList = new List<ClassicProjectProperties>();
        public void AddClassicProject(string name, string description, DateTime startTime, DateTime endTime)
        {
            classicProjectsList.Add(new ClassicProjectProperties(name, description, startTime, endTime));
        }
        public void RemoveClassicProject(string name)
        {
            ClassicProjectProperties searchProject = classicProjectsList.First(project => project.Name == name);
            classicProjectsList.Remove(searchProject);
        }
        public bool CheckIfClassicProjectExist(string name)
        {
            ClassicProjectProperties searchProject = classicProjectsList.FirstOrDefault(project => project.Name == name);
            return classicProjectsList.Contains(searchProject);
        }
        public void DisplayClassicProjects()
        {
            foreach (var project in classicProjectsList)
            {
                Console.WriteLine("Name: {0}, Description: {1}, Start time: {2}, End time: {3}", project.Name, project.Description, project.StartTime, project.EndTime);
            }
        }
        public int CheckActualAmountOfClassicProject()
        {
            return classicProjectsList.Count();
        }


    }
}
