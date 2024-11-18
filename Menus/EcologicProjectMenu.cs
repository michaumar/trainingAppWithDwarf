using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp2.Projects;
using TrainingApp2.Validators;

namespace TrainingApp2.Menus
{
    public class EcologicProjectMenu
    {
        ProjectManagerEcologicProjects projects = new ProjectManagerEcologicProjects();
        InputDataValidation inputData = new InputDataValidation();
        BasicEcologicMarketingLogisticValidator basicEcologicMarketingLogisticValidator = new BasicEcologicMarketingLogisticValidator();
        EcologicProjectValidator marketingProjectValidator = new EcologicProjectValidator();
        Menu menu = new Menu();

        int tempProjectSelectMenu;


    }
}
