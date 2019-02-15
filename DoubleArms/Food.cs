using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArms
{
    class Food
    {
        public int X, Z, Width, Height;
        public Food(string prefix) {
            if (prefix.Equals("front")) { }
            if (prefix.Equals("middle")) { }
        
        }

        public Food()
        {
            X = 65;
            Z = 105;
            Width = 15;
            Height = 10;
        }

        public void setXZ(int x, int z)
        {
            X = x;
            Z = z;
        }
    }
}
