using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Interfaces;


namespace TrainingApp2.Projects
{
    public class ProjectManagerFinanceProjects : IProjectManagerFinanceProjects
    {
        public enum Limits
        {
            limitNumberOfProjects = 0
        }

        List<FinanceProjectProperties> financeProjectsList = new List<FinanceProjectProperties>();
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
