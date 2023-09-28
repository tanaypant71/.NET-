using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCast_Deligates
{
    internal class Program
    {
        public delegate void circleDeligates(double radius);

        public void area(double radius)
        {
            Console.WriteLine("Area of Circle: {0}", (3.14 * radius * radius));
        }

        public void perimeter(double radius)
        {
            Console.WriteLine("Circumference of Circle: {0} ", (2 * 3.14 * radius));
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            circleDeligates cd = new circleDeligates(p.area);
            cd += p.perimeter;
            cd.Invoke(10);
            Console.WriteLine();
            cd.Invoke(20);
        }
    }
}
