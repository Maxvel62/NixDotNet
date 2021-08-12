﻿using System;
using System.Collections.Generic;
using System.Text;
using FitnessSuperiorMvc.DA.Entities.Interaction;

namespace FitnessSuperiorMvc.DA.Interfaces
{
    internal interface IStaff
    {
        public string Education { get; set; }
        public int WorkExperience { get; set; }
        public ICollection<Feedback> Feedback { get; set; }
    }
}
