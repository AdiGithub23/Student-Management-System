using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementArea
{

    public class StudentModule
    {
        public string ModuleCode { get; set; }
        public string Grade { get; set; }

        public StudentModule(string moduleCode, string grade)
        {
            ModuleCode = moduleCode;
            Grade = grade;
        }
    }
}
