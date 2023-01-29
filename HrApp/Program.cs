using System;

namespace HrApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("MyCompany","Abelyan9",Industry.IT);
            Employee employee1 = new Employee("dsad", "sadasdsa", 123, Level.JUNIOR);
            Employee employee2 = new Employee("dsa", "fdsa", 1223, Level.SENIOR);
            Employee employee3 = new Employee("e", "q", 1, Level.JUNIOR);
            company.AddEmployee(employee1);
            company.AddEmployee(employee2);
            company.AddEmployee(employee3);
            Console.WriteLine(company);
            Console.WriteLine();
            Console.WriteLine(company.deserialize());
            bool needToContinue = true;
            while (needToContinue)
            {
                int choice;
                while (true)
                {
                    Console.WriteLine(Helper.getMenu());

                    if (Int32.TryParse(Console.ReadLine(), out choice) &&
                                Enum.IsDefined<Menu>((Menu)choice))
                    {
                        break;
                    }
                }
                Menu selectedChoice = (Menu)choice;

                switch (selectedChoice)
                {
                    case Menu.closeProgram:
                        needToContinue = false;
                        try
                        {
                            using StreamWriter stream = new StreamWriter("hr.txt");
                            stream.WriteLine(company.deserialize());
                        }
                        catch
                        {
                            
                        }
                        break;
                    case Menu.getEmployees:
                        Helper.printEmployees(company.GetEmployees);
                        break;  
                    case Menu.addEmployee:
                        Employee newEmployee = Helper.buildEmployee();
                        company.AddEmployee(newEmployee);
                        break;
                    case Menu.removeEmployee:
                        Console.WriteLine("Chose id");
                        int id = Int32.Parse(Console.ReadLine());
                        company.RemoveEmployee(id);
                        break;
                }
            } 



        }

      
    }
}