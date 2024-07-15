using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Projects;


namespace TrainingApp2
{
    public class ProjectManagerBasicProjects
    {
        public enum Limits
        {
            limitNumberOfProjects = 0
        }

        List<BasicProperties> basicProjectsList = new List<BasicProperties>();
        public void RemoveProject(string name)
        {
            BasicProperties searchProject = basicProjectsList.First(project => project.Name == name);
            basicProjectsList.Remove(searchProject);
        }
        public bool CheckIfProjectExist(string name)
        {
            BasicProperties searchProject = basicProjectsList.FirstOrDefault(project => project.Name == name);
            return basicProjectsList.Contains(searchProject);
        }
        public int CheckActualAmountOfProject()
        {
            return basicProjectsList.Count();
        }

    }
}
