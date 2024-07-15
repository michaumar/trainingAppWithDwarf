using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Projects;


namespace TrainingApp2
{
    public class ProjectManagerClassicProjects: ProjectManagerBasicProjects
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
        public void DisplayClassicProjects()
        {
            foreach (var project in classicProjectsList)
            {
                Console.WriteLine("Name: {0}, Description: {1}, Start time: {2}, End time: {3}", project.Name, project.Description, project.StartTime, project.EndTime);
            }
        }


    }
}
