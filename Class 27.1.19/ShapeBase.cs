using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2701
{
    abstract class ShapeBase
    {
        public double areas;
        public double hekef;

        public abstract void CalcHekef();
        public abstract void CalcArea();
    }
}
