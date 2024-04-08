using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ManagementArea
{
    public class Student
    {
        public int RegistrationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NIC { get; set; }
        public Dictionary<string, string> ModuleGrades { get; set; }

        public List<string> RegisteredModules { get; }
        public List<int> Grades { get; }


        //public Student(int registrationNumber, string firstName, string lastName, DateTime dateOfBirth, string nic, Dictionary<string, string> moduleGrades, List<Module> registeredModules)
        //{
        //    RegistrationNumber = registrationNumber;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    DateOfBirth = dateOfBirth;
        //    NIC = nic;
        //    ModuleGrades = moduleGrades;
        //    RegisteredModules = registeredModules;
        //}
        public Student(int regNumber, string firstName, string lastName, DateTime dob, string nic, List<string> modules, List<int> grades)
        {
            RegistrationNumber = regNumber;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
            NIC = nic;
            RegisteredModules = modules;
            Grades = grades;
        }
    }
}