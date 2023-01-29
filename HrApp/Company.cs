using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HrApp
{
    internal class Company
    {
        private string name { get;  }
        private string address { get; set; }    
        private Industry industry { get;  }

        private List<Employee> employees { get; }
        public Company(string name , string address, Industry industry)
        {
            this.name = name;
            this.address = address;
            this.industry = industry;
            this.employees = new List<Employee>();
        }
        public bool AddEmployee(Employee employee)
        { 
            employees.Add(employee);
            return employees.Contains(employee);
        }

        public bool RemoveEmployee(int id ) { 
            
            foreach (Employee emp in employees)
            {
                if (emp.getId() == id)
                {
                    employees.Remove(emp);
                    return true;
                }
                
            }
            return false;
        }

        public List<Employee> GetEmployees { get { return employees; } }


        public override string? ToString()
        {
            return "Company is: \n" +
                "\nname: " + this.name +
                "\naddress: " + this.address +
                "\nindustry: " + this.industry;
        }

        public string deserialize()
        {
            string companyData = $"name: {this.name}\n" +
                $"address: {this.address}\n" +
                $"industry: {this.industry}\n";
            companyData += "---\n";
            foreach (Employee employee in employees)
            {
                companyData += employee.ToString();
                companyData += "\n";
            }
            return companyData;
        }
    }
}
