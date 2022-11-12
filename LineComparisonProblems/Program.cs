using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values for line1 x1,y1,x2,y2");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values for line1 x1,y1,x2,y2");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            var a = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            var b = Math.Sqrt((Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2)));
            Console.WriteLine("Length of line1 is :" + a);
            Console.WriteLine("Length of line2 is :" + b);
            var result = Equals(a, b);
            if (result == false)
            {
                Console.WriteLine("Ines are not equal");
            }
            else
            {
                Console.WriteLine("Lines are equal");
            }
            
            Console.ReadLine();
        }
    }
}
