using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArms
{
    class Arm
    {
        string arm_side;
        //x軸的資訊
        public int xaxis_X, xaxis_Z, xaxis_Width, xaxis_Height;
        //z軸的資訊
        public int zaxis_X, zaxis_Z, zaxis_Width, zaxis_Height;

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


        //TODO: 手臂會有的功能 UP Down Left Right Seize Release Create Remove Show Hide 
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
        public void R_Left()
        {            
            zaxis_X--;
            xaxis_X--;
            xaxis_Width++;
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
        public void R_Right()
        {
            xaxis_Width--;
            zaxis_X++;
            xaxis_X++;
        }
        /****************************************************/
        public void  Seize() {
            seize = 1;

        }
        public void Release() {
            seize = 2;
        }

        void Create() { }
        void Remove() { }
        
        void Show() { }
        void Hide() { }
    }
}
        
