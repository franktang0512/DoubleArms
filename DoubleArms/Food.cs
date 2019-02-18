using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArms
{
    class Food
    {
        int X, Z, Width, Height,color;

        public Food(int x, int z)
        {
            X = x;
            Z = z;
            Width = 15;
            Height = 10;
        }

        public void setXZ(int x, int z)
        {
            X = x;
            Z = z;
        }
        public int getX() {
            return X;
        }
        public int getZ()
        {
            return Z;
        }
        public int getWidth()
        {
            return Width;
        }
        public int getHeight()
        {
            return Height;
        }
        public int getColor() {
            return color;        
        }
        public void setColor(int c) {
            color = c;
        }
    }
}
