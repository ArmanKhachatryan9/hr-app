using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrApp
{
    internal class Helper
    {
        public static string getMenu()
        {
            Menu[] menuItems = Enum.GetValues<Menu>();
            string menuItemsStr = "";
            foreach (Menu menu in menuItems)
            {
                menuItemsStr = menuItemsStr + menu.ToString() + ( " " + (int)menu) + "\n";
            }
            return menuItemsStr;
        }
        public static void printEmployees (List<Employee> employees) { 
               foreach(Employee emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }

        public static Employee buildEmployee()
        {
            Console.Write("name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("level: ");
            Level level = ((Level)Enum.Parse(typeof(Level), Console.ReadLine(), true));
            Console.WriteLine();
            return new Employee(name,surname,salary,level);
        }
    }
}
