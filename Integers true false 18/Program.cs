using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integers_true_false_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int y=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine((x < 0 && y > 0)||(x > 0 && y < 0));
            //Console.ReadLine();
            
            if((x < 0 && y > 0) || (x > 0 && y < 0))
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
        }
    }
}
