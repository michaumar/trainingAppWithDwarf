using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2.Interfaces
{
    internal interface IProjectManagerClassicProjects
    {
        public void AddClassicProject(string name, string description, DateTime startTime, DateTime endTime);
        public void RemoveClassicProject(string name);
        public bool CheckIfClassicProjectExist(string name);
        public void DisplayClassicProjects();
        public int CheckActualAmountOfClassicProject();
    }
}
