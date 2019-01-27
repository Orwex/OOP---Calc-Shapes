using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2701
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle
            {
                _a = 4,
                _b = 5,
                _c = 10,
                _h = 8,
            };

            Circle c = new Circle
            {
                _r = 7.5
            };

            t.CalcArea();
            t.CalcHekef();
            Console.WriteLine(t.ToString());

            c.CalcArea();
            c.CalcHekef();
            Console.WriteLine(c.ToString());

            Console.ReadKey();
        }
    }
}
