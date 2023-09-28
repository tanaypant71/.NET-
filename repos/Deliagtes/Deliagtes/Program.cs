using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliagtes
{
    public delegate void mulnum(int a, int b);
    public delegate void divnum(int a, int b);
    internal class Program
    {
        public void multiply(int a, int b)
        {
            Console.WriteLine("(23 * 4) = {0}", a * b);
        }

        public void divide(int a, int b)
        {
            Console.WriteLine("(100 / 20) = {0}", a / b);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            mulnum d_obj1 = new mulnum(obj.multiply);
            divnum d_obj2 = new divnum(obj.divide);
            d_obj1(23, 4);
            d_obj2(100, 20);
        }
    }
}
