using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    class Iteration
    {
        public void whilellop()
        {
            //While Loop
            Console.WriteLine(" While Example");
            int a = 1;
            while (a <= 10) 
            {
                Console.WriteLine(a);
                a++;
            }
            Console.WriteLine("***END***");
            Console.ReadLine();
        }

        public void DOWhileLoop()
        {
            //Do-While Loop
            Console.WriteLine("\nDo-While Example");
            int b = 1;
            do
            {
                Console.WriteLine(b);
                b++;
            } while (b <= 10);
            Console.WriteLine("***END***");
            Console.WriteLine();
        }
        public void ForLoop()
        {
            //For Loop
            Console.WriteLine("For Loop Example");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(1);

            }
            Console.WriteLine("***END***");
            Console.ReadLine();
        }
    }
}
