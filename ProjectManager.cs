using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Projects;

namespace TrainingApp2
{
    public class ProjectManager
    {
        public int limitNumberOfProjects = 0;
        List<ClassicProjectProperties> classicProjectsList = new List<ClassicProjectProperties>();
        List<FinanceProjectProperties> financeProjectsList = new List<FinanceProjectProperties>();
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

        public void AddFinanceProject(string name, string description, float price, string author)
        {
            financeProjectsList.Add(new FinanceProjectProperties(name, description, price, author));
        }
        public void RemoveFinanceProject(string name)
        {
            FinanceProjectProperties searchProject = financeProjectsList.First(project => project.Name == name);
            financeProjectsList.Remove(searchProject);
        }
        public bool CheckIfFinanceProjectExist(string name)
        {
            FinanceProjectProperties searchProject = financeProjectsList.FirstOrDefault(project => project.Name == name);
            return financeProjectsList.Contains(searchProject);
        }
        public void DisplayFinanceProjects()
        {
            foreach (var project in financeProjectsList)
            {
                Console.WriteLine("Name: {0}, Description: {1}, Price: {2}, Author: {3}", project.Name, project.Description, project.Price, project.Author);
            }
        }
        public int CheckActualAmountOfFinanceProject()
        {
            return financeProjectsList.Count();
        }

    }
}
