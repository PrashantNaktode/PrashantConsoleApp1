using System;
using Logics1;
using Xceed.Wpf.Toolkit;

namespace PrashantConsoleApp1
{
    class Practice1
    {
        public static void Main(string[] args)
            
        {
            Add obj = new Add();
            obj.Addition();
            DataTypes1 obj1 = new DataTypes1();
            obj1.DTImplementation();
            Logics1.Calculator obj2 = new Logics1.Calculator();
            obj2.Addition();
            obj2.Subtraction();
            Console.ReadKey();
        }
        class Add
        {
            public void Addition()
            {

                int a = 50;
                int b = 25;
                int res = a + b;
                Console.WriteLine("The addition of a and b is " + res);

            }
            

           

            
        }


    }
}
