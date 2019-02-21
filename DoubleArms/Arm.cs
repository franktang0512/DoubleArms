using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArms
{
    partial class Arm
    {
        //(左\右)手臂
        string arm_side;
        //x軸的資訊
        int xaxis_X, xaxis_Z, xaxis_Width, xaxis_Height;
        //z軸的資訊
        int zaxis_X, zaxis_Z, zaxis_Width, zaxis_Height;
        //parall左右控制  virtical 上下控制
        int virtical = 0, parall = 0;
        //抓取控制
        int seize;

        public Arm(string armside,int xx, int xz, int zx, int zz) {
            arm_side = armside;
            //x軸原來大小
            xaxis_Width = 80;
            xaxis_Height = 15;
            //z軸原來大小
            zaxis_Width = 15;
            zaxis_Height = 65;
            //x,z軸因左右不同座標不同
            xaxis_X = xx;
            xaxis_Z = xz;
            zaxis_X = zx;
            zaxis_Z = zz;       
        }
    }
    partial class Arm {
        public void UP()
        {
            zaxis_Z--;
        }
        public void Down()
        {
            zaxis_Z++;
        }
        public void Left()
        {
            if (arm_side.Equals("right"))
            {
                xaxis_Width++;
                zaxis_X--;
                xaxis_X--;
            }
            else
            {
                xaxis_Width--;
                zaxis_X--;
            }
        }
        public void Right()
        {
            if (arm_side.Equals("right"))
            {
                xaxis_Width--;
                zaxis_X++;
                xaxis_X++;
            }
            else
            {
                xaxis_Width++;
                zaxis_X++;
            }
        }
        public void Seize()
        {
            seize = 1;
        }
        public void Release()
        {
            seize = 2;
        }

    }
    partial class Arm {
        public int getXX()
        {
            return xaxis_X;
        }
        public int getXZ()
        {
            return xaxis_Z;
        }
        public int getZX()
        {
            return zaxis_X;
        }
        public int getZZ()
        {
            return zaxis_Z;
        }
        public int getXWidth()
        {
            return xaxis_Width;
        }
        public int getZWidth()
        {
            return zaxis_Width;
        }
        public int getXHeight()
        {
            return xaxis_Height;
        }
        public int getZHeight()
        {
            return zaxis_Height;
        }
        public int getSeize()
        {
            return seize;
        }
        public int getVirtical()
        {
            return virtical;
        }
        public int getParall()
        {
            return parall;
        }
    
    }
    partial class Arm {
        public void setXX(int xx)
        {
            xaxis_X=xx;
        }
        public void setXZ(int xz)
        {
            xaxis_Z=xz;
        }
        public void setZX(int zx)
        {
            zaxis_X = zx;
        }
        public void setZZ(int zz)
        {
            zaxis_Z = zz;
        }
        public void setXWidth(int xw)
        {

            xaxis_Width=xw;
        }
        public void setZWidth(int zw)
        {
            zaxis_Width=zw;
        }
        public void setXHeight(int xh)
        {
            xaxis_Height=xh;
        }
        public void setZHeight(int zh)
        {
            zaxis_Height=zh;
        }
        public void setSeize(int s)
        {
            seize=s;
        }
        public void setVirtical(int v)
        {
            virtical=v;
        }
        public void setParall(int p)
        {
            parall=p;
        }
    }
}
        
