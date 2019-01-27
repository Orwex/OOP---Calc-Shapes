using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2701
{
    class Triangle : ShapeBase
    {

        public double _a, _b, _c, _h;

        public override void CalcArea()
        {
            areas = (_c * _h) / 2;
        }

        public override void CalcHekef()
        {
            hekef = _a + _b + _c;
        }

        public override string ToString()
        {
            return $"The area is : {areas}, The Perimeter is : {hekef}, The Height is {_h} The base is {_c}";
        }
    }
}
