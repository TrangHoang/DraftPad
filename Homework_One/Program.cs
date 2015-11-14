using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_One
{
    class Program
    {
        static void Main(string[] args)
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

            Console.Write("Your number you choice: ");
            int inputNumber = Convert.ToInt16(Console.ReadLine());
            switch (inputNumber)
            {
                case 1:
                    Console.WriteLine("Choice 1 to enter office staff's information, or 2 to enter professor staff's information.");
                    break;
                case 2:
                    Console.WriteLine("Choice 1 to search office staff's information, or 2 to search professor staff's information.");
                    break;
                case 3:
                    Console.WriteLine("List staff's information.");
                    break;
                case 4:
                    Console.WriteLine("Choice 1 to insert staff, 2 to edit staff, 3 to delete staff");
                    break;
                case 5:
                    Console.WriteLine("Save information into a *.cvs file.");
                    break;
                case 6:
                    Console.WriteLine("Read information from *.cvs file.");
                    break;
                case 7:
                    Console.WriteLine("Work with database.");
                    break;
                case 8:
                    Console.WriteLine("Bye!");                    
                    break;
                default:
                    Console.WriteLine("Wrong number");
                    Console.ReadKey();
                    break;
        }
    }
}
