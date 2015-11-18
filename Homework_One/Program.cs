using System;
using System.Collections.Generic;
using Homework_One.Models;

namespace Homework_One
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(@"----Welcome to human resource management program---- 
            Choice one in all function below:
                1. Enter staffs’ information.
                2. Search officers and professors.
                3. Display list of officers and professors.
                4. Method to insert, edit and delete staff.
                5. Save information into a *.cvs file.
                6. Read information from a *.cvs file. 
                7. Work with Database.
                8. Exit.
                            ");
            var listStaff = new Repositories<Staff>();
            Console.Write("Your number you choice: ");
            var inputNumber = Convert.ToInt32(Console.ReadLine());
            // menu1
            if (inputNumber == 1)
            {
                Console.WriteLine(
                 @"Choice 1 to enter office staff's information,
                        or 2 to enter professor staff's information.");
                var inputMenu1 = Convert.ToInt32(Console.ReadLine());
                int typeStaff;
                if (inputMenu1 == 1)
                {
                    typeStaff = 1;
                    var staffEntity = AddStaff(typeStaff);
                    listStaff.Add(staffEntity);
                    return;
                }
                if (inputMenu1 == 2)
                {
                    typeStaff = 2;
                    var staffEntity = AddStaff(typeStaff);
                    listStaff.Add(staffEntity);
                    return;
                }
                Console.WriteLine("Error");
            }
            // menu2
            if (inputNumber == 2)
            {
                Console.WriteLine(
                    "Choice 1 to search office staff's information, or 2 to search professor staff's information.");
                var inputMenu2 = Convert.ToInt32(Console.ReadLine());
                int typeStaff;
                if (inputMenu2 == 1)
                {
                    typeStaff = 1;
                   
                    return;
                }
                if (inputMenu2 == 2)
                {
                    typeStaff = 2;
                    return;
                }
                Console.WriteLine("Error");
                return;
            }
            // menu3
            if (inputNumber == 3)
            {
                Console.WriteLine("List staff's information.");
                return;
            }
            // menu4
            if (inputNumber == 4)
            {
                Console.WriteLine("Choice 1 to insert staff, 2 to edit staff, 3 to delete staff");
                return;
            }
            // menu5
            if (inputNumber == 5)
            {
                Console.WriteLine("Save information into a *.cvs file.");
                return;
            }
            // menu6
            if (inputNumber == 6)
            {
                Console.WriteLine("Read information from *.cvs file.");
                return;
            }
            // menu7
            if (inputNumber == 7)
            {
                Console.WriteLine("Work with database.");
                return;
            }
            // menu8
            if (inputNumber == 8)
            {
                Console.WriteLine("Bye!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Error.");
                Console.ReadKey();
            }
        }

        public static bool ExecuteMenuOne(Repositories<Staff> listStaff)
        {
            
            return false;
        }

        // Process
        private static Staff AddStaff(int typeStaff)
        {
            Console.Write("Full Name of staff office: ");
            var fullName = Convert.ToString(Console.ReadLine());
            Console.Write("Allowance of staff office: ");
            var allowance = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Salary ratio of staff office: ");
            var salaryRatio = Convert.ToDouble(Console.ReadLine());

            if (typeStaff == 1)
            {
                Console.Write("Working time of staff office: ");
                var workingTime = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Department of staff office: ");
                var department = Convert.ToString(Console.ReadLine());
                Console.Write("Position of staff office: ");
                var position = Convert.ToString(Console.ReadLine());

                Staff newOffice = new Office(new Guid(), fullName, allowance, salaryRatio, typeStaff,
                    department, workingTime, position);
                return newOffice;
            }
            if (typeStaff == 2)
            {
                Console.Write("Academi Degree of staff professor: ");
                var academicDegree = Convert.ToString(Console.ReadLine());
                Console.Write("Faculty of staff professor: ");
                var faculty = Convert.ToString(Console.ReadLine());
                Console.Write("Monthly Teaching time of staff professor: ");
                float monthlyTeachingTime = Convert.ToInt64(Console.ReadLine());

                Staff newProfessor = new Professor(new Guid(), fullName, allowance, salaryRatio, typeStaff,
                    faculty, monthlyTeachingTime, academicDegree);
                return newProfessor;
            }
            return null;
        }
    }
}