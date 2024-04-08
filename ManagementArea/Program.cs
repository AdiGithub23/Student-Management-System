using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Serialization;

namespace ManagementArea
{
    class Program
    {
        //static List<Student> students = new List<Student>(); // List to store students
        static Repository repository = new Repository();
        static void Main(string[] args)
        {

            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("|    W E L C O M E    T O    T H E    P R O G R A M    |");
            Console.WriteLine("|______________________________________________________|");
            Console.WriteLine(" ------------------------------------------------------");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Welcome to the Student Management System!\n\n");

            int choice = MainMenu();
            Console.ReadLine();

        }



        // Start
        static int MainMenu()
        {
            int choice = ShowMainMenuWithOptions();

            // Choice Selection
            switch (choice)
            {
                case 1:
                    PrintStudents();
                    break;
                case 2:
                    AddStudent(repository);
                    break;
                case 3:
                    PrintModules();
                    break;
                case 4:
                    AddModule(repository);
                    break;
                case 5:
                    ExitProgram();
                    break;
            }
            return 0;
        }

        static int StudentMenu()
        {
            int choice = ShowStudentMenuWithOptions();

            // Choice Selection
            switch (choice)
            {
                case 1:
                    AddStudent(repository);
                    break;
                case 2:
                    EditStudent();
                    break;
                case 3:
                    DeleteStudent();
                    break;
                case 4:
                    MainMenu();
                    break;

            }
            return 0;
        }

        static int ModuleMenu()
        {
            int choice = ShowModuleMenuWithOptions();

            // Choice Selection
            switch (choice)
            {
                case 1:
                    AddModule(repository);
                    break;
                case 2:
                    EditModule();
                    break;
                case 3:
                    DeleteModule();
                    break;
                case 4:
                    MainMenu();
                    break;
            }
            return 0;
        }



        //Done
        static int ShowMainMenuWithOptions()
        {
            // Define the menu options
            List<string> mainOptionList = new List<string>
            {
                "Manage All Students",
                "Add Students",
                "Manage All Modules",
                "Add Modules",
                "Exit"
            };

            int choice = 1;
            const int totalOptions = 5;

            Console.CursorVisible = false;

            while (true)
            {
                //Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Welcome to the Student Management System!\n");

                for (int i = 0; i < totalOptions; i++)
                {
                    if (i == choice - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(">");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine($"\t {i + 1}: {mainOptionList[i]}");
                    Console.ResetColor();
                }

                var key = Console.ReadKey(true).Key;

                //ArrowKey Navigation
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (choice > 1)
                            choice--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (choice < totalOptions)
                            choice++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (choice > 1)
                            choice--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (choice < totalOptions)
                            choice++;
                        break;
                    case ConsoleKey.Enter:
                        //Console.CursorVisible = true;
                        return choice;
                }
            }
        }
        //Done
        static int ShowStudentMenuWithOptions()
        {
            // Define the menu options
            List<string> studentOptionList = new List<string>
            {
                "Add Students",
                "Edit Students",
                "Deete Students",
                "Go back"
            };

            int choice = 4;
            const int studentOptions = 4;

            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();
                //PrintStudents();
                Console.WriteLine("\nStudent Management Area!\n");

                for (int i = 0; i < studentOptions; i++)
                {
                    if (i == choice - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(">");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine($"\t {i + 1}: {studentOptionList[i]}");
                    Console.ResetColor();
                }

                var key = Console.ReadKey(true).Key;

                //ArrowKey Navigation
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (choice > 1)
                            choice--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (choice < studentOptions)
                            choice++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (choice > 1)
                            choice--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (choice < studentOptions)
                            choice++;
                        break;
                    case ConsoleKey.Enter:
                        //Console.CursorVisible = true;
                        return choice;
                }
            }
        }
        //Done
        static int ShowModuleMenuWithOptions()
        {
            // Define the menu options
            List<string> moduleOptionList = new List<string>
            {
                "Add Module",
                "Edit Module",
                "Deete Module",
                "Go back"
            };

            int choice = 4;
            const int moduleOptions = 4;

            Console.CursorVisible = false;

            while (true)
            {
                //Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Student Management Area!\n");

                for (int i = 0; i < moduleOptions; i++)
                {
                    if (i == choice - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(">");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine($"\t {i + 1}: {moduleOptionList[i]}");
                    Console.ResetColor();
                }

                var key = Console.ReadKey(true).Key;

                //ArrowKey Navigation
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (choice > 1)
                            choice--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (choice < moduleOptions)
                            choice++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (choice > 1)
                            choice--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (choice < moduleOptions)
                            choice++;
                        break;
                    case ConsoleKey.Enter:
                        //Console.CursorVisible = true;
                        return choice;
                }
            }
        }



        //Done
        static int PrintStudents()
        {
            // Define the menu options
            List<string> studentOptionList = new List<string>
            {
                "Add Students",
                "Edit Students",
                "Deete Students",
                "Go back"
            };

            int choice = 4;
            const int studentOptions = 4;
            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("List of Students:\n");

                foreach (var student in repository.Students)
                {
                    int moduleCount = 0;
                    if (student.RegisteredModules.Count() > 0)
                    {
                        moduleCount = student.RegisteredModules.Count();
                    }
                    Console.WriteLine($"Reg No.: {student.RegistrationNumber}, Name: {student.FirstName} {student.LastName}, Modules: {moduleCount}");

                    if (student.RegisteredModules.Count > 0)
                    {
                        int i = 0;
                        Console.WriteLine("\tRegistered Modules:");
                        foreach (var moduleCode in student.RegisteredModules)
                        {

                            // Find the module information by module code
                            Module module = repository.Modules.Find(mod => mod.ModuleCode == moduleCode);
                            if (module != null)
                            {
                                Console.WriteLine($"\t\t{module.ModuleCode}: {module.ModuleName} - {student.Grades[i]}");
                            }
                            i++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No modules registered.");
                    }

                    Console.WriteLine(); // Add a blank line between students
                }

                Console.WriteLine("\nStudent Management Area!\n");

                for (int i = 0; i < studentOptions; i++)
                {
                    if (i == choice - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(">");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine($"\t {i + 1}: {studentOptionList[i]}");
                    Console.ResetColor();
                }

                var key = Console.ReadKey(true).Key;

                //ArrowKey Navigation
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (choice > 1)
                            choice--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (choice < studentOptions)
                            choice++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (choice > 1)
                            choice--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (choice < studentOptions)
                            choice++;
                        break;
                    case ConsoleKey.Enter:
                        Console.CursorVisible = true;
                        StudentMenu();
                        return choice;

                }
                //return choice;
            }






            //// Going Back
            //Console.WriteLine("\nType '0' to Go Back to the Main Menu");
            //string? goBackKey = Console.ReadLine();
            //if (goBackKey == "0")
            //{
            //    Console.Clear();
            //    choice = StudentMenu();
            //}
            //else
            //{
            //    PrintStudents();
            //}

        }

        //Done
        static void PrintModules()
        {
            //Console.Clear();
            //Console.WriteLine("List of Modules:");







            // Define the menu options
            List<string> moduleOptionList = new List<string>
            {
                "Add Modules",
                "Edit Modules",
                "Delete Modules",
                "Go back"
            };

            int choice = 4;
            const int moduleOptions = 4;
            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("List of Students:\n");
                foreach (var module in repository.Modules)
                {
                    Console.WriteLine($"Module Code: {module.ModuleCode}, Credits: {module.ModuleCredits}, Module Name: {module.ModuleName}");
                }

                Console.WriteLine("\nStudent Management Area!\n");

                for (int i = 0; i < moduleOptions; i++)
                {
                    if (i == choice - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(">");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine($"\t {i + 1}: {moduleOptionList[i]}");
                    Console.ResetColor();
                }

                var key = Console.ReadKey(true).Key;

                //ArrowKey Navigation
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (choice > 1)
                            choice--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (choice < moduleOptions)
                            choice++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (choice > 1)
                            choice--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (choice < moduleOptions)
                            choice++;
                        break;
                    case ConsoleKey.Enter:
                        Console.CursorVisible = true;
                        ModuleMenu();
                        return;
                }
            }






        }




        //Done - ???
        static void AddStudent(Repository repository)
        {
            Console.Clear();

            Console.Write("Enter Registration Number: ");
            int regNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter DoB (YYYY-MM-DD): ");
            DateTime dob;
            while (!DateTime.TryParse(Console.ReadLine(), out dob))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid date format. Please enter date in YYYY-MM-DD format.");
                Console.ResetColor();
            }
            Console.Write("Enter NIC: ");
            string nic = Console.ReadLine();


            // List the Modules to Choose
            Console.WriteLine("List of Modules:");
            foreach (var mod in repository.Modules)
            {
                Console.WriteLine(
                    $"Module Code: {mod.ModuleCode}, " +
                    $"Credits: {mod.ModuleCredits}, " +
                    $"Module Name: {mod.ModuleName}");
            }

            // Get modules and grades from the user
            List<string> registeredModules = new List<string>();
            List<int> grades = new List<int>();
            char addMoreModules;

            do
            {
                Console.Write("Enter Module Code: ");
                string moduleCode = Console.ReadLine();

                Console.Write("Enter Grade: ");
                int grade = int.Parse(Console.ReadLine());

                registeredModules.Add(moduleCode);
                grades.Add(grade);

                Console.Write("Add more modules? (Y/N): ");
                addMoreModules = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (addMoreModules == 'Y' || addMoreModules == 'y');

            // Create a new student object and add it to the list
            Student newStudent = new Student(regNumber, firstName, lastName, dob, nic, registeredModules, grades);
            repository.Students.Add(newStudent);

            Console.WriteLine("Student added successfully!");

            // Going Back
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadKey(true);
            Console.Clear();
            int choice = MainMenu();

        }

        static void EditStudent()
        {
            Console.Clear();
            Console.WriteLine("Edit Student:");

            // Ask user for the registration number of the student to edit
            Console.Write("Enter the Registration Number of the student to edit: ");
            int regNumber = int.Parse(Console.ReadLine());

            // Find the student in the repository by registration number
            Student studentToEdit = repository.Students.Find(student => student.RegistrationNumber == regNumber);

            // Check if the student exists
            if (studentToEdit != null)
            {
                // Display the current information of the student
                Console.WriteLine($"Current Details of Student (Reg No.: {studentToEdit.RegistrationNumber}):");
                Console.WriteLine($"Name: {studentToEdit.FirstName} {studentToEdit.LastName}");
                Console.WriteLine($"Date of Birth: {studentToEdit.DateOfBirth.ToShortDateString()}");
                Console.WriteLine($"NIC: {studentToEdit.NIC}");
                if (studentToEdit.RegisteredModules.Count > 0)
                {
                    int i = 0;
                    Console.WriteLine("Registered Modules:");
                    foreach (var moduleCode in studentToEdit.RegisteredModules)
                    {
                        Module module = repository.Modules.Find(mod => mod.ModuleCode == moduleCode);
                        if (module != null)
                        {
                            Console.WriteLine($"\t{module.ModuleCode}: {module.ModuleName} - {studentToEdit.Grades[i]}");
                        }
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("No modules registered.");
                }

                // Ask the user for the new information
                Console.WriteLine("\nEnter new details:");

                Console.Write("First Name: ");
                string newFirstName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newFirstName))
                {
                    studentToEdit.FirstName = newFirstName;
                }

                Console.Write("Last Name: ");
                string newLastName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newLastName))
                {
                    studentToEdit.LastName = newLastName;
                }

                Console.Write("Date of Birth (YYYY-MM-DD): ");
                DateTime newDob;
                if (DateTime.TryParse(Console.ReadLine(), out newDob))
                {
                    studentToEdit.DateOfBirth = newDob;
                }

                Console.Write("NIC: ");
                string newNic = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newNic))
                {
                    studentToEdit.NIC = newNic;
                }



                // List the Modules to Choose
                Console.WriteLine("List of Modules:");
                foreach (var mod in repository.Modules)
                {
                    Console.WriteLine(
                        $"Module Code: {mod.ModuleCode}, " +
                        $"Credits: {mod.ModuleCredits}, " +
                        $"Module Name: {mod.ModuleName}");
                }

                // Get modules and grades from the user
                List<string> registeredModules = new List<string>();
                List<int> grades = new List<int>();
                char addMoreModules;

                do
                {
                    Console.Write("Enter Module Code: ");
                    string moduleCode = Console.ReadLine();

                    Console.Write("Enter Grade: ");
                    int grade = int.Parse(Console.ReadLine());

                    registeredModules.Add(moduleCode);
                    grades.Add(grade);

                    Console.Write("Add more modules? (Y/N): ");
                    addMoreModules = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                } while (addMoreModules == 'Y' || addMoreModules == 'y');


                // Display confirmation message
                Console.WriteLine("\nStudent details updated successfully!");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            // Wait for user input before returning to the main menu
            Console.WriteLine("\nPress any key to go back to the main menu");
            Console.ReadKey(true);
            Console.Clear();
            MainMenu();
        }






        //Done
        static void DeleteStudent()
        {
            Console.Clear();
            Console.WriteLine("Delete Student:");

            // Ask user for the registration number of the student to delete
            Console.Write("Enter the Registration Number of the student to delete: ");
            int regNumber = int.Parse(Console.ReadLine());

            // Find the index of the student in the repository by registration number
            int index = repository.Students.FindIndex(student => student.RegistrationNumber == regNumber);

            // Check if the student exists
            if (index != -1)
            {
                // Confirm deletion with the user
                Console.WriteLine($"Are you sure you want to delete the student with Registration Number {regNumber}? (Y/N)");
                char confirmation = Console.ReadKey().KeyChar;

                if (confirmation == 'Y' || confirmation == 'y')
                {
                    // Delete the student from the list
                    repository.Students.RemoveAt(index);
                    Console.WriteLine("\nStudent deleted successfully!");
                }
                else
                {
                    Console.WriteLine("\nDeletion canceled.");
                }
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            // Wait for user input before returning to the main menu
            Console.WriteLine("\nPress any key to go back to the main menu");
            Console.ReadKey(true);
            Console.Clear();
            MainMenu();
        }



        //Done
        static void AddModule(Repository repository)
        {
            Console.Clear();
            // Get input for new student details
            Console.Write("Enter Module Code: ");
            string modCode = Console.ReadLine();
            Console.Write("Enter Module Name: ");
            string modName = Console.ReadLine();
            Console.Write("Enter Module Credit: ");
            int modCredit = int.Parse(Console.ReadLine());

            // Create a new Module object and add it to the list
            Module newModule = new Module(modCode, modName, modCredit);
            repository.Modules.Add(newModule);

            Console.WriteLine("Module added successfully!");

            // Going Back
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadKey(true);
            Console.Clear();
            int choice = MainMenu();

        }
        //Done
        static void DeleteModule()
        {
            Console.Clear();
            Console.WriteLine("Delete Module:");

            // Ask user for the module code of the module to delete
            Console.Write("Enter the Module Code of the module to delete: ");
            string moduleCode = Console.ReadLine();

            // Find the index of the module in the repository by module code
            int index = repository.Modules.FindIndex(module => module.ModuleCode == moduleCode);

            // Check if the module exists
            if (index != -1)
            {
                // Confirm deletion with the user
                Console.WriteLine($"Are you sure you want to delete the module with Module Code {moduleCode}? (Y/N)");
                char confirmation = Console.ReadKey().KeyChar;

                if (confirmation == 'Y' || confirmation == 'y')
                {
                    // Delete the module from the list
                    repository.Modules.RemoveAt(index);
                    Console.WriteLine("\nModule deleted successfully!");
                }
                else
                {
                    Console.WriteLine("\nDeletion canceled.");
                }
            }
            else
            {
                Console.WriteLine("Module not found.");
            }

            // Wait for user input before returning to the main menu
            Console.WriteLine("\nPress any key to go back to the main menu");
            Console.ReadKey(true);
            Console.Clear();
            MainMenu();
        }
        //Done
        static void EditModule()
        {
            Console.Clear();
            Console.WriteLine("Edit Module:");

            // Ask user for the module code of the module to edit
            Console.Write("Enter the Module Code of the module to edit: ");
            string moduleCode = Console.ReadLine();

            // Find the module in the repository by module code
            Module moduleToEdit = repository.Modules.Find(module => module.ModuleCode == moduleCode);

            // Check if the module exists
            if (moduleToEdit != null)
            {
                // Display the current information of the module
                Console.WriteLine($"Current Details of Module (Module Code: {moduleToEdit.ModuleCode}):");
                Console.WriteLine($"Module Name: {moduleToEdit.ModuleName}");
                Console.WriteLine($"Module Credits: {moduleToEdit.ModuleCredits}");

                // Ask the user for the new information
                Console.WriteLine("\nEnter new details:");

                Console.Write("Module Code: ");
                string newModuleCode = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newModuleCode))
                {
                    moduleToEdit.ModuleCode = newModuleCode;
                }
                Console.Write("Module Name: ");
                string newModuleName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newModuleName))
                {
                    moduleToEdit.ModuleName = newModuleName;
                }

                Console.Write("Module Credits: ");
                int newModuleCredits;
                if (int.TryParse(Console.ReadLine(), out newModuleCredits))
                {
                    moduleToEdit.ModuleCredits = newModuleCredits;
                }

                // Display confirmation message
                Console.WriteLine("\nModule details updated successfully!");
            }
            else
            {
                Console.WriteLine("Module not found.");
            }

            // Wait for user input before returning to the main menu
            Console.WriteLine("\nPress any key to go back to the main menu");
            Console.ReadKey(true);
            Console.Clear();
            MainMenu();
        }



        //Done
        static void ExitProgram()
        {
            Console.Clear();
            Console.SetCursorPosition(50, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Exiting Programme.....");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(85, 20);
            Environment.Exit(0);
        }



    }
}

