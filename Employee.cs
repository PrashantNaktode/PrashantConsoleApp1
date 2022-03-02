using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrashantConsoleApp1
{
    public class Employee
    {
        private string name;
        private int id;

        public string Name { get; set } 
    }
    public class User : Employee
    {
        private string Designation;
        public string Designation { get; set }
        public static void Main(string[] args )
        {
            User usr = new User();
            usr.Id = 10;
            usr.Name = "Anita";
            Employee e1 = new Employee();
            e1.Designation = "Professor";
            e1.Id = 29;
            e1.Name = "Prashant";
            Console.WriteLine("Employee`s Name is ;" + e1.Name);
            Console.WriteLine("Employye`s Id is :" + e1.Id);
            Console.WriteLine("Emlpoyee`s Role Id is :" e1.Designation);

        }
    }
}
