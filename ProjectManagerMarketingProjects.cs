using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Interfaces;
using TrainingApp2.Projects;

namespace TrainingApp2
{
    public class ProjectManagerMarketingProjects : IProjectManagerMarketingProjects
    {
        //name, klajent, start dejt, ent dejt, budżet, status
        public enum Limits
        {
            limitNumberOfProjects = 0
        }

        List<MarketingProjectProperties> marketingProjectList = new List<MarketingProjectProperties>();
        public void AddMarketingProject(string name, string client, DateTime startTime, DateTime endTime, float budget, string status)
        {
            marketingProjectList.Add(new MarketingProjectProperties(name, client, startTime, endTime, budget, status));
        }
        public void RemoveMarketingProject(string name)
        {
            MarketingProjectProperties searchProject = marketingProjectList.First(project => project.Name == name);
            marketingProjectList.Remove(searchProject);
        }
        public bool CheckIfMarketingProjectExist(string name)
        {
            FinanceProjectProperties searchProject = marketingProjectList.FirstOrDefault(project => project.Name == name);
            return marketingProjectList.Contains(searchProject);
        }
        public void DisplayMarketingProjects()
        {
            foreach (var project in marketingProjectList)
            {
                Console.WriteLine("Name: {0}, Client: {1}, Start time: {2}, End time: {3}, Budget: {4}, Status: {5}", project.Name, project.Client, project.StartTime, project.EndTime, project.Budget, project.Status);
            }
        }
        public int CheckActualAmountOfMarketingProject()
        {
            return marketingProjectList.Count();
        }


    }
}
