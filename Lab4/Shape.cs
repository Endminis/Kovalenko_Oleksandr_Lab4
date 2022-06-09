using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class Shape
    {
        public string Color;
        public abstract void IsPointBelongs(int x, int y);

    }
}
