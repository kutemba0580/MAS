﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent.Agents
{
    class Adolescent : Person
    {
        public Adolescent(int Id, CoreAMS.Enums.HealthState healthState, string locationProbabilitiesFile) : base(Id, healthState) 
        {
        }
    }
}
