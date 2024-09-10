using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2.Interfaces
{
    internal interface IProjectManagerFinanceProjects
    {
        public void AddFinanceProject(string name, string description, float price, string author);
        public void RemoveFinanceProject(string name);
        public bool CheckIfFinanceProjectExist(string name);
        public void DisplayFinanceProjects();
        public int CheckActualAmountOfFinanceProject();
    }

}
