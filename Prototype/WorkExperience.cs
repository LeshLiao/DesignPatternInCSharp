using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    public class WorkExperience
    {
        public string workDate { get; set; }
        public string company { get; set; }
        public WorkExperience ShallowCopy()
        {
            return (WorkExperience)this.MemberwiseClone();
        }

    }
}