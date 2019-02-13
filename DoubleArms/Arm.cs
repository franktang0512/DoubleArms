using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArms
{
    class Arm
    {
        //x軸的資訊
        public int xaxis_X, xaxis_Z, xaxis_Width, xaxis_Height;
        //z軸的資訊
        public int zaxis_X, zaxis_Z, zaxis_Width, zaxis_Height;

        public Arm(int xx, int xz, int zx, int zz) {
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
            xaxis_Width--;
            zaxis_X--;
        
        }
        public void Right()
        {
            xaxis_Width++;
            zaxis_X++;       
        }
        public void Stop() { }
        public void ArmDataProvider(out int xx,out int xz,out int xw,out int xh,out int zx,out int zz,out int zw,out int zh) {
            xx = xaxis_X;
            xz = xaxis_Z;
            xw = xaxis_Width;
            xh = xaxis_Height;

            zx = zaxis_X;
            zz = zaxis_Z;
            zw = zaxis_Width;
            zh = zaxis_Height;
        
        }


        /****************************************************/
        void Seize() { }
        void Release() { }

        void Create() { }
        void Remove() { }
        
        void Show() { }
        void Hide() { }
    }
}
        
