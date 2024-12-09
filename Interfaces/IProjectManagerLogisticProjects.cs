using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Projects;

namespace TrainingApp2.Interfaces
{
    internal interface IProjectManagerLogisticProjects
    {
        public void AddLogisticProject(string name, string client, DateTime startTime, DateTime endTime, float budget, string status,
    float costOfSomething, List<string> transportCustomerList, List<string> allTasksList);
        public void RemoveLogisticProject(string name);
        public bool CheckIfLogisticProjectExist(string name);
        public void DisplayLogisticProjects();
        public int CheckActualAmountOfLogisticProject();
    }
}
