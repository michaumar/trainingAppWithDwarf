﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2.Interfaces
{
    internal interface IEcologicProjectValidator
    {
        public string ValidateOrganizer();

        public List<string> ValidateToDoList();
    }
}