using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Interfaces;

namespace TrainingApp2.Projects
{
    public class ProjectManagerLogisticProjects : IProjectManagerLogisticProjects
    {
        //nejm, klajent, start date, end date, budżet, status, lista z firmami odnośnie transportu, lista z wszystkimi zadaniami, całkowity koszt czegoś
        public enum Limits
        {
            limitNumberOfProjects = 0
        }

        List<LogisticProjectProperties> logisticProjectList = new List<LogisticProjectProperties>();

        public void AddLogisticProject(string name, string client, DateTime startTime, DateTime endTime, float budget, string status, 
            float costOfSomething, List<string> transportCustomerList, List<string> allTasksList)
        {
            logisticProjectList.Add(new LogisticProjectProperties(name, client, startTime, endTime, budget, status, costOfSomething, transportCustomerList, allTasksList));
        }
        public void RemoveLogisticProject(string name)
        {
            LogisticProjectProperties searchProject = logisticProjectList.First(project => project.Name == name);
            logisticProjectList.Remove(searchProject);
        }
        public bool CheckIfLogisticProjectExist(string name)
        {
            LogisticProjectProperties searchProject = logisticProjectList.FirstOrDefault(project => project.Name == name);
            return logisticProjectList.Contains(searchProject);
        }
        public void DisplayLogisticProjects()
        {
            foreach (var project in logisticProjectList)
            {
                string transportCustomerList = string.Join(", ", project.TransportCustomerList.Select((task, index) => $"{index + 1}. {task}"));
                string allTasksList = string.Join(", ", project.AllTasksList.Select((task, index) => $"{index + 1}. {task}"));
                Console.WriteLine("Name: {0}, Client: {1}, Start time: {2}, End time: {3}, Budget: {4:C}, Status: {5}, ToDoList: {6}", project.Name, project.Client, project.StartTime, project.EndTime, project.Budget, project.Status, project.CostOfSomething, transportCustomerList, allTasksList);
            }
        }
        public int CheckActualAmountOfLogisticProject()
        {
            return logisticProjectList.Count();
        }
    }

}
