using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleArms
{
    public partial class Form1 : Form
    {
        private int arm1_x, arm1_y;
        private int arm1_width, arm1_height,M,N;

        Arm arm;
        int imove = 0;

        public Form1()
        {
            InitializeComponent();
            arm1_x = 0;
            arm1_y = 100;
            arm1_width = 100;
            arm1_height = 30;
            M = 70; N = 100;
        }

        private void ForArm1_Tick(object sender, EventArgs e)
        {
            //TODO:顯示每個時刻Arm物件中的資料對於圖形改變的程式於此
            arm1_width += 1;
            M += 1;
            if (imove == 0)
            {
                N += 10;
                imove = 1;
            }
            else {
                N -= 10;
                imove = 0;
            }

            Invalidate();
        }

        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            //x軸長方形L
            e.Graphics.FillRectangle(Brushes.BlueViolet, arm1_x, arm1_y, arm1_width, arm1_height);
            //z軸長方形L
            e.Graphics.FillRectangle(Brushes.White, M,N,30,100);

            ////x軸長方形R
            //e.Graphics.FillRectangle(Brushes.BlueViolet, arm1_x, arm1_y, arm1_width, arm1_height);
            ////z軸長方形R
            //e.Graphics.FillRectangle(Brushes.BlueViolet, 50, 50, 50, 50);

            ////障礙物1
            //e.Graphics.FillRectangle(Brushes.BlueViolet, 50, 50, 50, 50);
            ////障礙物2
            //e.Graphics.FillRectangle(Brushes.BlueViolet, 50, 50, 50, 50);


        }
    }
}
