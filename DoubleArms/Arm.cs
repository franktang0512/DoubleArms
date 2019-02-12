using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArms
{
    class Arm
    {
        X_axis xaxis;
        Z_axis zaxis;

        Arm() {

        }

        public static Arm CreateArm() {
            return new Arm();
        }
        //TODO: 手臂會有的功能 UP Down Left Right Seize Release Create Remove Show Hide 
        void UP() {
            zaxis.z--;
        
        }
        void Down() {
            zaxis.z++;
        }
        void Left() {
            xaxis.x--;
            zaxis.x = xaxis.x;
        
        }
        void Right() {
            xaxis.x++;
            zaxis.x = xaxis.x;        
        }
        void Seize() { }
        void Release() { }

        void Create() { }
        void Remove() { }
        
        void Show() { }
        void Hide() { }
    }

    class X_axis{
        //x軸的控制點為和z軸交接的地方
        public int x;
        public const int z = 100;
        X_axis(){
        
        }    
    }
    class Z_axis{
        public int x, z;
        Z_axis() { }
     
    }
}
        
