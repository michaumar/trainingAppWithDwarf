using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Projects;

namespace TrainingApp2.Interfaces
{
    internal interface IProjectManagerMarketingProjects
    {
        public void AddMarketingProject(string name, string client, DateTime startTime, DateTime endTime, float budget, string status);
        public void RemoveMarketingProject(string name);
        public bool CheckIfMarketingProjectExist(string name);
        public void DisplayMarketingProjects();
        public int CheckActualAmountOfMarketingProject();
    }
}
