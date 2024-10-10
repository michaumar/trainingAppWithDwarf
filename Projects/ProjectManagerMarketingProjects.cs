using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Interfaces;

namespace TrainingApp2.Projects
{
    public class ProjectManagerMarketingProjects : IProjectManagerMarketingProjects
    {
        //name, klajent, start dejt, ent dejt, budżet, status
        public enum Limits
        {
            limitNumberOfProjects = 0
        }

        List<MarketingProjectProperties> marketingProjectsList = new List<MarketingProjectProperties>();
        public void AddMarketingProject(string name, string client, DateTime startTime, DateTime endTime, float budget, string status)
        {
            marketingProjectsList.Add(new MarketingProjectProperties(name, client, startTime, endTime, budget, status));
        }
        public void RemoveMarketingProject(string name)
        {
            MarketingProjectProperties searchProject = marketingProjectsList.First(project => project.Name == name);
            marketingProjectsList.Remove(searchProject);
        }
        public bool CheckIfMarketingProjectExist(string name)
        {
            MarketingProjectProperties searchProject = marketingProjectsList.FirstOrDefault(project => project.Name == name);
            return marketingProjectsList.Contains(searchProject);
        }
        public void DisplayMarketingProjects()
        {
            foreach (var project in marketingProjectsList)
            {
                Console.WriteLine("Name: {0}, Client: {1}, Start time: {2}, End time: {3}, Budget: {4}, Status: {5}", project.Name, project.Client, project.StartTime, project.EndTime, project.Budget, project.Status);
            }
        }
        public int CheckActualAmountOfMarketingProject()
        {
            return marketingProjectsList.Count();
        }


    }
}
