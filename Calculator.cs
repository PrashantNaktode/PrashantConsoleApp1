using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics1
{
    public class Calculator
    {
        
        public void Addition()
        {
            int a = 50;
            int b = 20;
            int res = a + b;
            Console.WriteLine("The Addition Of a and b is" + res);
        }
        public void Subtraction()
        {
            int a = 50;
            int b = 20;
            int res = a - b;
            Console.WriteLine("The Subtraction of a and b is", res);
        }
    }
}
