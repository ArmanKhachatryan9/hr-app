using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrApp
{
    internal class Employee
    {
        private static int idCounter = 1;
        private int id { get; }
        private string name { get;  }
        private string surname { get;  }

        private int salary { get; set; }
  
        private Level level { get; set; }
        public Employee(string name , string surname , int salary, Level lavel ) { 
            this.id = idCounter++;
            this.name = name;
            this.surname = surname;
            this.salary = salary;
            this.level = lavel;
        }
         
        public string getName()
        {
            return name;
        }
        public int getId()
        {
            return id;
        }

        public override string? ToString()
        {
            return $"id: {id}, name: {name}, surname: {surname}, salary: {salary}, level: {level}";
        }
    }
}
