using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementArea
{
    public class Module
    {
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public int ModuleCredits { get; set; }


        public Module(string moduleCode, string moduleName, int moduleCredits)
        {
            ModuleCode = moduleCode;
            ModuleName = moduleName;
            ModuleCredits = moduleCredits;
        }
    }
}
