using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrashantConsoleApp1
{
    class Inheritence
    {
        public class user  //parent clss
        {
            //set variables to private
            private string name;
            private int id;
            public int userid;
            public int Id { get; set; }
            //{
            // get
            //   return id;
            // }
            // set
            // {
            //    id = value;
            // }
            //}
            public string Name { get; set; }

        }
        public class employee : user // : is use for inheritence Employee is inheriting the user class for geting and setting}
        {
            private string designation;
            public string Designation { get; set; }
            public static void main(string[] args)
            {
                user usr = new user();
                usr.Id = 10;
                usr.Name = "Anita";

                employee e1 = new employee();
                // access curent class member
                e1.designation = "Professor";
                // acces base class member
                e1.Id = 29;
                e1.Name = "Prashant";
                Console.WriteLine(" Employee's Name is :" + e1.Name);
                Console.WriteLine("Employee's Id is ;" + e1.Id);
                Console.WriteLine("Employee's Role Id is :" + e1.Designation);
                Console.ReadKey();
            }
        }
    }
}
            
        
