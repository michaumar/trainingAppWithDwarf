using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2.Interfaces
{
    internal interface ILogisticProjectValidator
    {
        public List<string> ValidateTransportCustomerList();
        public List<string> ValidateAllTasksList();
        public float ValidateCostOfSomething();

    }
}
