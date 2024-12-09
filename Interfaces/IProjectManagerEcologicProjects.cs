using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Projects;

namespace TrainingApp2.Interfaces
{
    internal interface IProjectManagerEcologicProjects
    {
        public void AddEcologicProject(string name, string organizer, DateTime startTime, DateTime endTime, float budget, string status, List<string> toDoList);
        public void RemoveEcologicProject(string name);
        public bool CheckIfEcologicProjectExist(string name);
        public void DisplayEcologicProjects();
        public int CheckActualAmountOfEcologicProject();

    }
}
