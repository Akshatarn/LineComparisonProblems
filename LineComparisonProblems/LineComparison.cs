using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblems
{
    internal class LineComparison
    {
        static void Main(string[] args)
        {
            
            int length = 0;
            Console.WriteLine("Enter values for x1,y1,x2,y2");
            int x1 = Convert.ToInt32( Console.ReadLine());
            int y1 = Convert.ToInt32( Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int X = Math.Pow(x2 - x1, 2);
            int Y = ((x2 - x1)**2);
            length = Math.Sqrt(Math.Pow((x2 - x1), 2)+Math.Pow(y2 - y1, 2) * 1.0);
            Console.WriteLine("Length of line is :" + length);

        }
    }
}
