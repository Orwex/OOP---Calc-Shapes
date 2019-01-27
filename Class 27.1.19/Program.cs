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

            Console.WriteLine(t);
            Console.WriteLine(c);

            PrintCircleArea(c);
            PrintTriangle(t);

            TriangleRightAngle t3 = new TriangleRightAngle();
            PrintTriangle(t3);

        }

        private static void PrintCircleArea(Circle c2)
        {
            c2.CalcArea();
            Console.WriteLine(c2.areas);
        }

        private static void PrintTriangle(Triangle t2)
        {
            t2.CalcArea();
            Console.WriteLine(t2.areas);
        }

        static void PrintAreasOfShape(ShapeBase s2)
        {
            s2.CalcArea();
            Console.WriteLine(s2.areas);
        {
    }
}
