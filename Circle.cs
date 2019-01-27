using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2701
{
    class Circle : ShapeBase
    {
        public double _r;

        public override void CalcHekef()
        {
            hekef = Math.PI * 2 * _r;
        }

        public override void CalcArea()
        {
            areas = Math.PI * _r * _r;
        }

        public override string ToString()
        {
            return $"The area is : {areas}, The Perimeter is : {hekef}, The Radius is {_r}";
        }
    }
}
