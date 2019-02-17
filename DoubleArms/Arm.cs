using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArms
{
    class Arm
    {
        //(左\右)手臂
        string arm_side;
        //x軸的資訊
        public int xaxis_X, xaxis_Z, xaxis_Width, xaxis_Height;
        //z軸的資訊
        public int zaxis_X, zaxis_Z, zaxis_Width, zaxis_Height;
        //parall左右控制  virtical 上下控制
        public int virtical = 0, parall = 0;
        //抓取控制
        public int seize;

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
            else {
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
            else {
                xaxis_Width++;
                zaxis_X++;            
            }       
        }
        public void Seize() {
            seize = 1;
        }
        public void Release() {
            seize = 2;
        }



    }
}
        
