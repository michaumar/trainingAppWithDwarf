using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2
{
    public class ProjectManager
    {
        Dictionary<string, string> ProjectManagerDict = new Dictionary<string, string>();

        public void AddProject(string name, string description_startTime_EndTime)
        {
            ProjectManagerDict.Add(name, description_startTime_EndTime);
        }
        public void RemoveProject(string name)
        {
            ProjectManagerDict.Remove(name);
        }
        public void DisplayProjects()
        {
            foreach (var item in ProjectManagerDict)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
        }
    }
}
