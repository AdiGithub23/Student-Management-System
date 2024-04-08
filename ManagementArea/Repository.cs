//using System;
//using System.Collections.Generic;

//namespace ManagementArea
//{
//    public class Repository
//    {
//        public static List<Student> GetStudents()
//        {
//            Dictionary<string, string> myDictionary = new Dictionary<string, string> {};

//            List<StudentModule> studentModules = new List<StudentModule>();
//            // Dummy data for students
//            List<Student> students = new List<Student>
//            {
//                new Student(001, "Adheesha", "Gunatilake", new DateTime(1999, 5, 23), "123456789V", myDictionary = new Dictionary<string, string>
//                {
//                    {"A", "grd"},
//                    {"B", "grd"},
//                    {"C", "grd"}
//                }, ["A", "B", "C"]),
//                //new Student(002, "Radeesha", "Gunasinghe", new DateTime(2000, 5, 21), "987654321V", new List<StudentModule>
//                //{
//                //    new StudentModule("CE3350", "C"),
//                //    new StudentModule("CE3352", "A-")
//                //}),
//                //new Student(003, "Nadeesha", "Gurunayake", new DateTime(2001, 8, 19), "123456789V", new List<StudentModule>
//                //{
//                //    new StudentModule("CE3351", "B"),
//                //    new StudentModule("CE3353", "B")
//                //}),
//                //new Student(004, "Sadeesha", "Gunarathne", new DateTime(2002, 8, 17), "987654321V", new List<StudentModule>
//                //{
//                //    new StudentModule("CE3352", "C"),
//                //    new StudentModule("CE3353", "A+")
//                //})
//            };

//            return students;
//        }

//        public static List<Module> GetModules()
//        {
//            // Dummy data for modules
//            List<Module> modules = new List<Module>
//            {
//                new Module("CE3350", "Introduction to Programming", 2),
//                new Module("CE3351", "Database Management", 3),
//                new Module("CE3352", "Introduction to Networking", 3),
//                new Module("CE3353", "Operating Systems", 4),
//            };

//            return modules;
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Reflection;

namespace ManagementArea
{
    public class Repository
    {
        public List<Student> Students { get; private set; }
        public List<Module> Modules { get; private set; }

        public Repository()
        {
            // Initialize lists
            Students = GetStudents();
            Modules = GetModules();
        }

        public List<Student> GetStudents()
        {
            // Dummy student data
            List<Student> students = new List<Student>
            {
                new Student(1, "John", "Doe", new DateTime(2000, 1, 1), "123456789V", new List<string>{"CS101", "CS102", "CS103"}, new List<int>{85, 90, 75}),
                new Student(2, "Jane", "Smith", new DateTime(2001, 2, 2), "987654321V", new List<string>{"CS102", "CS103"}, new List<int>{75, 80})
            };

            return students;
        }

        public List<Module> GetModules()
        {
            // Dummy module data
            List<Module> modules = new List<Module>
            {
                new Module("CS101", "Introduction to Programming", 3),
                new Module("CS102", "Data Structures and Algorithms", 4),
                new Module("CS103", "Database Management Systems", 3)
            };

            return modules;
        }
    }
}

